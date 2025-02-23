﻿using MHServerEmu.Common.Logging;

namespace MHServerEmu.Common.Config.Containers
{
    public class LoggingConfig : ConfigContainer
    {
        public bool EnableLogging { get; private set; }
        public bool SynchronousMode { get; private set; }

        public bool EnableConsole { get; private set; }
        public bool ConsoleIncludeTimestamps { get; private set; }
        public LoggingLevel ConsoleMinLevel { get; private set; }
        public LoggingLevel ConsoleMaxLevel { get; private set; }

        public bool EnableFile { get; private set; }
        public bool FileIncludeTimestamps { get; private set; }
        public LoggingLevel FileMinLevel { get; private set; }
        public LoggingLevel FileMaxLevel { get; private set; }

        public LoggingConfig(IniFile configFile) : base(configFile) { }
    }
}
