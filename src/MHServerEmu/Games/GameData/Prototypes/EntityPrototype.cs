﻿using MHServerEmu.Games.GameData.Calligraphy;
using MHServerEmu.Games.GameData.Calligraphy.Attributes;

namespace MHServerEmu.Games.GameData.Prototypes
{
    #region Enums

    [AssetEnum((int)None)]
    public enum EntitySelectorAttributeActions
    {
        None,
        DisableInteractions,
        EnableInteractions,
    }

    [AssetEnum((int)None)]
    [Flags]
    public enum EntitySelectorActionEventType
    {
        None = 0,
        OnDetectedEnemy = 1,
        OnGotAttacked = 2,
        OnGotDamaged = 4,
        OnGotDefeated = 8,
        OnGotKilled = 16,
        OnAllyDetectedEnemy = 32,
        OnAllyGotAttacked = 64,
        OnAllyGotKilled = 128,
        OnMetLeashDistance = 256,
        OnEnteredCombat = 512,
        OnExitedCombat = 1024,
        OnKilledOther = 2048,
        OnDetectedFriend = 4096,
        OnSimulated = 8192,
        OnEnemyProximity = 16384,
        OnDetectedPlayer = 32768,
        OnDetectedNonPlayer = 65536,
        OnAllyDetectedPlayer = 131072,
        OnAllyDetectedNonPlayer = 262144,
        OnClusterEnemiesCleared = 524288,
        OnPlayerInteract = 1048576,
        OnPlayerProximity = 2097152,
        OnGotAttackedByPlayer = 4194304,
        OnAllyGotAttackedByPlayer = 8388608,
        OnMissionBroadcast = 16777216,
    }

    [AssetEnum((int)Invalid)]
    public enum ScriptRoleKeyEnum
    {
        Invalid = 0,
        FriendlyPassive01 = 1,
        FriendlyPassive02 = 2,
        FriendlyPassive03 = 3,
        FriendlyPassive04 = 4,
        FriendlyCombatant01 = 5,
        FriendlyCombatant02 = 6,
        FriendlyCombatant03 = 7,
        FriendlyCombatant04 = 8,
        HostileCombatant01 = 9,
        HostileCombatant02 = 10,
        HostileCombatant03 = 11,
        HostileCombatant04 = 12,
    }

    [AssetEnum((int)None)]
    public enum LocomotorMethod
    {
        None = 0,
        Ground = 1,
        Airborne = 2,
        TallGround = 3,
        Missile = 4,
        MissileSeeking = 5,
        HighFlying = 6,
    }

    [AssetEnum((int)None)]
    public enum DialogStyle
    {
        None = 0,
        ComputerTerminal = 1,
        NPCDialog = 2,
        OverheadText = 3,
    }

    [AssetEnum((int)Transition)]
    public enum RegionTransitionType
    {
        Transition,
        TransitionDirect,
        Marker,
        Waypoint,
        TowerUp,
        TowerDown,
        PartyJoin,
        Checkpoint,
        TransitionDirectReturn,
        ReturnToLastTown,
        EndlessDown,
    }

    [AssetEnum((int)Invalid)]
    public enum EntityAppearanceEnum    // Entity/Types/AppearanceEnum.type
    {
        Invalid = -1,
        None = 0,
        Closed = 1,
        Destroyed = 2,
        Disabled = 3,
        Enabled = 4,
        Locked = 5,
        Open = 6,
        Dead = 7,
    }

    [AssetEnum((int)None)]
    public enum HotspotOverlapEventTriggerType
    {
        None = 0,
        Allies = 1,
        Enemies = 2,
        All = 3,
    }

    [AssetEnum((int)None)]
    public enum HotspotNegateByAllianceType
    {
        None = 0,
        Allies = 1,
        Enemies = 2,
        All = 3,
    }

    [AssetEnum((int)Never)]
    public enum SpawnerDefeatCriteria
    {
        Never = 0,
        MaxReachedAndNoHostileMobs = 1,
    }

    [AssetEnum((int)None)]
    public enum FormationFacing // Populations/Blueprints/FacingEnum.type
    {
        None = 0,
        FaceParent = 0,
        FaceParentInverse = 1,
        FaceOrigin = 2,
        FaceOriginInverse = 3,
    }

    [AssetEnum((int)Fail)]
    public enum SpawnFailBehavior
    {
        Fail = 0,
        RetryIgnoringBlackout = 1,
        RetryForce = 2,
    }

    [AssetEnum((int)Default)]
    public enum FactionColor
    {
        Default = 0,
        Red = 1,
        White = 2,
        Blue = 3,
    }

