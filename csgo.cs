using System;

// 2020-08-28 20:18:27.235795300 UTC

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_iCrosshairId = 0xB3E4;
        public const Int32 m_iFOV = 0x31E4;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iShotsFired = 0xA390;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nTickBase = 0x3430;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecViewOffset = 0x108;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x589DD4;
        public const Int32 dwClientState_MaxPlayer = 0x388;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D88;
        public const Int32 dwEntityList = 0x4D5442C;
        public const Int32 dwForceAttack = 0x3185984;
        public const Int32 dwGetAllClasses = 0xD6623C;
        public const Int32 dwGlobalVars = 0x589AD8;
        public const Int32 dwLocalPlayer = 0xD3FC5C;
        public const Int32 dwRadarBase = 0x518919C;
        public const Int32 dwViewMatrix = 0x4D45D74;
        public const Int32 m_bDormant = 0xED;
    }
} // namespace hazedumper
