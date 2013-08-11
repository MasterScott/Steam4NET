// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamUser015")]
	public interface ISteamUser015
	{
		[VTableSlot(0)]
		Int32 GetHSteamUser();
		[VTableSlot(1)]
		bool BLoggedOn();
		[VTableSlot(2)]
		CSteamID GetSteamID();
		[VTableSlot(3)]
		Int32 InitiateGameConnection(Byte[] pAuthBlob, Int32 cbMaxAuthBlob, CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer, bool bSecure);
		[VTableSlot(4)]
		void TerminateGameConnection(UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(5)]
		void TrackAppUsageEvent(CGameID gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo);
		[VTableSlot(6)]
		bool GetUserDataFolder(StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(7)]
		void StartVoiceRecording();
		[VTableSlot(8)]
		void StopVoiceRecording();
		[VTableSlot(9)]
		EVoiceResult GetAvailableVoice(ref UInt32 pcbCompressed, ref UInt32 pcbUncompressed);
		[VTableSlot(10)]
		EVoiceResult GetVoice(bool bWantCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, bool bWantUncompressed, Byte[] pUncompressedDestBuffer, UInt32 cbUncompressedDestBufferSize, ref UInt32 nUncompressBytesWritten);
		[VTableSlot(11)]
		EVoiceResult DecompressVoice(Byte[] pCompressed, UInt32 cbCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, UInt32 nSamplesPerSec);
		[VTableSlot(12)]
		UInt32 GetVoiceOptimalSampleRate();
		[VTableSlot(13)]
		UInt32 GetAuthSessionTicket(Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
		[VTableSlot(14)]
		EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, Int32 cbAuthTicket, CSteamID steamID);
		[VTableSlot(15)]
		void EndAuthSession(CSteamID steamID);
		[VTableSlot(16)]
		void CancelAuthTicket(UInt32 hAuthTicket);
		[VTableSlot(17)]
		EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, UInt32 appID);
		[VTableSlot(18)]
		bool BIsBehindNAT();
		[VTableSlot(19)]
		void AdvertiseGame(CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(20)]
		UInt64 RequestEncryptedAppTicket(Byte[] pDataToInclude, Int32 cbDataToInclude);
		[VTableSlot(21)]
		bool GetEncryptedAppTicket(Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
	};
}