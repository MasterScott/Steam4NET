// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamClient006")]
	public interface ISteamClient006
	{
		[VTableSlot(0)]
		Int32 CreateSteamPipe();
		[VTableSlot(1)]
		bool BReleaseSteamPipe(Int32 hSteamPipe);
		[VTableSlot(2)]
		Int32 CreateGlobalUser(ref Int32 phSteamPipe);
		[VTableSlot(3)]
		Int32 ConnectToGlobalUser(Int32 hSteamPipe);
		[VTableSlot(4)]
		Int32 CreateLocalUser(ref Int32 phSteamPipe);
		[VTableSlot(5)]
		void ReleaseUser(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(6)]
		TClass GetISteamUser<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(7)]
		TClass GetIVAC<TClass>(Int32 hSteamUser) where TClass : class;
		[VTableSlot(8)]
		TClass GetISteamGameServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(9)]
		void SetLocalIPBinding(UInt32 unIP, UInt16 usPort);
		[VTableSlot(10)]
		string GetUniverseName(EUniverse eUniverse);
		[VTableSlot(11)]
		TClass GetISteamFriends<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(12)]
		TClass GetISteamUtils<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(13)]
		TClass GetISteamBilling<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(14)]
		TClass GetISteamMatchmaking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(15)]
		TClass GetISteamContentServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(16)]
		TClass GetISteamApps<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(17)]
		TClass GetISteamMasterServerUpdater<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(18)]
		TClass GetISteamMatchmakingServers<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(19)]
		void RunFrame();
		[VTableSlot(20)]
		UInt32 GetIPCCallCount();
	};
}
