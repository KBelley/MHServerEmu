﻿using MHServerEmu.Games.GameData;

namespace MHServerEmu.Games.Entities.Avatars
{
    public static class AvatarPrototypeEnumExtensions
    {
        public static HardcodedAvatarEntityId ToEntityId(this AvatarPrototypeId prototype)
        {
            return Enum.Parse<HardcodedAvatarEntityId>(Enum.GetName(prototype));
        }

        public static PrototypeId ToAvatarPrototypeId(this HardcodedAvatarEntityId avatarEntityId)
        {
            return (PrototypeId)Enum.Parse<AvatarPrototypeId>(Enum.GetName(avatarEntityId));
        }

        public static HardcodedAvatarPropertyCollectionReplicationId ToPropertyCollectionReplicationId(this HardcodedAvatarEntityId avatarEntityId)
        {
            return Enum.Parse<HardcodedAvatarPropertyCollectionReplicationId>(Enum.GetName(avatarEntityId));
        }

        public static HardcodedAvatarPropertyCollectionReplicationId ToPropertyCollectionReplicationId(this AvatarPrototypeId prototype)
        {
            return Enum.Parse<HardcodedAvatarPropertyCollectionReplicationId>(Enum.GetName(prototype));
        }
    }

    public enum AvatarUnlockType : long
    {
        None,
        Starter,
        Type2,
        Type3,
        Type4,
        Type5,
        Type6
    }

    public enum AvatarPrototypeId : ulong
    {
        Angela = 13124420519155930214,
        AntMan = 18132742377931805821,
        Beast = 17049937000059835405,
        BlackBolt = 6223810743151629740,
        BlackCat = 12534955053251630387,
        BlackPanther = 456629384788186861,
        BlackWidow = 10144061740894656037,
        Blade = 6139368802772849654,
        Cable = 16209821644389487605,
        CaptainAmerica = 10617813376954079152,
        Carnage = 1644838416155284687,
        Colossus = 11118079530304738681,
        Cyclops = 6572304655153960187,
        Daredevil = 11615789429029934510,
        Deadpool = 1660250039076459846,
        DoctorStrange = 9703681217466931069,
        DrDoom = 17750839636937086083,
        Elektra = 7937405352416253158,
        EmmaFrost = 412966192105395660,
        Gambit = 6448072532466209906,
        GhostRider = 9255468350667101753,
        GreenGoblin = 7015297277250377354,
        Hawkeye = 3597588143900726508,
        Hulk = 8294172517850551218,
        HumanTorch = 6996312464889026103,
        Iceman = 10305433616491287659,
        InvisibleWoman = 12259390671146653669,
        IronFist = 13212972008131138924,
        IronMan = 421791326977791218,
        JeanGrey = 12460013083760072019,
        Juggernaut = 13061049321858668090,
        KittyPryde = 1172420421674735191,
        Loki = 14419064055405876141,
        LukeCage = 14354783269825877311,
        Magik = 15743789998840419335,
        Magneto = 8755692150967833833,
        MoonKnight = 4196473162086422076,
        MrFantastic = 17591756837553313434,
        MsMarvel = 17510769099164947813,
        NickFury = 2198068880456357225,
        Nightcrawler = 18152689483875489544,
        Nova = 72066007482110898,
        Psylocke = 724683970231539048,
        Punisher = 4616550151502632300,
        RocketRaccoon = 8842376528969668459,
        Rogue = 6514650100102861856,
        ScarletWitch = 13840162506148812555,
        SheHulk = 12394659164528645362,
        SilverSurfer = 11103546526429026090,
        Spiderman = 9378552423541970369,
        SquirrelGirl = 13109043516307281699,
        Starlord = 5394058310044226921,
        Storm = 6791894920589808691,
        Taskmaster = 13583994425176888893,
        Thing = 14005962908529333272,
        Thor = 7949859047165531067,
        Ultron = 1977663415972730018,
        Venom = 15662110445428479011,
        Vision = 3980807850392229014,
        WarMachine = 8651855704152086045,
        WinterSoldier = 15115104590402361225,
        Wolverine = 13237838511939982809,
        X23 = 7643048032188437211
    }