    [AssetEnum]
    public enum WaypointPOIType
    {
        HUB = 0,
        PCZ = 1,    // Public Combat Zone
        PI = 2,     // Private Instance
    }

    #endregion

    public class EntityPrototype : Prototype
    {
        public LocaleStringId DisplayName { get; protected set; }
        public AssetId IconPath { get; protected set; }                                  // A Entity/Types/EntityIconPathType.type
        public PrototypePropertyCollection Properties { get; protected set; }             // Populated from mixins? Parsed from the game as ulong?
        public bool ReplicateToProximity { get; protected set; }
        public bool ReplicateToParty { get; protected set; }
        public bool ReplicateToOwner { get; protected set; }
        public bool ReplicateToDiscovered { get; protected set; }
        public EntityInventoryAssignmentPrototype[] Inventories { get; protected set; }
        public EvalPrototype[] EvalOnCreate { get; protected set; }
        public LocaleStringId DisplayNameInformal { get; protected set; }
        public LocaleStringId DisplayNameShort { get; protected set; }
        public bool ReplicateToTrader { get; protected set; }
        public int LifespanMS { get; protected set; }
        public AssetId IconPathTooltipHeader { get; protected set; }                     // A Entity/Types/EntityIconPathType.type
        public AssetId IconPathHiRes { get; protected set; }                             // A Entity/Types/EntityIconPathType.type
    }

    public class WorldEntityPrototype : EntityPrototype
    {
        public PrototypeId Alliance { get; protected set; }
        public BoundsPrototype Bounds { get; protected set; }
        public LocaleStringId DialogText { get; protected set; }
        public AssetId UnrealClass { get; protected set; }
        public CurveId XPGrantedCurve { get; protected set; }
        public bool HACKBuildMouseCollision { get; protected set; }
        public PrototypeId PreInteractPower { get; protected set; }
        public DialogStyle DialogStyle { get; protected set; }
        public WeightedTextEntryPrototype[] DialogTextList { get; protected set; }
        public PrototypeId[] Keywords { get; protected set; }
        public DesignWorkflowState DesignState { get; protected set; }
        public PrototypeId Rank { get; protected set; }
        public LocomotorMethod NaviMethod { get; protected set; }
        public bool SnapToFloorOnSpawn { get; protected set; }
        public bool AffectNavigation { get; protected set; }
        public StateChangePrototype PostInteractState { get; protected set; }
        public StateChangePrototype PostKilledState { get; protected set; }
        public bool OrientToInteractor { get; protected set; }
        public PrototypeId TooltipInWorldTemplate { get; protected set; }
        public bool InteractIgnoreBoundsForDistance { get; protected set; }
        public float PopulationWeight { get; protected set; }
        public bool VisibleByDefault { get; protected set; }
        public int RemoveFromWorldTimerMS { get; protected set; }
        public bool RemoveNavInfluenceOnKilled { get; protected set; }
        public bool AlwaysSimulated { get; protected set; }
        public bool XPIsShared { get; protected set; }
        public PrototypeId TutorialTip { get; protected set; }
        public bool TrackingDisabled { get; protected set; }
        public PrototypeId[] ModifiersGuaranteed { get; protected set; }
        public float InteractRangeBonus { get; protected set; }
        public bool ShouldIgnoreMaxDeadBodies { get; protected set; }
        public bool ModifierSetEnable { get; protected set; }
        public bool LiveTuningDefaultEnabled { get; protected set; }
        public bool UpdateOrientationWithParent { get; protected set; }
        public bool MissionEntityDeathCredit { get; protected set; }
        public bool HACKDiscoverInRegion { get; protected set; }
        public bool CanCollideWithPowerUserItems { get; protected set; }
        public bool ForwardOnHitProcsToOwner { get; protected set; }
        public ObjectiveInfoPrototype ObjectiveInfo { get; protected set; }
        public WorldEntityIconsPrototype Icons { get; protected set; }
        public EntitySelectorActionPrototype[] EntitySelectorActions { get; protected set; }
        public bool OverheadIndicator { get; protected set; }
        public bool RequireCombatActiveForKillCredit { get; protected set; }
        public bool ClonePerPlayer { get; protected set; }
        public bool PrefetchMarkedAssets { get; protected set; }
        public AssetId MarvelModelRenderClass { get; protected set; }
        public DesignWorkflowState DesignStatePS4 { get; protected set; }
        public DesignWorkflowState DesignStateXboxOne { get; protected set; }
    }

    public class StateChangePrototype : Prototype
    {
    }

