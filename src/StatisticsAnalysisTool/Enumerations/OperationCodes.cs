﻿namespace StatisticsAnalysisTool.Enumerations
{
    public enum OperationCodes
    {
        Unused = 0,
        Ping,
        Join,
        CreateAccount,
        Login,
        SendCrashLog,
        SendTraceRoute,
        SendVfxStats,
        SendGamePingInfo,
        CreateCharacter,
        DeleteCharacter,
        SelectCharacter,
        RedeemKeycode,
        GetGameServerByCluster,
        GetActiveSubscription,
        GetShopPurchaseUrl,
        GetBuyTrialDetails,
        GetReferralSeasonDetails,
        GetReferralLink,
        GetAvailableTrialKeys,
        GetShopTilesForCategory,
        Move = 22,
        AttackStart,
        CastStart,
        CastCancel,
        TerminateToggleSpell,
        ChannelingCancel,
        AttackBuildingStart,
        InventoryDestroyItem,
        InventoryMoveItem = 30, // map[0:4 1:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 2:14 4:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 5:14 253:29]
        InventoryRecoverItem,
        InventoryRecoverAllItems,
        InventorySplitStack,
        InventorySplitStackInto,
        GetClusterData,
        ChangeCluster = 36,
        ConsoleCommand,
        ChatMessage,
        ReportClientError,
        RegisterToObject,
        UnRegisterFromObject,
        CraftBuildingChangeSettings,
        CraftBuildingTakeMoney,
        RepairBuildingChangeSettings,
        RepairBuildingTakeMoney,
        ActionBuildingChangeSettings,
        HarvestStart,
        HarvestCancel,
        TakeSilver,
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        ItemRerollQualityStart,
        ItemRerollQualityCancel,
        InstallResourceStart,
        InstallResourceCancel,
        InstallSilver,
        BuildingFillNutrition,
        BuildingChangeRenovationState,
        BuildingBuySkin,
        BuildingClaim,
        BuildingGiveup,
        BuildingNutritionSilverStorageDeposit,
        BuildingNutritionSilverStorageWithdraw,
        BuildingNutritionSilverRewardSet,
        ConstructionSiteCreate,
        PlaceableObjectPlace,
        PlaceableObjectPlaceCancel,
        PlaceableObjectPickup,
        FurnitureObjectUse,
        FarmableHarvest,
        FarmableFinishGrownItem,
        FarmableDestroy,
        FarmableGetProduct,
        FarmableFill,
        TearDownConstructionSite,
        CastleGateUse,
        AuctionCreateOffer,
        AuctionCreateRequest,
        AuctionGetOffers,
        AuctionGetRequests,
        AuctionBuyOffer,
        AuctionAbortAuction,
        AuctionModifyAuction,
        AuctionAbortOffer,
        AuctionAbortRequest,
        AuctionSellRequest,
        AuctionGetFinishedAuctions,
        AuctionGetFinishedAuctionsCount,
        AuctionFetchAuction,
        AuctionGetMyOpenOffers,
        AuctionGetMyOpenRequests,
        AuctionGetMyOpenAuctions,
        AuctionGetItemAverageStats,
        AuctionGetItemAverageValue,
        ContainerOpen,
        ContainerClose,
        ContainerManageSubContainer,
        Respawn,
        Suicide,
        JoinGuild,
        LeaveGuild,
        CreateGuild,
        InviteToGuild,
        DeclineGuildInvitation,
        KickFromGuild,
        DuellingChallengePlayer,
        DuellingAcceptChallenge,
        DuellingDenyChallenge,
        ChangeClusterTax,
        ClaimTerritory,
        GiveUpTerritory,
        ChangeTerritoryAccessRights,
        GetMonolithInfo,
        GetClaimInfo,
        GetAttackInfo,
        GetTerritorySeasonPoints,
        GetAttackSchedule,
        ScheduleAttack,
        GetMatches,
        GetMatchDetails,
        JoinMatch,
        LeaveMatch,
        ChangeChatSettings,
        LogoutStart,
        LogoutCancel,
        ClaimOrbStart,
        ClaimOrbCancel,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningCancel,
        DepositToGuildAccount,
        WithdrawalFromAccount,
        ChangeGuildPayUpkeepFlag,
        ChangeGuildTax,
        GetMyTerritories,
        MorganaCommand,
        GetServerInfo,
        InviteMercenaryToMatch,
        SubscribeToCluster,
        AnswerMercenaryInvitation,
        GetCharacterEquipment,
        GetCharacterSteamAchievements,
        GetCharacterStats,
        GetKillHistoryDetails,
        LearnMasteryLevel,
        ReSpecAchievement,
        ChangeAvatar,
        GetRankings,
        GetRank,
        GetGvgSeasonRankings,
        GetGvgSeasonRank,
        GetGvgSeasonHistoryRankings,
        GetGvgSeasonGuildMemberHistory,
        KickFromGvGMatch,
        GetChestLogs,
        GetAccessRightLogs,
        GetGuildAccountLogs,
        GetGuildAccountLogsLargeAmount,
        InviteToPlayerTrade,
        PlayerTradeCancel,
        PlayerTradeInvitationAccept,
        PlayerTradeAddItem,
        PlayerTradeRemoveItem,
        PlayerTradeAcceptTrade,
        PlayerTradeSetSilverOrGold,
        SendMiniMapPing,
        Stuck,
        BuyRealEstate,
        ClaimRealEstate,
        GiveUpRealEstate,
        ChangeRealEstateOutline,
        GetMailInfos,
        GetMailCount,
        ReadMail,
        SendNewMail,
        DeleteMail,
        MarkMailUnread,
        ClaimAttachmentFromMail,
        UpdateLfgInfo,
        GetLfgInfos,
        GetMyGuildLfgInfo,
        GetLfgDescriptionText,
        LfgApplyToGuild,
        AnswerLfgGuildApplication,
        RegisterChatPeer,
        SendChatMessage,
        JoinChatChannel,
        LeaveChatChannel,
        SendWhisperMessage,
        Say,
        PlayEmote,
        StopEmote,
        GetClusterMapInfo,
        AccessRightsChangeSettings,
        Mount,
        MountCancel,
        BuyJourney,
        SetSaleStatusForEstate,
        ResolveGuildOrPlayerName,
        GetRespawnInfos,
        MakeHome,
        LeaveHome,
        ResurrectionReply,
        AllianceCreate,
        AllianceDisband,
        AllianceGetMemberInfos,
        AllianceInvite,
        AllianceAnswerInvitation,
        AllianceCancelInvitation,
        AllianceKickGuild,
        AllianceLeave,
        AllianceChangeGoldPaymentFlag,
        AllianceGetDetailInfo,
        GetIslandInfos,
        AbandonMyIsland,
        BuyMyIsland,
        BuyGuildIsland,
        AbandonGuildIsland,
        UpgradeMyIsland,
        UpgradeGuildIsland,
        MoveMyIsland,
        MoveGuildIsland,
        TerritoryFillNutrition,
        TeleportBack,
        PartyInvitePlayer,
        PartyAnswerInvitation,
        PartyLeave,
        PartyKickPlayer,
        PartyMakeLeader = 222,
        PartyChangeLootSetting,
        PartyMarkObject,
        PartySetRole,
        GetGuildMOTD,
        SetGuildMOTD,
        ExitEnterStart,
        ExitEnterCancel,
        QuestGiverRequest,
        GoldMarketGetBuyOffer,
        GoldMarketGetBuyOfferFromSilver,
        GoldMarketGetSellOffer,
        GoldMarketGetSellOfferFromSilver,
        GoldMarketBuyGold,
        GoldMarketSellGold,
        GoldMarketCreateSellOrder,
        GoldMarketCreateBuyOrder,
        GoldMarketGetInfos,
        GoldMarketCancelOrder,
        Unknown246,
        GoldMarketGetAverageInfo,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        TreasureChestUsingStart,
        TreasureChestUsingCancel,
        UseLootChest, // <- LootLogger: https://github.com/EmeraldKnight79/AO-DU-LootLogger/blob/b1ab099e0d82bdee0a87c153f4bbae324295656e/LootLogger/PacketHandler.cs#L68
        UseShrine,
        LaborerStartJob,
        LaborerTakeJobLoot,
        LaborerDismiss,
        LaborerMove,
        LaborerBuyItem,
        LaborerUpgrade,
        BuyPremium,
        BuyTrial,
        RealEstateGetAuctionData,
        RealEstateBidOnAuction,
        GetSiegeCampCooldown,
        FriendInvite,
        FriendAnswerInvitation,
        FriendCancelnvitation,
        FriendRemove,
        InventoryStack,
        InventorySort,
        EquipmentItemChangeSpell,
        ExpeditionRegister,
        ExpeditionRegisterCancel,
        JoinExpedition,
        DeclineExpeditionInvitation,
        VoteStart,
        VoteDoVote,
        RatingDoRate,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        ActivateExpeditionCheckPoint,
        ArenaRegister,
        ArenaRegisterCancel,
        ArenaLeave,
        JoinArenaMatch,
        DeclineArenaInvitation,
        EnteringArenaStart,
        EnteringArenaCancel,
        ArenaCustomMatch,
        ArenaCustomMatchCreate,
        UpdateCharacterStatement,
        BoostFarmable,
        GetStrikeHistory,
        UseFunction,
        UsePortalEntrance,
        ResetPortalBinding,
        QueryPortalBinding,
        ClaimPaymentTransaction,
        ChangeUseFlag,
        ClientPerformanceStats,
        ExtendedHardwareStats = 300, //  map[0:NVIDIA GeForce RTX 3090 1:AMD Ryzen 7 2700X Eight-Core Processor  2:Windows 10  (10.0.0) 64bit 3:3693 4:24348 5:16293 6:DE-DE 7:Custom 8:1746 10:-1 253:303]
        ClientLowMemoryWarning,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        RequestAppStoreProducts,
        VerifyProductPurchase,
        QueryGuildPlayerStats,
        QueryAllianceGuildStats,
        TrackAchievements,
        SetAchievementsAutoLearn,
        DepositItemToGuildCurrency,
        WithdrawalItemFromGuildCurrency,
        AuctionSellSpecificItemRequest,
        FishingStart,
        FishingCasting,
        FishingCast,
        FishingCatch,
        FishingPull,
        FishingGiveLine,
        FishingFinish,
        FishingCancel,
        CreateGuildAccessTag,
        DeleteGuildAccessTag,
        RenameGuildAccessTag,
        FlagGuildAccessTagGuildPermission,
        AssignGuildAccessTag,
        RemoveGuildAccessTagFromPlayer,
        ModifyGuildAccessTagEditors,
        RequestPublicAccessTags,
        ChangeAccessTagPublicFlag,
        UpdateGuildAccessTag,
        SteamStartMicrotransaction,
        SteamFinishMicrotransaction,
        SteamIdHasActiveAccount,
        CheckEmailAccountState,
        LinkAccountToSteamId,
        BuyGvgSeasonBooster,
        ChangeFlaggingPrepare,
        OverCharge,
        OverChargeEnd,
        RequestTrusted,
        ChangeGuildLogo,
        PartyFinderRegisterForUpdates,
        PartyFinderUnregisterForUpdates,
        PartyFinderEnlistNewPartySearch,
        PartyFinderDeletePartySearch,
        PartyFinderChangePartySearch,
        PartyFinderChangeRole,
        PartyFinderApplyForGroup,
        PartyFinderAcceptOrDeclineApplyForGroup,
        PartyFinderGetEquipmentSnapshot,
        PartyFinderRegisterApplicants,
        PartyFinderUnregisterApplicants,
        PartyFinderFulltextSearch,
        PartyFinderRequestEquipmentSnapshot,
        GetPersonalSeasonTrackerData,
        UseConsumableFromInventory,
        ClaimPersonalSeasonReward,
        EasyAntiCheatMessageToServer,
        SetNextTutorialState,
        AddPlayerToMuteList,
        RemovePlayerFromMuteList,
        ProductShopUserEvent,
        GetVanityUnlocks,
        BuyVanityUnlocks,
        GetMountSkins,
        SetMountSkin,
        SetWardrobe,
        ChangeCustomization,
        SetFavoriteIsland,
        GetGuildChallengePoints,
        TravelToHideout,
        SmartQueueJoin,
        SmartQueueLeave,
        SmartQueueSelectSpawnCluster,
        UpgradeHideout,
        InitHideoutAttackStart,
        InitHideoutAttackCancel,
        HideoutFillNutrition,
        HideoutGetInfo,
        HideoutGetOwnerInfo,
        HideoutSetTribute,
        OpenWorldAttackScheduleStart,
        OpenWorldAttackScheduleCancel,
        OpenWorldAttackConquerStart,
        OpenWorldAttackConquerCancel,
        GetOpenWorldAttackDetails,
        GetNextOpenWorldAttackScheduleTime,
        RecoverVaultFromHideout,
        GetGuildEnergyDrainInfo,
        ChannelingUpdate,
        Unknown394,
        Unknown395,
        Unknown396,
        Unknown397,
        Unknown398,
        Unknown399,
        Unknown400,
        OpenItemWindow,
    }
}