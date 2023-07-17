using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// STRUCTURE <b>tagGETCLIPBMETADATA</b> (GETCLIPBMETADATA, *PGETCLIPBMETADATA)<br/>
/// COMBASEAPI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GetClipBMetaData {

	/// <summary>
	/// <b>UINT Version</b>
	/// </summary>
	public readonly uint Version {
		get => _version;
		init => _version = value;
	}
	readonly uint _version;

	/// <summary>
	/// <b>BOOL IsDelayRendered</b>
	/// </summary>
	public readonly bool IsDelayRendered {
		get => _isDelayRendered != 0;
		init => _isDelayRendered = value ? 1U : 0U;
	}
	readonly uint _isDelayRendered;

	/// <summary>
	/// <b>BOOL IsSynthetic</b>
	/// </summary>
	public readonly bool IsSynthetic {
		get => _isSynthetic != 0;
		init => _isSynthetic = value ? 1U : 0U;
	}
	readonly uint _isSynthetic;
}

/*

/// <summary>
/// STRUCTURE <b>tagServerInformation</b> (ServerInformation, *PServerInformation)<br/>
/// COMBASEAPI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagServerInformation {

	/// <summary>
	/// <b>DWORD dwServerPid</b>
	/// </summary>
	public readonly uint DwServerPid {
		get => _dwServerPid;
		init => _dwServerPid = value;
	}
	readonly uint _dwServerPid;

	/// <summary>
	/// <b>DWORD dwServerTid</b>
	/// </summary>
	public readonly uint DwServerTid {
		get => _dwServerTid;
		init => _dwServerTid = value;
	}
	readonly uint _dwServerTid;

	/// <summary>
	/// <b>UINT64 ui64ServerAddress</b>
	/// </summary>
	public readonly ulong Ui64ServerAddress {
		get => _ui64ServerAddress;
		init => _ui64ServerAddress = value;
	}
	readonly ulong _ui64ServerAddress;

}

/// <summary>
/// STRUCTURE <b>_COSERVERINFO</b> (COSERVERINFO)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Coserverinfo {

	/// <summary>
	/// <b>DWORD dwReserved1</b>
	/// </summary>
	public readonly uint DwReserved1 {
		get => _dwReserved1;
		init => _dwReserved1 = value;
	}
	readonly uint _dwReserved1;

	/// <summary>
	/// <b>LPWSTR pwszName</b>
	/// </summary>
	public readonly char* PwszName {
		get => _pwszName;
		init => _pwszName = value;
	}
	readonly char* _pwszName;

	/// <summary>
	/// <b>COAUTHINFO* pAuthInfo</b>
	/// </summary>
	public readonly COAUTHINFO* PAuthInfo {
		get => _pAuthInfo;
		init => _pAuthInfo = value;
	}
	readonly COAUTHINFO* _pAuthInfo;

	/// <summary>
	/// <b>DWORD dwReserved2</b>
	/// </summary>
	public readonly uint DwReserved2 {
		get => _dwReserved2;
		init => _dwReserved2 = value;
	}
	readonly uint _dwReserved2;

}

/// <summary>
/// STRUCTURE <b>tagMULTI_QI</b> (MULTI_QI)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagMULTIQi {

	/// <summary>
	/// <b>IID* pIID</b>
	/// </summary>
	public readonly Guid* PIID {
		get => _pIID;
		init => _pIID = value;
	}
	readonly Guid* _pIID;

	/// <summary>
	/// <b>IUnknown* pItf</b>
	/// </summary>
	public readonly T* PItf<T> () where T : unmanaged, IUnknown => (T*) _pItf;
	readonly void* _pItf;

	/// <summary>
	/// <b>HRESULT hr</b>
	/// </summary>
	public readonly int Hr {
		get => _hr;
		init => _hr = value;
	}
	readonly int _hr;

}

*/

/// <summary>
/// STRUCTURE <b>tagSTATSTG</b> (STATSTG)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct STATSTG {

	/// <summary>
	/// <b>LPOLESTR pwcsName</b>
	/// </summary>
	public readonly char* PwcsName {
		get => _pwcsName;
		init => _pwcsName = value;
	}
	readonly char* _pwcsName;

	/// <summary>
	/// <b>DWORD type</b>
	/// </summary>
	public readonly uint Type {
		get => _type;
		init => _type = value;
	}
	readonly uint _type;

	/// <summary>
	/// <b>ULARGE_INTEGER cbSize</b>
	/// </summary>
	public readonly ulong CbSize {
		get => _cbSize;
		init => _cbSize = value;
	}
	readonly ulong _cbSize;

	/// <summary>
	/// <b>FILETIME mtime</b>
	/// </summary>
	public readonly FileTime Mtime {
		get => _mtime;
		init => _mtime = value;
	}
	readonly FileTime _mtime;

	/// <summary>
	/// <b>FILETIME ctime</b>
	/// </summary>
	public readonly FileTime Ctime {
		get => _ctime;
		init => _ctime = value;
	}
	readonly FileTime _ctime;

	/// <summary>
	/// <b>FILETIME atime</b>
	/// </summary>
	public readonly FileTime Atime {
		get => _atime;
		init => _atime = value;
	}
	readonly FileTime _atime;

	/// <summary>
	/// <b>DWORD grfMode</b>
	/// </summary>
	public readonly uint GrfMode {
		get => _grfMode;
		init => _grfMode = value;
	}
	readonly uint _grfMode;

	/// <summary>
	/// <b>DWORD grfLocksSupported</b>
	/// </summary>
	public readonly uint GrfLocksSupported {
		get => _grfLocksSupported;
		init => _grfLocksSupported = value;
	}
	readonly uint _grfLocksSupported;

	/// <summary>
	/// <b>CLSID clsid</b>
	/// </summary>
	public readonly Guid Clsid {
		get => _clsid;
		init => _clsid = value;
	}
	readonly Guid _clsid;

	/// <summary>
	/// <b>DWORD grfStateBits</b>
	/// </summary>
	public readonly uint GrfStateBits {
		get => _grfStateBits;
		init => _grfStateBits = value;
	}
	readonly uint _grfStateBits;

	/// <summary>
	/// <b>DWORD reserved</b>
	/// </summary>
	public readonly uint Reserved {
		get => _reserved;
		init => _reserved = value;
	}
	readonly uint _reserved;

}