    public class StateTogglePrototype : StateChangePrototype
    {
        public PrototypeId StateA { get; protected set; }
        public PrototypeId StateB { get; protected set; }
    }

    public class StateSetPrototype : StateChangePrototype
    {
        public PrototypeId State { get; protected set; }
    }

    public class WorldEntityIconsPrototype : Prototype
    {
        public AssetId EdgeIcon { get; protected set; }
        public PrototypeId MapIcon { get; protected set; }
        public AssetId EdgeIconHiRes { get; protected set; }
    }

    #region EntityAction

    public class EntityActionBasePrototype : Prototype
    {
        public int Weight { get; protected set; }
    }

    public class EntityActionAIOverridePrototype : EntityActionBasePrototype
    {
        public PrototypeId Power { get; protected set; }
        public bool PowerRemove { get; protected set; }
        public PrototypeId Brain { get; protected set; }
        public bool BrainRemove { get; protected set; }
        public bool SelectorReferencedPowerRemove { get; protected set; }
        public int AIAggroRangeOverrideAlly { get; protected set; }
        public int AIAggroRangeOverrideEnemy { get; protected set; }
        public int AIProximityRangeOverride { get; protected set; }
        public int LifespanMS { get; protected set; }
        public PrototypeId LifespanEndPower { get; protected set; }
    }

    public class EntityActionOverheadTextPrototype : EntityActionBasePrototype
    {
        public LocaleStringId Text { get; protected set; }
        public int Duration { get; protected set; }
    }

    public class EntityActionEventBroadcastPrototype : EntityActionBasePrototype
    {
        public EntitySelectorActionEventType EventToBroadcast { get; protected set; }
        public int BroadcastRange { get; protected set; }
    }

    public class EntityActionSpawnerTriggerPrototype : EntityActionBasePrototype
    {
        public bool EnableClusterLocalSpawner { get; protected set; }
    }

    public class EntitySelectorActionBasePrototype : Prototype
    {
        public PrototypeId[] AIOverrides { get; protected set; }
        public EntityActionAIOverridePrototype[] AIOverridesList { get; protected set; }
        public PrototypeId[] OverheadTexts { get; protected set; }
        public EntityActionOverheadTextPrototype[] OverheadTextsList { get; protected set; }
        public PrototypeId[] Rewards { get; protected set; }
        public EntitySelectorAttributeActions[] AttributeActions { get; protected set; }
        public HUDEntitySettingsPrototype HUDEntitySettingOverride { get; protected set; }
    }

    public class EntitySelectorActionPrototype : EntitySelectorActionBasePrototype
    {
        public EntitySelectorActionEventType[] EventTypes { get; protected set; }
        public int ReactionTimeMS { get; protected set; }
        public EntitySelectorActionEventType[] CancelOnEventTypes { get; protected set; }
        public PrototypeId SpawnerTrigger { get; protected set; }
        public PrototypeId AllianceOverride { get; protected set; }
        public PrototypeId BroadcastEvent { get; protected set; }
    }

    public class EntitySelectorActionSetPrototype : Prototype
    {
        public EntitySelectorActionPrototype[] EntitySelectorActions { get; protected set; }
    }

    public class EntitySelectorPrototype : Prototype
    {
        public PrototypeId[] Entities { get; protected set; }
        public EntitySelectorActionPrototype[] EntitySelectorActions { get; protected set; }
        public PrototypeId EntitySelectorActionsTemplate { get; protected set; }
        public PrototypeId DefaultBrainOnSimulated { get; protected set; }
        public bool IgnoreMissionOwnerForTargeting { get; protected set; }
        public float DefaultAggroRangeAlly { get; protected set; }
        public float DefaultAggroRangeHostile { get; protected set; }
        public float DefaultProximityRangeHostile { get; protected set; }
        public EvalPrototype EvalSpawnProperties { get; protected set; }
        public bool SelectUniqueEntities { get; protected set; }
    }

    public class EntityActionTimelineScriptActionPrototype : EntitySelectorActionBasePrototype
    {
        public ScriptRoleKeyEnum[] ScriptRoleKeys { get; protected set; }
        public PrototypeId SpawnerTrigger { get; protected set; }
    }

    public class EntityActionTimelineScriptEventPrototype : Prototype
    {
        public PrototypeId[] ActionsList { get; protected set; }
        public EntityActionTimelineScriptActionPrototype[] ActionsVector { get; protected set; }
        public int EventTime { get; protected set; }
        public EntitySelectorActionEventType[] InterruptOnEventTypes { get; protected set; }
    }