    public enum HardcodedAvatarEntityId : ulong
    {
        HumanTorch = 14646213,
        Punisher = 14646214,
        GreenGoblin = 14646215,
        Loki = 14646216,
        Vision = 14646217,
        Juggernaut = 14646218,
        BlackBolt = 14646219,
        Hawkeye = 14646220,
        CaptainAmerica = 14646221,
        NickFury = 14646222,
        Magneto = 14646223,
        SheHulk = 14646224,
        ScarletWitch = 14646225,
        KittyPryde = 14646226,
        WarMachine = 14646227,
        Nova = 14646228,
        Psylocke = 14646229,
        Gambit = 14646230,
        Magik = 14646231,
        Venom = 14646232,
        Cyclops = 14646233,
        MrFantastic = 14646234,
        JeanGrey = 14646235,
        DoctorStrange = 14646236,
        Wolverine = 14646237,
        WinterSoldier = 14646238,
        Deadpool = 14646239,
        RocketRaccoon = 14646240,
        BlackWidow = 14646241,
        Daredevil = 14646242,
        Cable = 14646243,
        IronFist = 14646244,
        Storm = 14646245,
        SilverSurfer = 14646246,
        Elektra = 14646247,
        Thing = 14646248,
        Beast = 14646249,
        Colossus = 14646250,
        Ultron = 14646251,
        SquirrelGirl = 14646252,
        InvisibleWoman = 14646253,
        Nightcrawler = 14646254,
        Carnage = 14646255,
        Rogue = 14646256,
        Starlord = 14646257,
        AntMan = 14646258,
        LukeCage = 14646259,
        DrDoom = 14646260,
        MsMarvel = 14646261,
        Spiderman = 14646262,
        Taskmaster = 14646263,
        EmmaFrost = 14646264,
        Iceman = 14646265,
        BlackPanther = 14646266,
        X23 = 14646267,
        IronMan = 14646268,
        Hulk = 14646269,
        Thor = 14646270,
        Angela = 14646271,
        GhostRider = 14646272,
        Blade = 14646273,
        MoonKnight = 14646274,
        BlackCat = 14646322
    }

    public enum HardcodedAvatarPropertyCollectionReplicationId : ulong
    {
        HumanTorch = 9078336,
        Punisher = 9078338,
        GreenGoblin = 9078340,
        Loki = 9078342,
        Vision = 9078344,
        Juggernaut = 9078346,
        BlackBolt = 9078348,
        Hawkeye = 9078350,
        CaptainAmerica = 9078352,
        NickFury = 9078354,
        Magneto = 9078356,
        SheHulk = 9078358,
        ScarletWitch = 9078360,
        KittyPryde = 9078362,
        WarMachine = 9078364,
        Nova = 9078366,
        Psylocke = 9078368,
        Gambit = 9078370,
        Magik = 9078372,
        Venom = 9078374,
        Cyclops = 9078376,
        MrFantastic = 9078378,
        JeanGrey = 9078380,
        DoctorStrange = 9078382,
        Wolverine = 9078384,
        WinterSoldier = 9078386,
        Deadpool = 9078388,
        RocketRaccoon = 9078390,
        BlackWidow = 9078392,
        Daredevil = 9078394,
        Cable = 9078396,
        IronFist = 9078398,
        Storm = 9078400,
        SilverSurfer = 9078402,
        Elektra = 9078404,
        Thing = 9078406,
        Beast = 9078408,
        Colossus = 9078410,
        Ultron = 9078412,
        SquirrelGirl = 9078414,
        InvisibleWoman = 9078416,
        Nightcrawler = 9078418,
        Carnage = 9078420,
        Rogue = 9078422,
        Starlord = 9078424,
        AntMan = 9078426,
        LukeCage = 9078428,
        DrDoom = 9078430,
        MsMarvel = 9078432,
        Spiderman = 9078434,
        Taskmaster = 9078436,
        EmmaFrost = 9078438,
        Iceman = 9078440,
        BlackPanther = 9078442,
        X23 = 9078444,
        IronMan = 9078446,
        Hulk = 9078448,
        Thor = 9078450,
        Angela = 9078452,
        GhostRider = 9078454,
        Blade = 9078456,
        MoonKnight = 9078458,
        BlackCat = 9078507
    }
}