/*

/// <summary>
/// STRUCTURE <b>tagRPCOLEMESSAGE</b> (RPCOLEMESSAGE)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagRPCOLEMESSAGE {

	/// <summary>
	/// <b>void* reserved1</b>
	/// </summary>
	public readonly void* Reserved1 {
		get => _reserved1;
		init => _reserved1 = value;
	}
	readonly void* _reserved1;

	/// <summary>
	/// <b>RPCOLEDATAREP dataRepresentation</b>
	/// </summary>
	public readonly uint DataRepresentation {
		get => _dataRepresentation;
		init => _dataRepresentation = value;
	}
	readonly uint _dataRepresentation;

	/// <summary>
	/// <b>void* Buffer</b>
	/// </summary>
	public readonly void* Buffer {
		get => _buffer;
		init => _buffer = value;
	}
	readonly void* _buffer;

	/// <summary>
	/// <b>ULONG cbBuffer</b>
	/// </summary>
	public readonly uint CbBuffer {
		get => _cbBuffer;
		init => _cbBuffer = value;
	}
	readonly uint _cbBuffer;

	/// <summary>
	/// <b>ULONG iMethod</b>
	/// </summary>
	public readonly uint IMethod {
		get => _iMethod;
		init => _iMethod = value;
	}
	readonly uint _iMethod;

	/// <summary>
	/// <b>void* reserved2 [5]</b>
	/// </summary>
	public readonly Span<IntPtr> Reserved2 {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _reserved2)), 5);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_177 {
		public void* _ASP_AUTO_GENERATED_FIELD_0;
		public void* _ASP_AUTO_GENERATED_FIELD_1;
		public void* _ASP_AUTO_GENERATED_FIELD_2;
		public void* _ASP_AUTO_GENERATED_FIELD_3;
		public void* _ASP_AUTO_GENERATED_FIELD_4;
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_177 _reserved2;

	/// <summary>
	/// <b>ULONG rpcFlags</b>
	/// </summary>
	public readonly uint RpcFlags {
		get => _rpcFlags;
		init => _rpcFlags = value;
	}
	readonly uint _rpcFlags;

}

/// <summary>
/// STRUCTURE <b>SChannelHookCallInfo</b><br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SChannelHookCallInfo {

	/// <summary>
	/// <b>IID iid</b>
	/// </summary>
	public readonly Guid Iid {
		get => _iid;
		init => _iid = value;
	}
	readonly Guid _iid;

	/// <summary>
	/// <b>DWORD cbSize</b>
	/// </summary>
	public readonly uint CbSize {
		get => _cbSize;
		init => _cbSize = value;
	}
	readonly uint _cbSize;

	/// <summary>
	/// <b>GUID uCausality</b>
	/// </summary>
	public readonly Guid UCausality {
		get => _uCausality;
		init => _uCausality = value;
	}
	readonly Guid _uCausality;

	/// <summary>
	/// <b>DWORD dwServerPid</b>
	/// </summary>
	public readonly uint DwServerPid {
		get => _dwServerPid;
		init => _dwServerPid = value;
	}
	readonly uint _dwServerPid;

	/// <summary>
	/// <b>DWORD iMethod</b>
	/// </summary>
	public readonly uint IMethod {
		get => _iMethod;
		init => _iMethod = value;
	}
	readonly uint _iMethod;

	/// <summary>
	/// <b>void* pObject</b>
	/// </summary>
	public readonly void* PObject {
		get => _pObject;
		init => _pObject = value;
	}
	readonly void* _pObject;

}

/// <summary>
/// STRUCTURE <b>tagSOLE_AUTHENTICATION_SERVICE</b> (SOLE_AUTHENTICATION_SERVICE)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagSOLEAuthenticationService {

	/// <summary>
	/// <b>DWORD dwAuthnSvc</b>
	/// </summary>
	public readonly uint DwAuthnSvc {
		get => _dwAuthnSvc;
		init => _dwAuthnSvc = value;
	}
	readonly uint _dwAuthnSvc;

	/// <summary>
	/// <b>DWORD dwAuthzSvc</b>
	/// </summary>
	public readonly uint DwAuthzSvc {
		get => _dwAuthzSvc;
		init => _dwAuthzSvc = value;
	}
	readonly uint _dwAuthzSvc;

	/// <summary>
	/// <b>OLECHAR* pPrincipalName</b>
	/// </summary>
	public readonly char* PPrincipalName {
		get => _pPrincipalName;
		init => _pPrincipalName = value;
	}
	readonly char* _pPrincipalName;

	/// <summary>
	/// <b>HRESULT hr</b>
	/// </summary>
	public readonly int Hr {
		get => _hr;
		init => _hr = value;
	}
	readonly int _hr;

}

/// <summary>
/// STRUCTURE <b>tagSOLE_AUTHENTICATION_INFO</b> (SOLE_AUTHENTICATION_INFO)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagSOLEAuthenticationInfo {

	/// <summary>
	/// <b>DWORD dwAuthnSvc</b>
	/// </summary>
	public readonly uint DwAuthnSvc {
		get => _dwAuthnSvc;
		init => _dwAuthnSvc = value;
	}
	readonly uint _dwAuthnSvc;

	/// <summary>
	/// <b>DWORD dwAuthzSvc</b>
	/// </summary>
	public readonly uint DwAuthzSvc {
		get => _dwAuthzSvc;
		init => _dwAuthzSvc = value;
	}
	readonly uint _dwAuthzSvc;

	/// <summary>
	/// <b>void* pAuthInfo</b>
	/// </summary>
	public readonly void* PAuthInfo {
		get => _pAuthInfo;
		init => _pAuthInfo = value;
	}
	readonly void* _pAuthInfo;

}

/// <summary>
/// STRUCTURE <b>tagSOLE_AUTHENTICATION_LIST</b> (SOLE_AUTHENTICATION_LIST)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagSOLEAuthenticationList {

	/// <summary>
	/// <b>DWORD cAuthInfo</b>
	/// </summary>
	public readonly uint CAuthInfo {
		get => _cAuthInfo;
		init => _cAuthInfo = value;
	}
	readonly uint _cAuthInfo;

	/// <summary>
	/// <b>SOLE_AUTHENTICATION_INFO* aAuthInfo</b>
	/// </summary>
	public readonly TagSOLEAuthenticationInfo* AAuthInfo {
		get => _aAuthInfo;
		init => _aAuthInfo = value;
	}
	readonly TagSOLEAuthenticationInfo* _aAuthInfo;

}

/// <summary>
/// STRUCTURE <b>tagContextProperty</b> (ContextProperty)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagContextProperty {

	/// <summary>
	/// <b>GUID policyId</b>
	/// </summary>
	public readonly Guid PolicyId {
		get => _policyId;
		init => _policyId = value;
	}
	readonly Guid _policyId;

	/// <summary>
	/// <b>CPFLAGS flags</b>
	/// </summary>
	public readonly uint Flags {
		get => _flags;
		init => _flags = value;
	}
	readonly uint _flags;

	/// <summary>
	/// <b>IUnknown* pUnk</b>
	/// </summary>
	public readonly T* PUnk<T> () where T : unmanaged, IUnknown => (T*) _pUnk;
	readonly void* _pUnk;

}

/// <summary>
/// STRUCTURE <b>MachineGlobalObjectTableRegistrationToken__</b> (*MachineGlobalObjectTableRegistrationToken)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MachineGlobalObjectTableRegistrationToken {

	/// <summary>
	/// <b>int unused</b>
	/// </summary>
	public readonly int Unused {
		get => _unused;
		init => _unused = value;
	}
	readonly int _unused;

}

/// <summary>
/// STRUCTURE <b>tagBIND_OPTS</b> (BIND_OPTS, *LPBIND_OPTS)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagBINDOpts {

	/// <summary>
	/// <b>DWORD cbStruct</b>
	/// </summary>
	public readonly uint CbStruct {
		get => _cbStruct;
		init => _cbStruct = value;
	}
	readonly uint _cbStruct;

	/// <summary>
	/// <b>DWORD grfFlags</b>
	/// </summary>
	public readonly uint GrfFlags {
		get => _grfFlags;
		init => _grfFlags = value;
	}
	readonly uint _grfFlags;

	/// <summary>
	/// <b>DWORD grfMode</b>
	/// </summary>
	public readonly uint GrfMode {
		get => _grfMode;
		init => _grfMode = value;
	}
	readonly uint _grfMode;

	/// <summary>
	/// <b>DWORD dwTickCountDeadline</b>
	/// </summary>
	public readonly uint DwTickCountDeadline {
		get => _dwTickCountDeadline;
		init => _dwTickCountDeadline = value;
	}
	readonly uint _dwTickCountDeadline;

}

/// <summary>
/// STRUCTURE <b>tagBIND_OPTS2</b> (BIND_OPTS2, *LPBIND_OPTS2)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagBINDOpts2 {

	/// <summary>
	/// <b>DWORD cbStruct</b>
	/// </summary>
	public readonly uint CbStruct {
		get => _cbStruct;
		init => _cbStruct = value;
	}
	readonly uint _cbStruct;

	/// <summary>
	/// <b>DWORD grfFlags</b>
	/// </summary>
	public readonly uint GrfFlags {
		get => _grfFlags;
		init => _grfFlags = value;
	}
	readonly uint _grfFlags;

	/// <summary>
	/// <b>DWORD grfMode</b>
	/// </summary>
	public readonly uint GrfMode {
		get => _grfMode;
		init => _grfMode = value;
	}
	readonly uint _grfMode;

	/// <summary>
	/// <b>DWORD dwTickCountDeadline</b>
	/// </summary>
	public readonly uint DwTickCountDeadline {
		get => _dwTickCountDeadline;
		init => _dwTickCountDeadline = value;
	}
	readonly uint _dwTickCountDeadline;

	/// <summary>
	/// <b>DWORD dwTrackFlags</b>
	/// </summary>
	public readonly uint DwTrackFlags {
		get => _dwTrackFlags;
		init => _dwTrackFlags = value;
	}
	readonly uint _dwTrackFlags;

	/// <summary>
	/// <b>DWORD dwClassContext</b>
	/// </summary>
	public readonly uint DwClassContext {
		get => _dwClassContext;
		init => _dwClassContext = value;
	}
	readonly uint _dwClassContext;

	/// <summary>
	/// <b>LCID locale</b>
	/// </summary>
	public readonly uint Locale {
		get => _locale;
		init => _locale = value;
	}
	readonly uint _locale;

	/// <summary>
	/// <b>COSERVERINFO* pServerInfo</b>
	/// </summary>
	public readonly Coserverinfo* PServerInfo {
		get => _pServerInfo;
		init => _pServerInfo = value;
	}
	readonly Coserverinfo* _pServerInfo;

}

/// <summary>
/// STRUCTURE <b>tagBIND_OPTS3</b> (BIND_OPTS3, *LPBIND_OPTS3)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagBINDOpts3 {

	/// <summary>
	/// <b>DWORD dwTrackFlags</b>
	/// </summary>
	public readonly uint DwTrackFlags {
		get => _dwTrackFlags;
		init => _dwTrackFlags = value;
	}
	readonly uint _dwTrackFlags;

	/// <summary>
	/// <b>DWORD dwClassContext</b>
	/// </summary>
	public readonly uint DwClassContext {
		get => _dwClassContext;
		init => _dwClassContext = value;
	}
	readonly uint _dwClassContext;

	/// <summary>
	/// <b>LCID locale</b>
	/// </summary>
	public readonly uint Locale {
		get => _locale;
		init => _locale = value;
	}
	readonly uint _locale;

	/// <summary>
	/// <b>COSERVERINFO* pServerInfo</b>
	/// </summary>
	public readonly Coserverinfo* PServerInfo {
		get => _pServerInfo;
		init => _pServerInfo = value;
	}
	readonly Coserverinfo* _pServerInfo;

	/// <summary>
	/// <b>HWND hwnd</b>
	/// </summary>
	public readonly IntPtr Hwnd {
		get => _hwnd;
		init => _hwnd = value;
	}
	readonly IntPtr _hwnd;

}

/// <summary>
/// STRUCTURE <b>tagRemSNB</b> (RemSNB)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagRemSNB {

	/// <summary>
	/// <b>ULONG ulCntStr</b>
	/// </summary>
	public readonly uint UlCntStr {
		get => _ulCntStr;
		init => _ulCntStr = value;
	}
	readonly uint _ulCntStr;

	/// <summary>
	/// <b>ULONG ulCntChar</b>
	/// </summary>
	public readonly uint UlCntChar {
		get => _ulCntChar;
		init => _ulCntChar = value;
	}
	readonly uint _ulCntChar;

	/// <summary>
	/// <b>OLECHAR rgString [1]</b>
	/// </summary>
	public readonly Span<char> RgString {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _rgString)), 1);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_178 {
		public fixed char _ASP_AUTO_GENERATED_FIELD_0 [1];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_178 _rgString;

}

/// <summary>
/// STRUCTURE <b>tagDVTARGETDEVICE</b> (DVTARGETDEVICE)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagDVTARGETDEVICE {

	/// <summary>
	/// <b>DWORD tdSize</b>
	/// </summary>
	public readonly uint TdSize {
		get => _tdSize;
		init => _tdSize = value;
	}
	readonly uint _tdSize;

	/// <summary>
	/// <b>WORD tdDriverNameOffset</b>
	/// </summary>
	public readonly ushort TdDriverNameOffset {
		get => _tdDriverNameOffset;
		init => _tdDriverNameOffset = value;
	}
	readonly ushort _tdDriverNameOffset;

	/// <summary>
	/// <b>WORD tdDeviceNameOffset</b>
	/// </summary>
	public readonly ushort TdDeviceNameOffset {
		get => _tdDeviceNameOffset;
		init => _tdDeviceNameOffset = value;
	}
	readonly ushort _tdDeviceNameOffset;

	/// <summary>
	/// <b>WORD tdPortNameOffset</b>
	/// </summary>
	public readonly ushort TdPortNameOffset {
		get => _tdPortNameOffset;
		init => _tdPortNameOffset = value;
	}
	readonly ushort _tdPortNameOffset;

	/// <summary>
	/// <b>WORD tdExtDevmodeOffset</b>
	/// </summary>
	public readonly ushort TdExtDevmodeOffset {
		get => _tdExtDevmodeOffset;
		init => _tdExtDevmodeOffset = value;
	}
	readonly ushort _tdExtDevmodeOffset;

	/// <summary>
	/// <b>BYTE tdData [1]</b>
	/// </summary>
	public readonly Span<byte> TdData {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _tdData)), 1);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_179 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [1];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_179 _tdData;

}

/// <summary>
/// STRUCTURE <b>tagFORMATETC</b> (FORMATETC)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagFORMATETC {

	/// <summary>
	/// <b>CLIPFORMAT cfFormat</b>
	/// </summary>
	public readonly StandardClipboardFormat CfFormat {
		get => _cfFormat;
		init => _cfFormat = value;
	}
	readonly StandardClipboardFormat _cfFormat;

	/// <summary>
	/// <b>DVTARGETDEVICE* ptd</b>
	/// </summary>
	public readonly TagDVTARGETDEVICE* Ptd {
		get => _ptd;
		init => _ptd = value;
	}
	readonly TagDVTARGETDEVICE* _ptd;

	/// <summary>
	/// <b>DWORD dwAspect</b>
	/// </summary>
	public readonly uint DwAspect {
		get => _dwAspect;
		init => _dwAspect = value;
	}
	readonly uint _dwAspect;

	/// <summary>
	/// <b>LONG lindex</b>
	/// </summary>
	public readonly int Lindex {
		get => _lindex;
		init => _lindex = value;
	}
	readonly int _lindex;

	/// <summary>
	/// <b>DWORD tymed</b>
	/// </summary>
	public readonly uint Tymed {
		get => _tymed;
		init => _tymed = value;
	}
	readonly uint _tymed;

}

/// <summary>
/// STRUCTURE <b>tagSTATDATA</b> (STATDATA)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagSTATDATA {

	/// <summary>
	/// <b>FORMATETC formatetc</b>
	/// </summary>
	public readonly TagFORMATETC Formatetc {
		get => _formatetc;
		init => _formatetc = value;
	}
	readonly TagFORMATETC _formatetc;

	/// <summary>
	/// <b>DWORD advf</b>
	/// </summary>
	public readonly uint Advf {
		get => _advf;
		init => _advf = value;
	}
	readonly uint _advf;

	/// <summary>
	/// <b>IAdviseSink* pAdvSink</b>
	/// </summary>
	public readonly T* PAdvSink<T> () where T : unmanaged, IAdviseSink => (T*) _pAdvSink;
	readonly void* _pAdvSink;

	/// <summary>
	/// <b>DWORD dwConnection</b>
	/// </summary>
	public readonly uint DwConnection {
		get => _dwConnection;
		init => _dwConnection = value;
	}
	readonly uint _dwConnection;

}

/// <summary>
/// STRUCTURE <b>tagRemSTGMEDIUM</b> (RemSTGMEDIUM)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagRemSTGMEDIUM {

	/// <summary>
	/// <b>DWORD tymed</b>
	/// </summary>
	public readonly uint Tymed {
		get => _tymed;
		init => _tymed = value;
	}
	readonly uint _tymed;

	/// <summary>
	/// <b>DWORD dwHandleType</b>
	/// </summary>
	public readonly uint DwHandleType {
		get => _dwHandleType;
		init => _dwHandleType = value;
	}
	readonly uint _dwHandleType;

	/// <summary>
	/// <b>ULONG pData</b>
	/// </summary>
	public readonly uint PData {
		get => _pData;
		init => _pData = value;
	}
	readonly uint _pData;

	/// <summary>
	/// <b>ULONG pUnkForRelease</b>
	/// </summary>
	public readonly uint PUnkForRelease {
		get => _pUnkForRelease;
		init => _pUnkForRelease = value;
	}
	readonly uint _pUnkForRelease;

	/// <summary>
	/// <b>ULONG cbData</b>
	/// </summary>
	public readonly uint CbData {
		get => _cbData;
		init => _cbData = value;
	}
	readonly uint _cbData;

	/// <summary>
	/// <b>byte data [1]</b>
	/// </summary>
	public readonly Span<byte> Data {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _data)), 1);
	}

	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_180 {
		public fixed byte _ASP_AUTO_GENERATED_FIELD_0 [1];
	}

	readonly _ASP_AUTO_GENERATED_STRUCTURE_180 _data;

}

/// <summary>
/// STRUCTURE <b>tagSTGMEDIUM</b> (uSTGMEDIUM)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagSTGMEDIUM {

	[StructLayout (LayoutKind.Explicit)]
	unsafe struct _ASP_AUTO_GENERATED_STRUCTURE_110 {

		[FieldOffset (0)] public IntPtr hBitmap;
		[FieldOffset (0)] public IntPtr hMetaFilePict;
		[FieldOffset (0)] public IntPtr hEnhMetaFile;
		[FieldOffset (0)] public IntPtr hGlobal;
		[FieldOffset (0)] public char* lpszFileName;
		[FieldOffset (0)] public void* pstm;
		[FieldOffset (0)] public void* pstg;
	}

	/// <summary>
	/// <b>DWORD tymed</b>
	/// </summary>
	public readonly uint Tymed {
		get => _tymed;
		init => _tymed = value;
	}
	readonly uint _tymed;

	/// <summary>
	/// <b>HBITMAP hBitmap</b>
	/// </summary>
	public readonly IntPtr UHBitmap {
		get => _u.hBitmap;
		init => _u.hBitmap = value;
	}

	/// <summary>
	/// <b>HMETAFILEPICT hMetaFilePict</b>
	/// </summary>
	public readonly IntPtr UHMetaFilePict {
		get => _u.hMetaFilePict;
		init => _u.hMetaFilePict = value;
	}

	/// <summary>
	/// <b>HENHMETAFILE hEnhMetaFile</b>
	/// </summary>
	public readonly IntPtr UHEnhMetaFile {
		get => _u.hEnhMetaFile;
		init => _u.hEnhMetaFile = value;
	}

	/// <summary>
	/// <b>HGLOBAL hGlobal</b>
	/// </summary>
	public readonly IntPtr UHGlobal {
		get => _u.hGlobal;
		init => _u.hGlobal = value;
	}

	/// <summary>
	/// <b>LPOLESTR lpszFileName</b>
	/// </summary>
	public readonly char* ULpszFileName {
		get => _u.lpszFileName;
		init => _u.lpszFileName = value;
	}

	/// <summary>
	/// <b>IStream* pstm</b>
	/// </summary>
	public readonly T* UPstm<T> () where T : unmanaged, IStream => (T*) _u.pstm;

	/// <summary>
	/// <b>IStorage* pstg</b>
	/// </summary>
	public readonly T* UPstg<T> () where T : unmanaged, IStorage => (T*) _u.pstg;

	readonly _ASP_AUTO_GENERATED_STRUCTURE_110 _u;

	/// <summary>
	/// <b>IUnknown* pUnkForRelease</b>
	/// </summary>
	public readonly T* PUnkForRelease<T> () where T : unmanaged, IUnknown => (T*) _pUnkForRelease;
	readonly void* _pUnkForRelease;

}

/// <summary>
/// UNION <b>__MIDL_IAdviseSink_0002</b><br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Explicit)]
unsafe public readonly struct MidlIAdviseSink0002 {

	/// <summary>
	/// <b>wireHBITMAP hBitmap</b>
	/// </summary>
	public readonly IntPtr HBitmap {
		get => _hBitmap;
		init => _hBitmap = value;
	}
	[FieldOffset (0)] readonly IntPtr _hBitmap;

	/// <summary>
	/// <b>wireHPALETTE hPalette</b>
	/// </summary>
	public readonly IntPtr HPalette {
		get => _hPalette;
		init => _hPalette = value;
	}
	[FieldOffset (0)] readonly IntPtr _hPalette;

	/// <summary>
	/// <b>wireHGLOBAL hGeneric</b>
	/// </summary>
	public readonly IntPtr HGeneric {
		get => _hGeneric;
		init => _hGeneric = value;
	}
	[FieldOffset (0)] readonly IntPtr _hGeneric;

}

/// <summary>
/// STRUCTURE <b>_GDI_OBJECT</b> (GDI_OBJECT)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct GdiObject {

	/// <summary>
	/// <b>DWORD ObjectType</b>
	/// </summary>
	public readonly uint ObjectType {
		get => _objectType;
		init => _objectType = value;
	}
	readonly uint _objectType;

	/// <summary>
	/// <b>__MIDL_IAdviseSink_0002 u</b>
	/// </summary>
	public readonly MidlIAdviseSink0002 U {
		get => _u;
		init => _u = value;
	}
	readonly MidlIAdviseSink0002 _u;

}

/// <summary>
/// STRUCTURE <b>_STGMEDIUM_UNION</b><br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct StgmediumUnion {

	/// <summary>
	/// <b>DWORD tymed</b>
	/// </summary>
	public readonly uint Tymed {
		get => _tymed;
		init => _tymed = value;
	}
	readonly uint _tymed;

	/// <summary>
	/// <b>__MIDL_IAdviseSink_0003 u</b>
	/// </summary>
	public readonly MidlIAdviseSink0003 U {
		get => _u;
		init => _u = value;
	}
	readonly MidlIAdviseSink0003 _u;

}

/// <summary>
/// UNION <b>__MIDL_IAdviseSink_0003</b><br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Explicit)]
unsafe public readonly struct MidlIAdviseSink0003 {

	/// <summary>
	/// <b>wireHMETAFILEPICT hMetaFilePict</b>
	/// </summary>
	public readonly IntPtr HMetaFilePict {
		get => _hMetaFilePict;
		init => _hMetaFilePict = value;
	}
	[FieldOffset (0)] readonly IntPtr _hMetaFilePict;

	/// <summary>
	/// <b>wireHENHMETAFILE hHEnhMetaFile</b>
	/// </summary>
	public readonly IntPtr HHEnhMetaFile {
		get => _hHEnhMetaFile;
		init => _hHEnhMetaFile = value;
	}
	[FieldOffset (0)] readonly IntPtr _hHEnhMetaFile;

	/// <summary>
	/// <b>GDI_OBJECT* hGdiHandle</b>
	/// </summary>
	public readonly GdiObject* HGdiHandle {
		get => _hGdiHandle;
		init => _hGdiHandle = value;
	}
	[FieldOffset (0)] readonly GdiObject* _hGdiHandle;

	/// <summary>
	/// <b>wireHGLOBAL hGlobal</b>
	/// </summary>
	public readonly IntPtr HGlobal {
		get => _hGlobal;
		init => _hGlobal = value;
	}
	[FieldOffset (0)] readonly IntPtr _hGlobal;

	/// <summary>
	/// <b>LPOLESTR lpszFileName</b>
	/// </summary>
	public readonly char* LpszFileName {
		get => _lpszFileName;
		init => _lpszFileName = value;
	}
	[FieldOffset (0)] readonly char* _lpszFileName;

	/// <summary>
	/// <b>BYTE_BLOB* pstm</b>
	/// </summary>
	public readonly Blob* Pstm {
		get => _pstm;
		init => _pstm = value;
	}
	[FieldOffset (0)] readonly Blob* _pstm;

	/// <summary>
	/// <b>BYTE_BLOB* pstg</b>
	/// </summary>
	public readonly Blob* Pstg {
		get => _pstg;
		init => _pstg = value;
	}
	[FieldOffset (0)] readonly Blob* _pstg;

}

/// <summary>
/// STRUCTURE <b>_userSTGMEDIUM</b> (userSTGMEDIUM)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UserSTGMEDIUM {

	/// <summary>
	/// <b>_STGMEDIUM_UNION DUMMYUNIONNAME</b>
	/// </summary>
	public readonly StgmediumUnion Dummyunionname {
		get => _dUMMYUNIONNAME;
		init => _dUMMYUNIONNAME = value;
	}
	readonly StgmediumUnion _dUMMYUNIONNAME;

	/// <summary>
	/// <b>IUnknown* pUnkForRelease</b>
	/// </summary>
	public readonly T* PUnkForRelease<T> () where T : unmanaged, IUnknown => (T*) _pUnkForRelease;
	readonly void* _pUnkForRelease;

}

/// <summary>
/// STRUCTURE <b>_userFLAG_STGMEDIUM</b> (userFLAG_STGMEDIUM)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct UserFLAGStgmedium {

	/// <summary>
	/// <b>LONG ContextFlags</b>
	/// </summary>
	public readonly int ContextFlags {
		get => _contextFlags;
		init => _contextFlags = value;
	}
	readonly int _contextFlags;

	/// <summary>
	/// <b>LONG fPassOwnership</b>
	/// </summary>
	public readonly int FPassOwnership {
		get => _fPassOwnership;
		init => _fPassOwnership = value;
	}
	readonly int _fPassOwnership;

	/// <summary>
	/// <b>userSTGMEDIUM Stgmed</b>
	/// </summary>
	public readonly UserSTGMEDIUM Stgmed {
		get => _stgmed;
		init => _stgmed = value;
	}
	readonly UserSTGMEDIUM _stgmed;

}

/// <summary>
/// STRUCTURE <b>_FLAG_STGMEDIUM</b> (FLAG_STGMEDIUM)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FlagStgmedium {

	/// <summary>
	/// <b>LONG ContextFlags</b>
	/// </summary>
	public readonly int ContextFlags {
		get => _contextFlags;
		init => _contextFlags = value;
	}
	readonly int _contextFlags;

	/// <summary>
	/// <b>LONG fPassOwnership</b>
	/// </summary>
	public readonly int FPassOwnership {
		get => _fPassOwnership;
		init => _fPassOwnership = value;
	}
	readonly int _fPassOwnership;

	/// <summary>
	/// <b>STGMEDIUM Stgmed</b>
	/// </summary>
	public readonly TagSTGMEDIUM Stgmed {
		get => _stgmed;
		init => _stgmed = value;
	}
	readonly TagSTGMEDIUM _stgmed;

}

/// <summary>
/// STRUCTURE <b>tagINTERFACEINFO</b> (INTERFACEINFO)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagINTERFACEINFO {

	/// <summary>
	/// <b>IUnknown* pUnk</b>
	/// </summary>
	public readonly T* PUnk<T> () where T : unmanaged, IUnknown => (T*) _pUnk;
	readonly void* _pUnk;

	/// <summary>
	/// <b>IID iid</b>
	/// </summary>
	public readonly Guid Iid {
		get => _iid;
		init => _iid = value;
	}
	readonly Guid _iid;

	/// <summary>
	/// <b>WORD wMethod</b>
	/// </summary>
	public readonly ushort WMethod {
		get => _wMethod;
		init => _wMethod = value;
	}
	readonly ushort _wMethod;

}

/// <summary>
/// STRUCTURE <b>tagStorageLayout</b> (StorageLayout)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct TagStorageLayout {

	/// <summary>
	/// <b>DWORD LayoutType</b>
	/// </summary>
	public readonly uint LayoutType {
		get => _layoutType;
		init => _layoutType = value;
	}
	readonly uint _layoutType;

	/// <summary>
	/// <b>OLECHAR* pwcsElementName</b>
	/// </summary>
	public readonly char* PwcsElementName {
		get => _pwcsElementName;
		init => _pwcsElementName = value;
	}
	readonly char* _pwcsElementName;

	/// <summary>
	/// <b>LARGE_INTEGER cOffset</b>
	/// </summary>
	public readonly long COffset {
		get => _cOffset;
		init => _cOffset = value;
	}
	readonly long _cOffset;

	/// <summary>
	/// <b>LARGE_INTEGER cBytes</b>
	/// </summary>
	public readonly long CBytes {
		get => _cBytes;
		init => _cBytes = value;
	}
	readonly long _cBytes;

}

/// <summary>
/// STRUCTURE <b>tagBLOB</b> (BLOB LPBLOB)<br/>
/// OBJIDL.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Blob {

	/// <summary>
	/// <b>ULONG cbSize</b>
	/// </summary>
	public readonly uint CbSize {
		get => _cbSize;
		init => _cbSize = value;
	}
	readonly uint _cbSize;

	/// <summary>
	/// <b>BYTE* pBlobData</b>
	/// </summary>
	public readonly byte* PBlobData {
		get => _pBlobData;
		init => _pBlobData = value;
	}
	readonly byte* _pBlobData;

}

*/