    public class EntityActionTimelineScriptPrototype : Prototype
    {
        public EntitySelectorActionEventType[] TriggerOnEventTypes { get; protected set; }
        public EntitySelectorActionEventType[] CancelOnEventTypes { get; protected set; }
        public EntityActionTimelineScriptEventPrototype[] ScriptEvents { get; protected set; }
        public bool RunOnceOnly { get; protected set; }
    }

    #endregion

    public class WeightedTextEntryPrototype : Prototype
    {
        public LocaleStringId Text { get; protected set; }
        public long Weight { get; protected set; }
    }

    public class TransitionPrototype : WorldEntityPrototype
    {
        public RegionTransitionType Type { get; protected set; }
        public int SpawnOffset { get; protected set; }
        public PrototypeId Waypoint { get; protected set; }
        public bool SupressBlackout { get; protected set; }
        public bool ShowIndicator { get; protected set; }
        public bool ShowConfirmationDialog { get; protected set; }
        public PrototypeId DirectTarget { get; protected set; }
        public PrototypeId[] RegionAffixesBySummonerRarity { get; protected set; }
        public LocaleStringId ShowConfirmationDialogOverride { get; protected set; }
        public PrototypeId ShowConfirmationDialogTemplate { get; protected set; }
        public PrototypeId ShowConfirmationDialogEnemy { get; protected set; }
    }

    public class EntityAppearancePrototype : Prototype
    {
        public EntityAppearanceEnum AppearanceEnum { get; protected set; }
    }

    public class EntityStatePrototype : Prototype
    {
        public PrototypeId Appearance { get; protected set; }
        public PrototypeId[] OnActivatePowers { get; protected set; }
    }

    public class DoorEntityStatePrototype : EntityStatePrototype
    {
        public bool IsOpen { get; protected set; }
    }

    public class InteractionSpecPrototype : Prototype
    {
    }

    public class ConnectionTargetEnableSpecPrototype : InteractionSpecPrototype
    {
        public PrototypeId ConnectionTarget { get; protected set; }
        public bool Enabled { get; protected set; }
    }

    public class EntityBaseSpecPrototype : InteractionSpecPrototype
    {
        public EntityFilterPrototype EntityFilter { get; protected set; }
    }

    public class EntityVisibilitySpecPrototype : EntityBaseSpecPrototype
    {
        public bool Visible { get; protected set; }
    }

    public class EntityAppearanceSpecPrototype : EntityBaseSpecPrototype
    {
        public PrototypeId Appearance { get; protected set; }
        public LocaleStringId FailureReasonText { get; protected set; }
        public TriBool InteractionEnabled { get; protected set; }
    }

    public class HotspotDirectApplyToMissilesDataPrototype : Prototype
    {
        public bool AffectsAllyMissiles { get; protected set; }
        public bool AffectsHostileMissiles { get; protected set; }
        public EvalPrototype EvalPropertiesToApply { get; protected set; }
        public bool AffectsReflectedMissilesOnly { get; protected set; }
        public bool IsPermanent { get; protected set; }
    }

    public class HotspotPrototype : WorldEntityPrototype
    {
        public PrototypeId[] AppliesPowers { get; protected set; }             // VectorPrototypeRefPtr PowerPrototype
        public PrototypeId[] AppliesIntervalPowers { get; protected set; }     // VectorPrototypeRefPtr PowerPrototype
        public int IntervalPowersTimeDelayMS { get; protected set; }
        public bool IntervalPowersRandomTarget { get; protected set; }
        public int IntervalPowersNumRandomTargets { get; protected set; }
        public UINotificationPrototype UINotificationOnEnter { get; protected set; }
        public int MaxSimultaneousTargets { get; protected set; }
        public bool KillCreatorWhenHotspotIsEmpty { get; protected set; }
        public PrototypeId KismetSeq { get; protected set; }
        public bool Negatable { get; protected set; }
        public bool KillSelfWhenPowerApplied { get; protected set; }
        public HotspotOverlapEventTriggerType OverlapEventsTriggerOn { get; protected set; }
        public int OverlapEventsMaxTargets { get; protected set; }
        public HotspotDirectApplyToMissilesDataPrototype DirectApplyToMissilesData { get; protected set; }
        public int ApplyEffectsDelayMS { get; protected set; }
        public PrototypeId CameraSettings { get; protected set; }
        public int MaxLifetimeTargets { get; protected set; }
    }

    public class OverheadTextPrototype : Prototype
    {
        public EntityFilterFilterListPrototype OverheadTextEntityFilter { get; protected set; }
        public LocaleStringId OverheadText { get; protected set; }
    }

