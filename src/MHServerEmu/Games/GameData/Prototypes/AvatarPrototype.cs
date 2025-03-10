﻿using MHServerEmu.Games.GameData.Calligraphy.Attributes;

namespace MHServerEmu.Games.GameData.Prototypes
{
    #region Enums

    [AssetEnum((int)Invalid)]
    public enum AvatarStat
    {
        Invalid = 0,
        Durability = 1,
        Energy = 2,
        Fighting = 3,
        Intelligence = 4,
        Speed = 5,
        Strength = 6,
    }

    [AssetEnum((int)Invalid)]
    public enum AvatarMode
    {
        Invalid = -1,
        Normal = 0,
        Hardcore = 1,
        Ladder = 2,
    }

    #endregion

    public class AvatarPrototype : AgentPrototype
    {
        public LocaleStringId BioText { get; protected set; }
        public AbilityAssignmentPrototype[] HiddenPassivePowers { get; protected set; }
        public AssetId PortraitPath { get; protected set; }
        public PrototypeId StartingLootTable { get; protected set; }
        public AssetId UnlockDialogImage { get; protected set; }
        public AssetId HUDTheme { get; protected set; }
        public AvatarPrimaryStatPrototype[] PrimaryStats { get; protected set; }
        public PowerProgressionTablePrototype[] PowerProgressionTables { get; protected set; }
        public ItemAssignmentPrototype StartingCostume { get; protected set; }
        public PrototypeId ResurrectOtherEntityPower { get; protected set; }
        public AvatarEquipInventoryAssignmentPrototype[] EquipmentInventories { get; protected set; }
        public PrototypeId PartyBonusPower { get; protected set; }
        public LocaleStringId UnlockDialogText { get; protected set; }
        public PrototypeId SecondaryResourceBehavior { get; protected set; }
        public PrototypeId[] LoadingScreens { get; protected set; }
        public int PowerProgressionVersion { get; protected set; }
        public PrototypeId OnLevelUpEval { get; protected set; }
        public EvalPrototype OnPartySizeChange { get; protected set; }
        public PrototypeId StatsPower { get; protected set; }
        public AssetId SocialIconPath { get; protected set; }
        public AssetId CharacterSelectIconPath { get; protected set; }
        public PrototypeId[] StatProgressionTable { get; protected set; }
        public TransformModeEntryPrototype[] TransformModes { get; protected set; }
        public AvatarSynergyEntryPrototype[] SynergyTable { get; protected set; }
        public PrototypeId[] SuperteamMemberships { get; protected set; }
        public PrototypeId[] CharacterSelectPowers { get; protected set; }
        public PrototypeId[] PrimaryResourceBehaviors { get; protected set; }     // VectorPrototypeRefPtr PrimaryResourceManaBehaviorPrototype
        public PrototypeId[] StealablePowersAllowed { get; protected set; }       // VectorPrototypeRefPtr StealablePowerInfoPrototype
        public bool ShowInRosterIfLocked { get; protected set; }
        public LocaleStringId CharacterVideoUrl { get; protected set; }
        public AssetId CharacterSelectIconPortraitSmall { get; protected set; }
        public AssetId CharacterSelectIconPortraitFull { get; protected set; }
        public LocaleStringId PrimaryResourceBehaviorNames { get; protected set; }
        public bool IsStarterAvatar { get; protected set; }
        public int CharacterSelectDisplayOrder { get; protected set; }
        public PrototypeId CostumeCore { get; protected set; }
        public TalentGroupPrototype[] TalentGroups { get; protected set; }
        public PrototypeId TravelPower { get; protected set; }
        public AbilityAutoAssignmentSlotPrototype[] AbilityAutoAssignmentSlot { get; protected set; }
        public PrototypeId[] LoadingScreensConsole { get; protected set; }
        public ItemAssignmentPrototype StartingCostumePS4 { get; protected set; }
        public ItemAssignmentPrototype StartingCostumeXboxOne { get; protected set; }
    }

    public class ItemAssignmentPrototype : Prototype
    {
        public PrototypeId Item { get; protected set; }
        public PrototypeId Rarity { get; protected set; }
    }

    public class AvatarPrimaryStatPrototype : Prototype
    {
        public AvatarStat Stat { get; protected set; }
        public LocaleStringId Tooltip { get; protected set; }
    }

    public class IngredientLookupEntryPrototype : Prototype
    {
        public long LookupSlot { get; protected set; }
        public PrototypeId Ingredient { get; protected set; }
    }

    public class AvatarSynergyEntryPrototype : Prototype
    {
        public int Level { get; protected set; }
        public LocaleStringId TooltipTextForIcon { get; protected set; }
        public PrototypeId UIData { get; protected set; }
    }

    public class AvatarSynergyEvalEntryPrototype : AvatarSynergyEntryPrototype
    {
        public EvalPrototype SynergyEval { get; protected set; }
    }

    public class VanityTitlePrototype : Prototype
    {
        public LocaleStringId Text { get; protected set; }
    }

    public class PowerSpecPrototype : Prototype
    {
        public int Index { get; protected set; }
    }

    public class TalentEntryPrototype : Prototype
    {
        public PrototypeId Talent { get; protected set; }
        public int UnlockLevel { get; protected set; }
    }

    public class TalentGroupPrototype : Prototype
    {
        public TalentEntryPrototype[] Talents { get; protected set; }
        public float UIPositionPctX { get; protected set; }
        public float UIPositionPctY { get; protected set; }
    }

    public class AvatarModePrototype : Prototype
    {
        public AvatarMode AvatarModeEnum { get; protected set; }
        public ConvenienceLabel Inventory { get; protected set; }
    }

    public class StatProgressionEntryPrototype : Prototype
    {
        public int Level { get; protected set; }
        public int DurabilityValue { get; protected set; }
        public int EnergyProjectionValue { get; protected set; }
        public int FightingSkillsValue { get; protected set; }
        public int IntelligenceValue { get; protected set; }
        public int SpeedValue { get; protected set; }
        public int StrengthValue { get; protected set; }
    }

    public class PowerProgressionEntryPrototype : ProgressionEntryPrototype
    {
        public int Level { get; protected set; }
        public AbilityAssignmentPrototype PowerAssignment { get; protected set; }
        public CurveId MaxRankForPowerAtCharacterLevel { get; protected set; }
        public PrototypeId[] Prerequisites { get; protected set; }
        public float UIPositionPctX { get; protected set; }
        public float UIPositionPctY { get; protected set; }
        public int UIFanSortNumber { get; protected set; }
        public int UIFanTier { get; protected set; }
        public PrototypeId[] Antirequisites { get; protected set; }
        public bool IsTrait { get; protected set; }
    }

    public class PowerProgressionTablePrototype : Prototype
    {
        public LocaleStringId DisplayName { get; protected set; }
        public PowerProgressionEntryPrototype[] PowerProgressionEntries { get; protected set; }
    }

    public class PowerProgTableTabRefPrototype : Prototype
    {
        public int PowerProgTableTabIndex { get; protected set; }
    }
}