/// <summary>
/// STRUCTURE <b>FILETIME</b><br/>
/// MINWINBASE.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FileTime {

	/// <summary>
	/// <b>DWORD dwLowDateTime</b>
	/// </summary>
	public readonly uint DwLowDateTime { get => _dwLowDateTime; init => _dwLowDateTime = value; }
	readonly uint _dwLowDateTime;

	/// <summary>
	/// <b>DWORD dwHighDateTime</b>
	/// </summary>
	public readonly uint DwHighDateTime { get => _dwHighDateTime; init => _dwHighDateTime = value; }
	readonly uint _dwHighDateTime;

}

/// <summary>
/// STRUCTURE <b>LUID</b><br/>
/// NTDEF.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LUID {

	/// <summary>
	/// <b>ULONG LowPart</b>
	/// </summary>
	public readonly uint LowPart { get => _lowPart; init => _lowPart = value; }
	readonly uint _lowPart;

	/// <summary>
	/// <b>LONG  HighPart</b>
	/// </summary>
	public readonly int HighPart { get => _highPart; init => _highPart = value; }
	readonly int _highPart;

}

/// <summary>
/// STRUCTURE <b>tagMSG</b> (MSG, PMSG, NPMSG, LPMSG)<br/>
/// WINUSER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct MSG {

	/// <summary>
	/// <b>HWND hwnd</b>
	/// </summary>
	public readonly IntPtr HWnd { get => _hWnd; init => _hWnd = value; }
	readonly IntPtr _hWnd;

	/// <summary>
	/// <b>UINT message</b>
	/// </summary>
	public readonly uint Message { get => _message; init => _message = value; }
	readonly uint _message;

	/// <summary>
	/// <b>WPARAM wParam</b>
	/// </summary>
	public readonly IntPtr WParam { get => _wParam; init => _wParam = value; }
	readonly IntPtr _wParam;

	/// <summary>
	/// <b>LPARAM lParam</b>
	/// </summary>
	public readonly IntPtr LParam { get => _lParam; init => _lParam = value; }
	readonly IntPtr _lParam;

	/// <summary>
	/// <b>DWORD time</b>
	/// </summary>
	public readonly uint Time { get => _time; init => _time = value; }
	readonly uint _time;

	/// <summary>
	/// <b>POINT pt</b>
	/// </summary>
	public readonly Vector2I P { get => _p; init => _p = value; }
	readonly Vector2I _p;

	/// <summary>
	/// <b>DWORD lPrivate</b>
	/// </summary>
	public readonly uint LPrivate { get => _lPrivate; init => _lPrivate = value; }
	readonly uint _lPrivate;

}