    public class SpawnerSequenceEntryPrototype : PopulationRequiredObjectPrototype
    {
        public bool OnKilledDefeatSpawner { get; protected set; }
        public PrototypeId OnDefeatAIOverride { get; protected set; }
        public bool Unique { get; protected set; }
        public OverheadTextPrototype[] OnSpawnOverheadTexts { get; protected set; }
    }

    public class SpawnerPrototype : WorldEntityPrototype
    {
        public int SpawnLifetimeMax { get; protected set; }
        public int SpawnDistanceMin { get; protected set; }
        public int SpawnDistanceMax { get; protected set; }
        public int SpawnIntervalMS { get; protected set; }
        public int SpawnSimultaneousMax { get; protected set; }
        public PrototypeId SpawnedEntityInventory { get; protected set; }
        public SpawnerSequenceEntryPrototype[] SpawnSequence { get; protected set; }
        public bool SpawnsInheritMissionPrototype { get; protected set; }
        public bool StartEnabled { get; protected set; }
        public bool OnDestroyCleanupSpawnedEntities { get; protected set; }
        public int SpawnIntervalVarianceMS { get; protected set; }
        public PrototypeId HotspotTrigger { get; protected set; }
        public BannerMessagePrototype OnDefeatBannerMessage { get; protected set; }
        public bool OnDefeatDefeatGroup { get; protected set; }
        public SpawnerDefeatCriteria DefeatCriteria { get; protected set; }
        public EvalPrototype EvalSpawnProperties { get; protected set; }
        public FormationFacing SpawnFacing { get; protected set; }
        public SpawnFailBehavior SpawnFailBehavior { get; protected set; }
        public int DefeatTimeoutMS { get; protected set; }
    }

    public class KismetSequenceEntityPrototype : WorldEntityPrototype
    {
        public PrototypeId KismetSequence { get; protected set; }
    }

    public class FactionPrototype : Prototype
    {
        public AssetId IconPath { get; protected set; }
        public PrototypeId TextStyle { get; protected set; }
        public FactionColor HealthColor { get; protected set; }
    }

    public class WaypointPrototype : Prototype
    {
        public PrototypeId Destination { get; protected set; }
        public LocaleStringId Name { get; protected set; }
        public bool SupressBannerMessage { get; protected set; }
        public bool IsCheckpoint { get; protected set; }
        public PrototypeId WaypointGraph { get; protected set; }
        public PrototypeId[] WaypointGraphList { get; protected set; }
        public PrototypeId RequiresItem { get; protected set; }
        public EvalPrototype EvalShouldDisplay { get; protected set; }
        public LocaleStringId Tooltip { get; protected set; }
        public bool IncludeWaypointPrefixInName { get; protected set; }
        public bool StartLocked { get; protected set; }
        public PrototypeId[] DestinationBossEntities { get; protected set; }
        public bool IsAccountWaypoint { get; protected set; }
        public int MigrationUnlockedByLevel { get; protected set; }
        public PrototypeId[] MigrationUnlockedByChapters { get; protected set; }
        public WaypointPOIType MapPOIType { get; protected set; }
        public PrototypeId[] MapConnectTo { get; protected set; }
        public LocaleStringId MapDescription { get; protected set; }
        public float MapPOIXCoord { get; protected set; }
        public float MapPOIYCoord { get; protected set; }
        public AssetId MapImage { get; protected set; }
        public PrototypeId OpenToWaypointGraph { get; protected set; }
        public AssetId MapImageConsole { get; protected set; }
        public AssetId LocationImageConsole { get; protected set; }
        public LocaleStringId ConsoleRegionDescription { get; protected set; }
        public LocaleStringId ConsoleLocationName { get; protected set; }
        public LocaleStringId ConsoleRegionType { get; protected set; }
        public LocaleStringId ConsoleLevelRange { get; protected set; }
        public LocalizedTextAndImagePrototype[] ConsoleRegionItems { get; protected set; }
        public PrototypeId[] ConsoleWaypointGraphList { get; protected set; }
    }

    public class WaypointChapterPrototype : Prototype
    {
        public PrototypeId Chapter { get; protected set; }
        public PrototypeId[] Waypoints { get; protected set; }
    }

    public class WaypointGraphPrototype : Prototype
    {
        public WaypointChapterPrototype[] Chapters { get; protected set; }
        public LocaleStringId DisplayName { get; protected set; }
        public LocaleStringId MapDescription { get; protected set; }
        public AssetId MapImage { get; protected set; }
        public LocaleStringId Tooltip { get; protected set; }
    }

    public class CheckpointPrototype : Prototype
    {
        public PrototypeId Destination { get; protected set; }
    }
}
