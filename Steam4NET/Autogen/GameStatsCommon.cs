// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EGameStatsAccountType : int
	{
		k_EGameStatsAccountType_Steam = 1,
		k_EGameStatsAccountType_Xbox = 2,
		k_EGameStatsAccountType_SteamGameServer = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2001)]
	public struct GameStatsSessionIssued_t
	{
		public const int k_iCallback = 2001;
		public UInt64 m_ulSessionID;
		public EResult m_eResult;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCollectingAny;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCollectingDetails;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(2002)]
	public struct GameStatsSessionClosed_t
	{
		public const int k_iCallback = 2002;
		public UInt64 m_ulSessionID;
		public EResult m_eResult;
	};
	
}