/// <summary>
/// STRUCTURE <b>SECURITY_ATTRIBUTES</b>
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct SecurityAttributes {

	/// <summary>
	/// <b>DWORD nLength</b>
	/// </summary>
	public readonly uint NLength { get => _nLength; init => _nLength = value; }
	readonly uint _nLength;

	/// <summary>
	/// <b>LPVOID lpSecurityDescriptor</b>
	/// </summary>
	public readonly void* LpSecurityDescriptor { get => _lpSecurityDescriptor; init => _lpSecurityDescriptor = value; }
	readonly void* _lpSecurityDescriptor;

	/// <summary>
	/// <b>BOOL bInheritHandle</b>
	/// </summary>
	public readonly bool BInheritHandle { get => _bInheritHandle != 0; init => _bInheritHandle = value ? 1u : 0u; }
	readonly uint _bInheritHandle;

}

/// <summary>
/// STRUCTURE <b>tagLOGFONTW</b> (LOGFONTW, PLOGFONTW, NPLOGFONTW, LPLOGFONTW)<br/>
/// WINGDI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct LogFontW {

	/// <summary>
	/// <b>LONG lfHeight</b>
	/// </summary>
	public readonly int LfHeight { get => _lfHeight; init => _lfHeight = value; }
	readonly int _lfHeight;

	/// <summary>
	/// <b>LONG lfWidth</b>
	/// </summary>
	public readonly int LfWidth { get => _lfWidth; init => _lfWidth = value; }
	readonly int _lfWidth;

	/// <summary>
	/// <b>LONG lfEscapement</b>
	/// </summary>
	public readonly int LfEscapement { get => _lfEscapement; init => _lfEscapement = value; }
	readonly int _lfEscapement;

	/// <summary>
	/// <b>LONG lfOrientation</b>
	/// </summary>
	public readonly int LfOrientation { get => _lfOrientation; init => _lfOrientation = value; }
	readonly int _lfOrientation;

	/// <summary>
	/// <b>LONG lfWeight</b>
	/// </summary>
	public readonly int LfWeight { get => _lfWeight; init => _lfWeight = value; }
	readonly int _lfWeight;

	/// <summary>
	/// <b>BYTE lfItalic</b>
	/// </summary>
	public readonly byte LfItalic { get => _lfItalic; init => _lfItalic = value; }
	readonly byte _lfItalic;

	/// <summary>
	/// <b>BYTE lfUnderline</b>
	/// </summary>
	public readonly byte LfUnderline { get => _lfUnderline; init => _lfUnderline = value; }
	readonly byte _lfUnderline;

	/// <summary>
	/// <b>BYTE lfStrikeOut</b>
	/// </summary>
	public readonly byte LfStrikeOut { get => _lfStrikeOut; init => _lfStrikeOut = value; }
	readonly byte _lfStrikeOut;

	/// <summary>
	/// <b>BYTE lfCharSet</b>
	/// </summary>
	public readonly byte LfCharSet { get => _lfCharSet; init => _lfCharSet = value; }
	readonly byte _lfCharSet;

	/// <summary>
	/// <b>BYTE lfOutPrecision</b>
	/// </summary>
	public readonly byte LfOutPrecision { get => _lfOutPrecision; init => _lfOutPrecision = value; }
	readonly byte _lfOutPrecision;

	/// <summary>
	/// <b>BYTE lfClipPrecision</b>
	/// </summary>
	public readonly byte LfClipPrecision { get => _lfClipPrecision; init => _lfClipPrecision = value; }
	readonly byte _lfClipPrecision;

	/// <summary>
	/// <b>BYTE lfQuality</b>
	/// </summary>
	public readonly byte LfQuality { get => _lfQuality; init => _lfQuality = value; }
	readonly byte _lfQuality;

	/// <summary>
	/// <b>BYTE lfPitchAndFamily</b>
	/// </summary>
	public readonly byte LfPitchAndFamily { get => _lfPitchAndFamily; init => _lfPitchAndFamily = value; }
	readonly byte _lfPitchAndFamily;

	/// <summary>
	/// <b>WCHAR lfFaceName [LF_FACESIZE]</b>
	/// </summary>
	public readonly Span<char> LfFaceName {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _lfFaceName)), LF_FACESIZE);
	}

	const int LF_FACESIZE = 32;

	struct LfFaceNameFixed {
		public fixed char Value [LF_FACESIZE];
	}

	readonly LfFaceNameFixed _lfFaceName;
}

