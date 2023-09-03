﻿using MHServerEmu.Common;
using MHServerEmu.GameServer.GameData.Gpak;
using MHServerEmu.GameServer.Properties;

namespace MHServerEmu.GameServer.GameData
{
    public static class GameDatabase
    {
        private static readonly Logger Logger = LogManager.CreateLogger();

        public static bool IsInitialized { get; private set; }

        public static CalligraphyStorage Calligraphy { get; private set; }
        public static ResourceStorage Resource { get; private set; }
        public static PrototypeRefManager PrototypeRefManager { get; private set; }
        public static PropertyInfoTable PropertyInfoTable { get; private set; }

        static GameDatabase()
        {
            long startTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();

            // Initialize GPAK
            Calligraphy = new(new("Calligraphy.sip"));
            Resource = new(new("mu_cdata.sip"));

            // Initialize derivative GPAK data
            PrototypeRefManager = new(Calligraphy, Resource);       // this needs to be initialized before PropertyInfoTable
            PropertyInfoTable = new(Calligraphy);

            // Verify and finish game database initialization
            if (VerifyData())
            {
                long loadTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds() - startTime;
                Logger.Info($"Finished initializing game database in {loadTime} ms");
                IsInitialized = true;
            }
            else
            {
                Logger.Fatal("Failed to initialize game database");
                IsInitialized = false;
            }
        }

        public static void ExtractGpakEntries()
        {
            Logger.Info("Extracting Calligraphy entries...");
            GpakFile calligraphyFile = new("Calligraphy.sip", true);
            calligraphyFile.ExtractEntries("Calligraphy.tsv");

            Logger.Info("Extracting Resource entries...");
            GpakFile resourceFile = new("mu_cdata.sip", true);
            resourceFile.ExtractEntries("mu_cdata.tsv");
        }

        public static void ExtractGpakData()
        {
            Logger.Info("Extracting Calligraphy data...");
            GpakFile calligraphyFile = new("Calligraphy.sip", true);
            calligraphyFile.ExtractData();

            Logger.Info("Extracting Resource data...");
            GpakFile resourceFile = new("mu_cdata.sip", true);
            resourceFile.ExtractData();
        }

        // Helper methods for shorter access to PrototypeRefManager
        public static string GetPrototypePath(ulong id) => PrototypeRefManager.GetPrototypePath(id);
        public static ulong GetPrototypeId(string path) => PrototypeRefManager.GetPrototypeId(path);
        public static ulong GetPrototypeId(ulong enumValue, PrototypeEnumType type) => PrototypeRefManager.GetPrototypeId(enumValue, type);
        public static ulong GetPrototypeEnumValue(ulong prototypeId, PrototypeEnumType type) => PrototypeRefManager.GetEnumValue(prototypeId, type);

        private static bool VerifyData()
        {
            return Calligraphy.Verify()
                && Resource.Verify()
                && PrototypeRefManager.Verify()
                && PropertyInfoTable.Verify();
        }
    }
}