/// <summary>
/// STRUCTURE <b>tagLOGFONTW</b> (FONTSIGNATURE, PFONTSIGNATURE, LPFONTSIGNATURE)<br/>
/// WINGDI.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct FontSignature {

	/// <summary>
	/// <b>DWORD fsUsb [4]</b>
	/// </summary>
	public readonly Span<uint> FsUsb {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _fsUsb)), 4);
	}

	struct FsUsbFixed {
		public fixed uint Value [4];
	}

	readonly FsUsbFixed _fsUsb;

	/// <summary>
	/// <b>DWORD fsCsb [2]</b>
	/// </summary>
	public readonly Span<uint> FsCsb {
		get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in _fsCsb)), 2);
	}

	struct FsCsbFixed {
		public fixed uint Value [2];
	}

	readonly FsCsbFixed _fsCsb;
}

/// <summary>
/// STRUCTURE <b>tagWNDCLASSA</b> (WNDCLASSA, PWNDCLASSA, NPWNDCLASSA, LPWNDCLASSA)<br/>
/// WINUSER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct WndClassA {

	/// <summary>
	/// <b>UINT style</b>
	/// </summary>
	public readonly uint Style { get => _style; init => _style = value; }
	readonly uint _style;

	/// <summary>
	/// <b>WNDPROC lpfnWndProc</b>
	/// </summary>
	public readonly IntPtr LpfnWndProc { get => _lpfnWndProc; init => _lpfnWndProc = value; }
	readonly IntPtr _lpfnWndProc;

	/// <summary>
	/// <b>int cbClsExtra</b>
	/// </summary>
	public readonly int CbClsExtra { get => _cbClsExtra; init => _cbClsExtra = value; }
	readonly int _cbClsExtra;

	/// <summary>
	/// <b>int cbWndExtra</b>
	/// </summary>
	public readonly int CbWndExtra { get => _cbWndExtra; init => _cbWndExtra = value; }
	readonly int _cbWndExtra;

	/// <summary>
	/// <b>HINSTANCE hInstance</b>
	/// </summary>
	public readonly IntPtr HInstance { get => _hInstance; init => _hInstance = value; }
	readonly IntPtr _hInstance;

	/// <summary>
	/// <b>HICON hIcon</b>
	/// </summary>
	public readonly IntPtr HIcon { get => _hIcon; init => _hIcon = value; }
	readonly IntPtr _hIcon;

	/// <summary>
	/// <b>HCURSOR hCursor</b>
	/// </summary>
	public readonly IntPtr HCursor { get => _hCursor; init => _hCursor = value; }
	readonly IntPtr _hCursor;

	/// <summary>
	/// <b>HBRUSH hbrBackground</b>
	/// </summary>
	public readonly IntPtr HbrBackground { get => _hbrBackground; init => _hbrBackground = value; }
	readonly IntPtr _hbrBackground;

	/// <summary>
	/// <b>LPCSTR lpszMenuName</b>
	/// </summary>
	public readonly char* LpszMenuName { get => _lpszMenuName; init => _lpszMenuName = value; }
	readonly char* _lpszMenuName;

	/// <summary>
	/// <b>LPCSTR lpszClassName</b>
	/// </summary>
	public readonly char* LpszClassName { get => _lpszClassName; init => _lpszClassName = value; }
	readonly char* _lpszClassName;
}

/// <summary>
/// STRUCTURE <b>tagWNDCLASSW</b> (WNDCLASSW, PWNDCLASSW, NPWNDCLASSW, LPWNDCLASSW)<br/>
/// WINUSER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct WndClassW {

	/// <summary>
	/// <b>UINT style</b>
	/// </summary>
	public readonly uint Style { get => _style; init => _style = value; }
	readonly uint _style;

	/// <summary>
	/// <b>WNDPROC lpfnWndProc</b>
	/// </summary>
	public readonly IntPtr LpfnWndProc { get => _lpfnWndProc; init => _lpfnWndProc = value; }
	readonly IntPtr _lpfnWndProc;

	/// <summary>
	/// <b>int cbClsExtra</b>
	/// </summary>
	public readonly int CbClsExtra { get => _cbClsExtra; init => _cbClsExtra = value; }
	readonly int _cbClsExtra;

	/// <summary>
	/// <b>int cbWndExtra</b>
	/// </summary>
	public readonly int CbWndExtra { get => _cbWndExtra; init => _cbWndExtra = value; }
	readonly int _cbWndExtra;

	/// <summary>
	/// <b>HINSTANCE hInstance</b>
	/// </summary>
	public readonly IntPtr HInstance { get => _hInstance; init => _hInstance = value; }
	readonly IntPtr _hInstance;

	/// <summary>
	/// <b>HICON hIcon</b>
	/// </summary>
	public readonly IntPtr HIcon { get => _hIcon; init => _hIcon = value; }
	readonly IntPtr _hIcon;

	/// <summary>
	/// <b>HCURSOR hCursor</b>
	/// </summary>
	public readonly IntPtr HCursor { get => _hCursor; init => _hCursor = value; }
	readonly IntPtr _hCursor;

	/// <summary>
	/// <b>HBRUSH hbrBackground</b>
	/// </summary>
	public readonly IntPtr HbrBackground { get => _hbrBackground; init => _hbrBackground = value; }
	readonly IntPtr _hbrBackground;

	/// <summary>
	/// <b>LPCWSTR lpszMenuName</b>
	/// </summary>
	public readonly char* LpszMenuName { get => _lpszMenuName; init => _lpszMenuName = value; }
	readonly char* _lpszMenuName;

	/// <summary>
	/// <b>LPCWSTR lpszClassName</b>
	/// </summary>
	public readonly char* LpszClassName { get => _lpszClassName; init => _lpszClassName = value; }
	readonly char* _lpszClassName;
}

/// <summary>
/// STRUCTURE <b>tagWNDCLASSEXA</b> (WNDCLASSEXA, PWNDCLASSEXA, NPWNDCLASSEXA, LPWNDCLASSEXA)<br/>
/// WINUSER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct WndClassExA {

	/// <summary>
	/// <b>UINT cbSize</b>
	/// </summary>
	public readonly uint CbSize { get => _cbSize; init => _cbSize = value; }
	readonly uint _cbSize;

	/// <summary>
	/// <b>UINT style</b>
	/// </summary>
	public readonly uint Style { get => _style; init => _style = value; }
	readonly uint _style;

	/// <summary>
	/// <b>WNDPROC lpfnWndProc</b>
	/// </summary>
	public readonly IntPtr LpfnWndProc { get => _lpfnWndProc; init => _lpfnWndProc = value; }
	readonly IntPtr _lpfnWndProc;

	/// <summary>
	/// <b>int cbClsExtra</b>
	/// </summary>
	public readonly int CbClsExtra { get => _cbClsExtra; init => _cbClsExtra = value; }
	readonly int _cbClsExtra;

	/// <summary>
	/// <b>int cbWndExtra</b>
	/// </summary>
	public readonly int CbWndExtra { get => _cbWndExtra; init => _cbWndExtra = value; }
	readonly int _cbWndExtra;

	/// <summary>
	/// <b>HINSTANCE hInstance</b>
	/// </summary>
	public readonly IntPtr HInstance { get => _hInstance; init => _hInstance = value; }
	readonly IntPtr _hInstance;

	/// <summary>
	/// <b>HICON hIcon</b>
	/// </summary>
	public readonly IntPtr HIcon { get => _hIcon; init => _hIcon = value; }
	readonly IntPtr _hIcon;

	/// <summary>
	/// <b>HCURSOR hCursor</b>
	/// </summary>
	public readonly IntPtr HCursor { get => _hCursor; init => _hCursor = value; }
	readonly IntPtr _hCursor;

	/// <summary>
	/// <b>HBRUSH hbrBackground</b>
	/// </summary>
	public readonly IntPtr HbrBackground { get => _hbrBackground; init => _hbrBackground = value; }
	readonly IntPtr _hbrBackground;

	/// <summary>
	/// <b>LPCSTR lpszMenuName</b>
	/// </summary>
	public readonly char* LpszMenuName { get => _lpszMenuName; init => _lpszMenuName = value; }
	readonly char* _lpszMenuName;

	/// <summary>
	/// <b>LPCSTR lpszClassName</b>
	/// </summary>
	public readonly char* LpszClassName { get => _lpszClassName; init => _lpszClassName = value; }
	readonly char* _lpszClassName;

	/// <summary>
	/// <b>HICON hIconSm</b>
	/// </summary>
	public readonly IntPtr HIconSm { get => _hIconSm; init => _hIconSm = value; }
	readonly IntPtr _hIconSm;
}

/// <summary>
/// STRUCTURE <b>tagWNDCLASSEXW</b> (WNDCLASSEXW, PWNDCLASSEXW, NPWNDCLASSEXW, LPWNDCLASSEXW)<br/>
/// WINUSER.h
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct WndClassExW {

	/// <summary>
	/// <b>UINT cbSize</b>
	/// </summary>
	public readonly uint CbSize { get => _cbSize; init => _cbSize = value; }
	readonly uint _cbSize;

	/// <summary>
	/// <b>UINT style</b>
	/// </summary>
	public readonly uint Style { get => _style; init => _style = value; }
	readonly uint _style;

	/// <summary>
	/// <b>WNDPROC lpfnWndProc</b>
	/// </summary>
	public readonly IntPtr LpfnWndProc { get => _lpfnWndProc; init => _lpfnWndProc = value; }
	readonly IntPtr _lpfnWndProc;

	/// <summary>
	/// <b>int cbClsExtra</b>
	/// </summary>
	public readonly int CbClsExtra { get => _cbClsExtra; init => _cbClsExtra = value; }
	readonly int _cbClsExtra;

	/// <summary>
	/// <b>int cbWndExtra</b>
	/// </summary>
	public readonly int CbWndExtra { get => _cbWndExtra; init => _cbWndExtra = value; }
	readonly int _cbWndExtra;

	/// <summary>
	/// <b>HINSTANCE hInstance</b>
	/// </summary>
	public readonly IntPtr HInstance { get => _hInstance; init => _hInstance = value; }
	readonly IntPtr _hInstance;

	/// <summary>
	/// <b>HICON hIcon</b>
	/// </summary>
	public readonly IntPtr HIcon { get => _hIcon; init => _hIcon = value; }
	readonly IntPtr _hIcon;

	/// <summary>
	/// <b>HCURSOR hCursor</b>
	/// </summary>
	public readonly IntPtr HCursor { get => _hCursor; init => _hCursor = value; }
	readonly IntPtr _hCursor;

	/// <summary>
	/// <b>HBRUSH hbrBackground</b>
	/// </summary>
	public readonly IntPtr HbrBackground { get => _hbrBackground; init => _hbrBackground = value; }
	readonly IntPtr _hbrBackground;

	/// <summary>
	/// <b>LPCWSTR lpszMenuName</b>
	/// </summary>
	public readonly char* LpszMenuName { get => _lpszMenuName; init => _lpszMenuName = value; }
	readonly char* _lpszMenuName;

	/// <summary>
	/// <b>LPCWSTR lpszClassName</b>
	/// </summary>
	public readonly char* LpszClassName { get => _lpszClassName; init => _lpszClassName = value; }
	readonly char* _lpszClassName;

	/// <summary>
	/// <b>HICON hIconSm</b>
	/// </summary>
	public readonly IntPtr HIconSm { get => _hIconSm; init => _hIconSm = value; }
	readonly IntPtr _hIconSm;
}
