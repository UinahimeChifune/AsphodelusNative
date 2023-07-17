using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphodelusNative;

/// <summary>
/// <b>DesiredAccess</b><br/>
/// WIN32.h
/// </summary>
[Flags]
public enum DesiredAccess : uint {
	/// <summary>
	/// <b>#define GENERIC_READ 0x80000000</b>
	/// </summary>
	GenericRead = 0x80000000u,
	/// <summary>
	/// <b>#define GENERIC_WRITE 0x40000000</b>
	/// </summary>
	GenericWrite = 0x40000000u,
	/// <summary>
	/// <b>#define GENERIC_EXECUTE 0x20000000</b>
	/// </summary>
	GenericExecute = 0x20000000u,
	/// <summary>
	/// <b>#define GENERIC_ALL 0x10000000</b>
	/// </summary>
	GenericAll = 0x10000000u,
}

/// <summary>
/// <b>Predefined Clipboard Formats</b><br/>
/// WINUSER.h
/// </summary>
public enum ClipboardFormat : uint {
	/// <summary>
	/// <b>#define CF_TEXT 1</b>
	/// </summary>
	Text = 1,
	/// <summary>
	/// <b>#define CF_BITMAP 2</b>
	/// </summary>
	Bitmap = 2,
	/// <summary>
	/// <b>#define CF_METAFILEPICT 3</b>
	/// </summary>
	Metafilepict = 3,
	/// <summary>
	/// <b>#define CF_SYLK 4</b>
	/// </summary>
	Sylk = 4,
	/// <summary>
	/// <b>#define CF_DIF 5</b>
	/// </summary>
	Dif = 5,
	/// <summary>
	/// <b>#define CF_TIFF 6</b>
	/// </summary>
	Tiff = 6,
	/// <summary>
	/// <b>#define CF_OEMTEXT 7</b>
	/// </summary>
	Oemtext = 7,
	/// <summary>
	/// <b>#define CF_DIB 8</b>
	/// </summary>
	Dib = 8,
	/// <summary>
	/// <b>#define CF_PALETTE 9</b>
	/// </summary>
	Palette = 9,
	/// <summary>
	/// <b>#define CF_PENDATA 10</b>
	/// </summary>
	Pendata = 10,
	/// <summary>
	/// <b>#define CF_RIFF 11</b>
	/// </summary>
	Riff = 11,
	/// <summary>
	/// <b>#define CF_WAVE 12</b>
	/// </summary>
	Wave = 12,
	/// <summary>
	/// <b>#define CF_UNICODETEXT 13</b>
	/// </summary>
	Unicodetext = 13,
	/// <summary>
	/// <b>#define CF_ENHMETAFILE 14</b>
	/// </summary>
	Enhmetafile = 14,
	/// <summary>
	/// <b>#define CF_HDROP 15</b>
	/// </summary>
	Hdrop = 15,
	/// <summary>
	/// <b>#define CF_LOCALE 16</b>
	/// </summary>
	Locale = 16,
	/// <summary>
	/// <b>#define CF_DIBV5 17</b>
	/// </summary>
	Dibv5 = 17,
	/// <summary>
	/// <b>#define CF_MAX 18</b>
	/// </summary>
	Max = 18,
	/// <summary>
	/// <b>#define CF_OWNERDISPLAY 0x0080</b>
	/// </summary>
	Ownerdisplay = 0x0080,
	/// <summary>
	/// <b>#define CF_DSPTEXT 0x0081</b>
	/// </summary>
	Dsptext = 0x0081,
	/// <summary>
	/// <b>#define CF_DSPBITMAP 0x0082</b>
	/// </summary>
	Dspbitmap = 0x0082,
	/// <summary>
	/// <b>#define CF_DSPMETAFILEPICT 0x0083</b>
	/// </summary>
	Dspmetafilepict = 0x0083,
	/// <summary>
	/// <b>#define CF_DSPENHMETAFILE 0x008E</b>
	/// </summary>
	Dspenhmetafile = 0x008E,
	/// <summary>
	/// <b>#define CF_PRIVATEFIRST 0x0200</b>
	/// </summary>
	Privatefirst = 0x0200,
	/// <summary>
	/// <b>#define CF_PRIVATELAST 0x02FF</b>
	/// </summary>
	Privatelast = 0x02FF,
	/// <summary>
	/// <b>#define CF_GDIOBJFIRST 0x0300</b>
	/// </summary>
	Gdiobjfirst = 0x0300,
	/// <summary>
	/// <b>#define CF_GDIOBJLAST 0x03FF</b>
	/// </summary>
	Gdiobjlast = 0x03FF,
}

/// <summary>
/// <b>tagCLSCTX</b> (CLSCTX)<br/>
/// WTYPESBASE.h
/// </summary>
[Flags]
public enum TagCLSCTX : uint {
	/// <summary>
	/// <b>CLSCTX_INPROC_SERVER</b> = 0x1
	/// </summary>
	InprocServer = 0x1,
	/// <summary>
	/// <b>CLSCTX_INPROC_HANDLER</b> = 0x2
	/// </summary>
	InprocHandler = 0x2,
	/// <summary>
	/// <b>CLSCTX_LOCAL_SERVER</b> = 0x4
	/// </summary>
	LocalServer = 0x4,
	/// <summary>
	/// <b>CLSCTX_INPROC_SERVER16</b> = 0x8
	/// </summary>
	InprocServer16 = 0x8,
	/// <summary>
	/// <b>CLSCTX_REMOTE_SERVER</b> = 0x10
	/// </summary>
	RemoteServer = 0x10,
	/// <summary>
	/// <b>CLSCTX_INPROC_HANDLER16</b> = 0x20
	/// </summary>
	InProcHandler16 = 0x20,
	/// <summary>
	/// <b>CLSCTX_RESERVED1</b> = 0x40
	/// </summary>
	Reserved1 = 0x40,
	/// <summary>
	/// <b>CLSCTX_RESERVED2</b> = 0x80
	/// </summary>
	Reserved2 = 0x80,
	/// <summary>
	/// <b>CLSCTX_RESERVED3</b> = 0x100
	/// </summary>
	Reserved3 = 0x100,
	/// <summary>
	/// <b>CLSCTX_RESERVED4</b> = 0x200
	/// </summary>
	Reserved4 = 0x200,
	/// <summary>
	/// <b>CLSCTX_NO_CODE_DOWNLOAD</b> = 0x400
	/// </summary>
	NoCodeDownload = 0x400,
	/// <summary>
	/// <b>CLSCTX_RESERVED5</b> = 0x800
	/// </summary>
	Reserved5 = 0x800,
	/// <summary>
	/// <b>CLSCTX_NO_CUSTOM_MARSHAL</b> = 0x1000
	/// </summary>
	NoCustomMarshal = 0x1000,
	/// <summary>
	/// <b>CLSCTX_ENABLE_CODE_DOWNLOAD</b> = 0x2000
	/// </summary>
	EnableCodeDownload = 0x2000,
	/// <summary>
	/// <b>CLSCTX_NO_FAILURE_LOG</b> = 0x4000
	/// </summary>
	NoFailureLog = 0x4000,
	/// <summary>
	/// <b>CLSCTX_DISABLE_AAA</b> = 0x8000
	/// </summary>
	DisableAAA = 0x8000,
	/// <summary>
	/// <b>CLSCTX_ENABLE_AAA</b> = 0x10000
	/// </summary>
	EnableAAA = 0x10000,
	/// <summary>
	/// <b>CLSCTX_FROM_DEFAULT_CONTEXT</b> = 0x20000
	/// </summary>
	FromDefaultContext = 0x20000,
	/// <summary>
	/// <b>CLSCTX_ACTIVATE_X86_SERVER</b> = 0x40000
	/// </summary>
	ActivateX86Server = 0x40000,
	/// <summary>
	/// <b>CLSCTX_ACTIVATE_32_BIT_SERVER</b>
	/// </summary>
	Activate32BitServer,
	/// <summary>
	/// <b>CLSCTX_ACTIVATE_64_BIT_SERVER</b> = 0x80000
	/// </summary>
	Activate64BitServer = 0x80000,
	/// <summary>
	/// <b>CLSCTX_ENABLE_CLOAKING</b> = 0x100000
	/// </summary>
	EnableCloaking = 0x100000,
	/// <summary>
	/// <b>CLSCTX_APPCONTAINER</b> = 0x400000
	/// </summary>
	Appcontainer = 0x400000,
	/// <summary>
	/// <b>CLSCTX_ACTIVATE_AAA_AS_IU</b> = 0x800000
	/// </summary>
	ActivateAaaAsIu = 0x800000,
	/// <summary>
	/// <b>CLSCTX_RESERVED6</b> = 0x1000000
	/// </summary>
	Reserved6 = 0x1000000,
	/// <summary>
	/// <b>CLSCTX_ACTIVATE_ARM32_SERVER</b> = 0x2000000
	/// </summary>
	ActivateArm32Server = 0x2000000,
	/// <summary>
	/// <b>CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION</b>
	/// </summary>
	AllowLowerTrustRegistration,
	/// <summary>
	/// <b>CLSCTX_PS_DLL</b> = 0x80000000
	/// </summary>
	PsDll = 0x80000000,
}

/*

/// <summary>
/// ENUM <b>tagREGCLS</b> (REGCLS)<br/>
/// COMBASEAPI.h
/// </summary>
[Flags]
public enum TagREGCLS : uint {
	/// <summary>
	/// <b>REGCLS_SINGLEUSE</b> = 0
	/// </summary>
	RegclsSingleuse = 0,
	/// <summary>
	/// <b>REGCLS_MULTIPLEUSE</b> = 1
	/// </summary>
	RegclsMultipleuse = 1,
	/// <summary>
	/// <b>REGCLS_MULTI_SEPARATE</b> = 2
	/// </summary>
	RegclsMultiSeparate = 2,
	/// <summary>
	/// <b>REGCLS_SUSPENDED</b> = 4
	/// </summary>
	RegclsSuspended = 4,
	/// <summary>
	/// <b>REGCLS_SURROGATE</b> = 8
	/// </summary>
	RegclsSurrogate = 8,
	/// <summary>
	/// <b>REGCLS_AGILE</b> = 0x10
	/// </summary>
	RegclsAgile = 16,
}

/// <summary>
/// ENUM <b>tagCOINITBASE</b> (COINITBASE)<br/>
/// COMBASEAPI.h
/// </summary>
public enum TagCOINITBASE : uint {
	/// <summary>
	/// <b>COINITBASE_MULTITHREADED</b> = 0x0
	/// </summary>
	CoinitbaseMultithreaded = 0,
}

/// <summary>
/// ENUM <b>tagSTDMSHLFLAGS</b> (STDMSHLFLAGS)<br/>
/// COMBASEAPI.h
/// </summary>
[Flags]
public enum TagSTDMSHLFLAGS : uint {
	/// <summary>
	/// <b>SMEXF_SERVER</b> = 0x01
	/// </summary>
	SmexfServer = 1,
	/// <summary>
	/// <b>SMEXF_HANDLER</b> = 0x02
	/// </summary>
	SmexfHandler = 2,
}

/// <summary>
/// ENUM <b>tagCOWAIT_FLAGS</b> (COWAIT_FLAGS)<br/>
/// COMBASEAPI.h
/// </summary>
[Flags]
public enum TagCOWAITFlags : uint {
	/// <summary>
	/// <b>COWAIT_DEFAULT</b> = 0
	/// </summary>
	CowaitDefault = 0,
	/// <summary>
	/// <b>COWAIT_WAITALL</b> = 1
	/// </summary>
	CowaitWaitall = 1,
	/// <summary>
	/// <b>COWAIT_ALERTABLE</b> = 2
	/// </summary>
	CowaitAlertable = 2,
	/// <summary>
	/// <b>COWAIT_INPUTAVAILABLE</b> = 4
	/// </summary>
	CowaitInputavailable = 4,
	/// <summary>
	/// <b>COWAIT_DISPATCH_CALLS</b> = 8
	/// </summary>
	CowaitDispatchCalls = 8,
	/// <summary>
	/// <b>COWAIT_DISPATCH_WINDOW_MESSAGES</b> = 0x10
	/// </summary>
	CowaitDispatchWindowMessages = 16,
}

/// <summary>
/// ENUM <b>CWMO_FLAGS</b><br/>
/// COMBASEAPI.h
/// </summary>
[Flags]
public enum CwmoFlags : uint {
	/// <summary>
	/// <b>CWMO_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>CWMO_DISPATCH_CALLS</b> = 1
	/// </summary>
	DispatchCalls = 1,
	/// <summary>
	/// <b>CWMO_DISPATCH_WINDOW_MESSAGES</b> = 2
	/// </summary>
	DispatchWindowMessages = 2,
}

/// <summary>
/// ENUM <b>AgileReferenceOptions</b><br/>
/// COMBASEAPI.h
/// </summary>
public enum AgileReferenceOptions : uint {
	/// <summary>
	/// <b>AGILEREFERENCE_DEFAULT</b> = 0
	/// </summary>
	Default = 0,
	/// <summary>
	/// <b>AGILEREFERENCE_DELAYEDMARSHAL</b> = 1
	/// </summary>
	Delayedmarshal = 1,
}

/// <summary>
/// ENUM <b>tagCOINIT</b> (COINIT)<br/>
/// OBJBASE.h
/// </summary>
[Flags]
public enum TagCOINIT : uint {
	/// <summary>
	/// <b>COINIT_APARTMENTTHREADED</b> = 0x2
	/// </summary>
	CoinitApartmentthreaded = 2,
	/// <summary>
	/// <b>COINIT_MULTITHREADED</b> = COINITBASE_MULTITHREADED
	/// </summary>
	CoinitMultithreaded = TagCOINITBASE.CoinitbaseMultithreaded,
	/// <summary>
	/// <b>COINIT_DISABLE_OLE1DDE</b> = 0x4
	/// </summary>
	CoinitDisableOle1dde = 4,
	/// <summary>
	/// <b>COINIT_SPEED_OVER_MEMORY</b> = 0x8
	/// </summary>
	CoinitSpeedOverMemory = 8,
}

/// <summary>
/// ENUM <b>tagCOMSD</b> (COMSD)<br/>
/// OBJBASE.h
/// </summary>
public enum TagCOMSD : uint {
	/// <summary>
	/// <b>SD_LAUNCHPERMISSIONS</b> = 0
	/// </summary>
	SdLaunchpermissions = 0,
	/// <summary>
	/// <b>SD_ACCESSPERMISSIONS</b> = 1
	/// </summary>
	SdAccesspermissions = 1,
	/// <summary>
	/// <b>SD_LAUNCHRESTRICTIONS</b> = 2
	/// </summary>
	SdLaunchrestrictions = 2,
	/// <summary>
	/// <b>SD_ACCESSRESTRICTIONS</b> = 3
	/// </summary>
	SdAccessrestrictions = 3,
}

/// <summary>
/// ENUM <b>tagACTIVATIONTYPE</b> (ACTIVATIONTYPE)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagACTIVATIONTYPE : uint {
	/// <summary>
	/// <b>ACTIVATIONTYPE_UNCATEGORIZED</b> = 0
	/// </summary>
	ActivationtypeUncategorized = 0,
	/// <summary>
	/// <b>ACTIVATIONTYPE_FROM_MONIKER</b> = 0x1
	/// </summary>
	ActivationtypeFromMoniker = 1,
	/// <summary>
	/// <b>ACTIVATIONTYPE_FROM_DATA</b> = 0x2
	/// </summary>
	ActivationtypeFromData = 2,
	/// <summary>
	/// <b>ACTIVATIONTYPE_FROM_STORAGE</b> = 0x4
	/// </summary>
	ActivationtypeFromStorage = 4,
	/// <summary>
	/// <b>ACTIVATIONTYPE_FROM_STREAM</b> = 0x8
	/// </summary>
	ActivationtypeFromStream = 8,
	/// <summary>
	/// <b>ACTIVATIONTYPE_FROM_FILE</b> = 0x10
	/// </summary>
	ActivationtypeFromFile = 16,
}

/// <summary>
/// ENUM <b>tagEXTCONN</b> (EXTCONN)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagEXTCONN : uint {
	/// <summary>
	/// <b>EXTCONN_STRONG</b> = 0x1
	/// </summary>
	ExtconnStrong = 1,
	/// <summary>
	/// <b>EXTCONN_WEAK</b> = 0x2
	/// </summary>
	ExtconnWeak = 2,
	/// <summary>
	/// <b>EXTCONN_CALLABLE</b> = 0x4
	/// </summary>
	ExtconnCallable = 4,
}

/// <summary>
/// ENUM <b>tagSTGTY</b> (STGTY)<br/>
/// OBJIDL.h
/// </summary>
public enum TagSTGTY : uint {
	/// <summary>
	/// <b>STGTY_STORAGE</b> = 1
	/// </summary>
	StgtyStorage = 1,
	/// <summary>
	/// <b>STGTY_STREAM</b> = 2
	/// </summary>
	StgtyStream = 2,
	/// <summary>
	/// <b>STGTY_LOCKBYTES</b> = 3
	/// </summary>
	StgtyLockbytes = 3,
	/// <summary>
	/// <b>STGTY_PROPERTY</b> = 4
	/// </summary>
	StgtyProperty = 4,
}

/// <summary>
/// ENUM <b>tagSTREAM_SEEK</b> (STREAM_SEEK)<br/>
/// OBJIDL.h
/// </summary>
public enum TagSTREAMSeek : uint {
	/// <summary>
	/// <b>STREAM_SEEK_SET</b> = 0
	/// </summary>
	StreamSeekSet = 0,
	/// <summary>
	/// <b>STREAM_SEEK_CUR</b> = 1
	/// </summary>
	StreamSeekCur = 1,
	/// <summary>
	/// <b>STREAM_SEEK_END</b> = 2
	/// </summary>
	StreamSeekEnd = 2,
}

/// <summary>
/// ENUM <b>tagLOCKTYPE</b> (LOCKTYPE)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagLOCKTYPE : uint {
	/// <summary>
	/// <b>LOCK_WRITE</b> = 1
	/// </summary>
	LockWrite = 1,
	/// <summary>
	/// <b>LOCK_EXCLUSIVE</b> = 2
	/// </summary>
	LockExclusive = 2,
	/// <summary>
	/// <b>LOCK_ONLYONCE</b> = 4
	/// </summary>
	LockOnlyonce = 4,
}

/// <summary>
/// ENUM <b>tagEOLE_AUTHENTICATION_CAPABILITIES</b> (EOLE_AUTHENTICATION_CAPABILITIES)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagEOLEAuthenticationCapabilities : uint {
	/// <summary>
	/// <b>EOAC_NONE</b> = 0
	/// </summary>
	EoacNone = 0,
	/// <summary>
	/// <b>EOAC_MUTUAL_AUTH</b> = 0x1
	/// </summary>
	EoacMutualAuth = 1,
	/// <summary>
	/// <b>EOAC_STATIC_CLOAKING</b> = 0x20
	/// </summary>
	EoacStaticCloaking = 32,
	/// <summary>
	/// <b>EOAC_DYNAMIC_CLOAKING</b> = 0x40
	/// </summary>
	EoacDynamicCloaking = 64,
	/// <summary>
	/// <b>EOAC_ANY_AUTHORITY</b> = 0x80
	/// </summary>
	EoacAnyAuthority = 128,
	/// <summary>
	/// <b>EOAC_MAKE_FULLSIC</b> = 0x100
	/// </summary>
	EoacMakeFullsic = 256,
	/// <summary>
	/// <b>EOAC_DEFAULT</b> = 0x800
	/// </summary>
	EoacDefault = 2048,
	/// <summary>
	/// <b>EOAC_SECURE_REFS</b> = 0x2
	/// </summary>
	EoacSecureRefs = 2,
	/// <summary>
	/// <b>EOAC_ACCESS_CONTROL</b> = 0x4
	/// </summary>
	EoacAccessControl = 4,
	/// <summary>
	/// <b>EOAC_APPID</b> = 0x8
	/// </summary>
	EoacAppid = 8,
	/// <summary>
	/// <b>EOAC_DYNAMIC</b> = 0x10
	/// </summary>
	EoacDynamic = 16,
	/// <summary>
	/// <b>EOAC_REQUIRE_FULLSIC</b> = 0x200
	/// </summary>
	EoacRequireFullsic = 512,
	/// <summary>
	/// <b>EOAC_AUTO_IMPERSONATE</b> = 0x400
	/// </summary>
	EoacAutoImpersonate = 1024,
	/// <summary>
	/// <b>EOAC_DISABLE_AAA</b> = 0x1000
	/// </summary>
	EoacDisableAaa = 4096,
	/// <summary>
	/// <b>EOAC_NO_CUSTOM_MARSHAL</b> = 0x2000
	/// </summary>
	EoacNoCustomMarshal = 8192,
	/// <summary>
	/// <b>EOAC_RESERVED1</b> = 0x4000
	/// </summary>
	EoacReserved1 = 16384,
}

/// <summary>
/// ENUM <b>tagRPCOPT_PROPERTIES</b> (RPCOPT_PROPERTIES)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagRPCOPTProperties : uint {
	/// <summary>
	/// <b>COMBND_RPCTIMEOUT</b> = 0x1
	/// </summary>
	CombndRpctimeout = 1,
	/// <summary>
	/// <b>COMBND_SERVER_LOCALITY</b> = 0x2
	/// </summary>
	CombndServerLocality = 2,
	/// <summary>
	/// <b>COMBND_RESERVED1</b> = 0x4
	/// </summary>
	CombndReserved1 = 4,
	/// <summary>
	/// <b>COMBND_RESERVED2</b> = 0x5
	/// </summary>
	CombndReserved2 = 5,
	/// <summary>
	/// <b>COMBND_RESERVED3</b> = 0x8
	/// </summary>
	CombndReserved3 = 8,
	/// <summary>
	/// <b>COMBND_RESERVED4</b> = 0x10
	/// </summary>
	CombndReserved4 = 16,
}

/// <summary>
/// ENUM <b>tagRPCOPT_SERVER_LOCALITY_VALUES</b> (RPCOPT_SERVER_LOCALITY_VALUES)<br/>
/// OBJIDL.h
/// </summary>
public enum TagRPCOPTServerLocalityValues : uint {
	/// <summary>
	/// <b>SERVER_LOCALITY_PROCESS_LOCAL</b> = 0
	/// </summary>
	ServerLocalityProcessLocal = 0,
	/// <summary>
	/// <b>SERVER_LOCALITY_MACHINE_LOCAL</b> = 1
	/// </summary>
	ServerLocalityMachineLocal = 1,
	/// <summary>
	/// <b>SERVER_LOCALITY_REMOTE</b> = 2
	/// </summary>
	ServerLocalityRemote = 2,
}

/// <summary>
/// ENUM <b>tagGLOBALOPT_PROPERTIES</b> (GLOBALOPT_PROPERTIES)<br/>
/// OBJIDL.h
/// </summary>
public enum TagGLOBALOPTProperties : uint {
	/// <summary>
	/// <b>COMGLB_EXCEPTION_HANDLING</b> = 1
	/// </summary>
	ComglbExceptionHandling = 1,
	/// <summary>
	/// <b>COMGLB_APPID</b> = 2
	/// </summary>
	ComglbAppid = 2,
	/// <summary>
	/// <b>COMGLB_RPC_THREADPOOL_SETTING</b> = 3
	/// </summary>
	ComglbRpcThreadpoolSetting = 3,
	/// <summary>
	/// <b>COMGLB_RO_SETTINGS</b> = 4
	/// </summary>
	ComglbRoSettings = 4,
	/// <summary>
	/// <b>COMGLB_UNMARSHALING_POLICY</b> = 5
	/// </summary>
	ComglbUnmarshalingPolicy = 5,
	/// <summary>
	/// <b>COMGLB_PROPERTIES_RESERVED1</b> = 6
	/// </summary>
	ComglbPropertiesReserved1 = 6,
	/// <summary>
	/// <b>COMGLB_PROPERTIES_RESERVED2</b> = 7
	/// </summary>
	ComglbPropertiesReserved2 = 7,
	/// <summary>
	/// <b>COMGLB_PROPERTIES_RESERVED3</b> = 8
	/// </summary>
	ComglbPropertiesReserved3 = 8,
}

/// <summary>
/// ENUM <b>tagGLOBALOPT_EH_VALUES</b> (GLOBALOPT_EH_VALUES)<br/>
/// OBJIDL.h
/// </summary>
public enum TagGLOBALOPTEhValues : uint {
	/// <summary>
	/// <b>COMGLB_EXCEPTION_HANDLE</b> = 0
	/// </summary>
	ComglbExceptionHandle = 0,
	/// <summary>
	/// <b>COMGLB_EXCEPTION_DONOT_HANDLE_FATAL</b> = 1
	/// </summary>
	ComglbExceptionDonotHandleFatal = 1,
	/// <summary>
	/// <b>COMGLB_EXCEPTION_DONOT_HANDLE</b> = COMGLB_EXCEPTION_DONOT_HANDLE_FATAL
	/// </summary>
	ComglbExceptionDonotHandle = TagGLOBALOPTEhValues.ComglbExceptionDonotHandleFatal,
	/// <summary>
	/// <b>COMGLB_EXCEPTION_DONOT_HANDLE_ANY</b> = 2
	/// </summary>
	ComglbExceptionDonotHandleAny = 2,
}

/// <summary>
/// ENUM <b>tagGLOBALOPT_RPCTP_VALUES</b> (GLOBALOPT_RPCTP_VALUES)<br/>
/// OBJIDL.h
/// </summary>
public enum TagGLOBALOPTRpctpValues : uint {
	/// <summary>
	/// <b>COMGLB_RPC_THREADPOOL_SETTING_DEFAULT_POOL</b> = 0
	/// </summary>
	ComglbRpcThreadpoolSettingDefaultPool = 0,
	/// <summary>
	/// <b>COMGLB_RPC_THREADPOOL_SETTING_PRIVATE_POOL</b> = 1
	/// </summary>
	ComglbRpcThreadpoolSettingPrivatePool = 1,
}

/// <summary>
/// ENUM <b>tagGLOBALOPT_RO_FLAGS</b> (GLOBALOPT_RO_FLAGS)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagGLOBALOPTRoFlags : uint {
	/// <summary>
	/// <b>COMGLB_STA_MODALLOOP_REMOVE_TOUCH_MESSAGES</b> = 0x1
	/// </summary>
	ComglbStaModalloopRemoveTouchMessages = 1,
	/// <summary>
	/// <b>COMGLB_STA_MODALLOOP_SHARED_QUEUE_REMOVE_INPUT_MESSAGES</b> = 0x2
	/// </summary>
	ComglbStaModalloopSharedQueueRemoveInputMessages = 2,
	/// <summary>
	/// <b>COMGLB_STA_MODALLOOP_SHARED_QUEUE_DONOT_REMOVE_INPUT_MESSAGES</b> = 0x4
	/// </summary>
	ComglbStaModalloopSharedQueueDonotRemoveInputMessages = 4,
	/// <summary>
	/// <b>COMGLB_FAST_RUNDOWN</b> = 0x8
	/// </summary>
	ComglbFastRundown = 8,
	/// <summary>
	/// <b>COMGLB_RESERVED1</b> = 0x10
	/// </summary>
	ComglbReserved1 = 16,
	/// <summary>
	/// <b>COMGLB_RESERVED2</b> = 0x20
	/// </summary>
	ComglbReserved2 = 32,
	/// <summary>
	/// <b>COMGLB_RESERVED3</b> = 0x40
	/// </summary>
	ComglbReserved3 = 64,
	/// <summary>
	/// <b>COMGLB_STA_MODALLOOP_SHARED_QUEUE_REORDER_POINTER_MESSAGES</b> = 0x80
	/// </summary>
	ComglbStaModalloopSharedQueueReorderPointerMessages = 128,
	/// <summary>
	/// <b>COMGLB_RESERVED4</b> = 0x100
	/// </summary>
	ComglbReserved4 = 256,
	/// <summary>
	/// <b>COMGLB_RESERVED5</b> = 0x200
	/// </summary>
	ComglbReserved5 = 512,
	/// <summary>
	/// <b>COMGLB_RESERVED6</b> = 0x400
	/// </summary>
	ComglbReserved6 = 1024,
}

/// <summary>
/// ENUM <b>tagGLOBALOPT_UNMARSHALING_POLICY_VALUES</b> (GLOBALOPT_UNMARSHALING_POLICY_VALUES)<br/>
/// OBJIDL.h
/// </summary>
public enum TagGLOBALOPTUnmarshalingPolicyValues : uint {
	/// <summary>
	/// <b>COMGLB_UNMARSHALING_POLICY_NORMAL</b> = 0
	/// </summary>
	ComglbUnmarshalingPolicyNormal = 0,
	/// <summary>
	/// <b>COMGLB_UNMARSHALING_POLICY_STRONG</b> = 1
	/// </summary>
	ComglbUnmarshalingPolicyStrong = 1,
	/// <summary>
	/// <b>COMGLB_UNMARSHALING_POLICY_HYBRID</b> = 2
	/// </summary>
	ComglbUnmarshalingPolicyHybrid = 2,
}

/// <summary>
/// ENUM <b>tagDCOM_CALL_STATE</b> (DCOM_CALL_STATE)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagDCOMCallState : uint {
	/// <summary>
	/// <b>DCOM_NONE</b> = 0
	/// </summary>
	DcomNone = 0,
	/// <summary>
	/// <b>DCOM_CALL_COMPLETE</b> = 0x1
	/// </summary>
	DcomCallComplete = 1,
	/// <summary>
	/// <b>DCOM_CALL_CANCELED</b> = 0x2
	/// </summary>
	DcomCallCanceled = 2,
}

/// <summary>
/// ENUM <b>_APTTYPEQUALIFIER</b> (APTTYPEQUALIFIER)<br/>
/// OBJIDL.h
/// </summary>
public enum Apttypequalifier : uint {
	/// <summary>
	/// <b>APTTYPEQUALIFIER_NONE</b> = 0
	/// </summary>
	None = 0,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_IMPLICIT_MTA</b> = 1
	/// </summary>
	ImplicitMta = 1,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_NA_ON_MTA</b> = 2
	/// </summary>
	NaOnMta = 2,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_NA_ON_STA</b> = 3
	/// </summary>
	NaOnSta = 3,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA</b> = 4
	/// </summary>
	NaOnImplicitMta = 4,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_NA_ON_MAINSTA</b> = 5
	/// </summary>
	NaOnMainsta = 5,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_APPLICATION_STA</b> = 6
	/// </summary>
	ApplicationSta = 6,
	/// <summary>
	/// <b>APTTYPEQUALIFIER_RESERVED_1</b> = 7
	/// </summary>
	Reserved1 = 7,
}

/// <summary>
/// ENUM <b>_APTTYPE</b> (APTTYPE)<br/>
/// OBJIDL.h
/// </summary>
public enum Apttype : uint {
	/// <summary>
	/// <b>APTTYPE_CURRENT</b> = -1
	/// </summary>
	Current = 0xffffffff,
	/// <summary>
	/// <b>APTTYPE_STA</b> = 0
	/// </summary>
	Sta = 0,
	/// <summary>
	/// <b>APTTYPE_MTA</b> = 1
	/// </summary>
	Mta = 1,
	/// <summary>
	/// <b>APTTYPE_NA</b> = 2
	/// </summary>
	Na = 2,
	/// <summary>
	/// <b>APTTYPE_MAINSTA</b> = 3
	/// </summary>
	Mainsta = 3,
}

/// <summary>
/// ENUM <b>_THDTYPE</b> (THDTYPE)<br/>
/// OBJIDL.h
/// </summary>
public enum Thdtype : uint {
	/// <summary>
	/// <b>THDTYPE_BLOCKMESSAGES</b> = 0
	/// </summary>
	Blockmessages = 0,
	/// <summary>
	/// <b>THDTYPE_PROCESSMESSAGES</b> = 1
	/// </summary>
	Processmessages = 1,
}

/// <summary>
/// ENUM <b>CO_MARSHALING_CONTEXT_ATTRIBUTES</b><br/>
/// OBJIDL.h
/// </summary>
public enum CoMarshalingContextAttributes : uint {
	/// <summary>
	/// <b>CO_MARSHALING_SOURCE_IS_APP_CONTAINER</b> = 0
	/// </summary>
	SourceIsAppContainer = 0,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1</b> = 0x80000000
	/// </summary>
	AttributeReserved1 = 2147483648,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2</b> = 0x80000001
	/// </summary>
	AttributeReserved2 = 2147483649,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3</b> = 0x80000002
	/// </summary>
	AttributeReserved3 = 2147483650,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4</b> = 0x80000003
	/// </summary>
	AttributeReserved4 = 2147483651,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5</b> = 0x80000004
	/// </summary>
	AttributeReserved5 = 2147483652,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6</b> = 0x80000005
	/// </summary>
	AttributeReserved6 = 2147483653,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7</b> = 0x80000006
	/// </summary>
	AttributeReserved7 = 2147483654,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8</b> = 0x80000007
	/// </summary>
	AttributeReserved8 = 2147483655,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9</b> = 0x80000008
	/// </summary>
	AttributeReserved9 = 2147483656,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10</b> = 0x80000009
	/// </summary>
	AttributeReserved10 = 2147483657,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11</b> = 0x8000000a
	/// </summary>
	AttributeReserved11 = 2147483658,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12</b> = 0x8000000b
	/// </summary>
	AttributeReserved12 = 2147483659,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13</b> = 0x8000000c
	/// </summary>
	AttributeReserved13 = 2147483660,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14</b> = 0x8000000d
	/// </summary>
	AttributeReserved14 = 2147483661,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15</b> = 0x8000000e
	/// </summary>
	AttributeReserved15 = 2147483662,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16</b> = 0x8000000f
	/// </summary>
	AttributeReserved16 = 2147483663,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17</b> = 0x80000010
	/// </summary>
	AttributeReserved17 = 2147483664,
	/// <summary>
	/// <b>CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18</b> = 0x80000011
	/// </summary>
	AttributeReserved18 = 2147483665,
}

/// <summary>
/// ENUM <b>tagBIND_FLAGS</b> (BIND_FLAGS)<br/>
/// OBJIDL.h
/// </summary>
public enum TagBINDFlags : uint {
	/// <summary>
	/// <b>BIND_MAYBOTHERUSER</b> = 1
	/// </summary>
	BindMaybotheruser = 1,
	/// <summary>
	/// <b>BIND_JUSTTESTEXISTENCE</b> = 2
	/// </summary>
	BindJusttestexistence = 2,
}

/// <summary>
/// ENUM <b>tagMKSYS</b> (MKSYS)<br/>
/// OBJIDL.h
/// </summary>
public enum TagMKSYS : uint {
	/// <summary>
	/// <b>MKSYS_NONE</b> = 0
	/// </summary>
	MksysNone = 0,
	/// <summary>
	/// <b>MKSYS_GENERICCOMPOSITE</b> = 1
	/// </summary>
	MksysGenericcomposite = 1,
	/// <summary>
	/// <b>MKSYS_FILEMONIKER</b> = 2
	/// </summary>
	MksysFilemoniker = 2,
	/// <summary>
	/// <b>MKSYS_ANTIMONIKER</b> = 3
	/// </summary>
	MksysAntimoniker = 3,
	/// <summary>
	/// <b>MKSYS_ITEMMONIKER</b> = 4
	/// </summary>
	MksysItemmoniker = 4,
	/// <summary>
	/// <b>MKSYS_POINTERMONIKER</b> = 5
	/// </summary>
	MksysPointermoniker = 5,
	/// <summary>
	/// <b>MKSYS_CLASSMONIKER</b> = 7
	/// </summary>
	MksysClassmoniker = 7,
	/// <summary>
	/// <b>MKSYS_OBJREFMONIKER</b> = 8
	/// </summary>
	MksysObjrefmoniker = 8,
	/// <summary>
	/// <b>MKSYS_SESSIONMONIKER</b> = 9
	/// </summary>
	MksysSessionmoniker = 9,
	/// <summary>
	/// <b>MKSYS_LUAMONIKER</b> = 10
	/// </summary>
	MksysLuamoniker = 10,
}

/// <summary>
/// ENUM <b>tagMKREDUCE</b> (MKRREDUCE)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagMKREDUCE : uint {
	/// <summary>
	/// <b>MKRREDUCE_ONE</b> = ( 3 &lt;&lt; 16 )
	/// </summary>
	MkrreduceOne = (3 << 16),
	/// <summary>
	/// <b>MKRREDUCE_TOUSER</b> = ( 2 &lt;&lt; 16 )
	/// </summary>
	MkrreduceTouser = (2 << 16),
	/// <summary>
	/// <b>MKRREDUCE_THROUGHUSER</b> = ( 1 &lt;&lt; 16 )
	/// </summary>
	MkrreduceThroughuser = (1 << 16),
	/// <summary>
	/// <b>MKRREDUCE_ALL</b> = 0
	/// </summary>
	MkrreduceAll = 0,
}

/// <summary>
/// ENUM <b>tagADVF</b> (ADVF)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagADVF : uint {
	/// <summary>
	/// <b>ADVF_NODATA</b> = 1
	/// </summary>
	AdvfNodata = 1,
	/// <summary>
	/// <b>ADVF_PRIMEFIRST</b> = 2
	/// </summary>
	AdvfPrimefirst = 2,
	/// <summary>
	/// <b>ADVF_ONLYONCE</b> = 4
	/// </summary>
	AdvfOnlyonce = 4,
	/// <summary>
	/// <b>ADVF_DATAONSTOP</b> = 64
	/// </summary>
	AdvfDataonstop = 64,
	/// <summary>
	/// <b>ADVFCACHE_NOHANDLER</b> = 8
	/// </summary>
	AdvfcacheNohandler = 8,
	/// <summary>
	/// <b>ADVFCACHE_FORCEBUILTIN</b> = 16
	/// </summary>
	AdvfcacheForcebuiltin = 16,
	/// <summary>
	/// <b>ADVFCACHE_ONSAVE</b> = 32
	/// </summary>
	AdvfcacheOnsave = 32,
}

/// <summary>
/// ENUM <b>tagTYMED</b> (TYMED)<br/>
/// OBJIDL.h
/// </summary>
[Flags]
public enum TagTYMED : uint {
	/// <summary>
	/// <b>TYMED_HGLOBAL</b> = 1
	/// </summary>
	TymedHglobal = 1,
	/// <summary>
	/// <b>TYMED_FILE</b> = 2
	/// </summary>
	TymedFile = 2,
	/// <summary>
	/// <b>TYMED_ISTREAM</b> = 4
	/// </summary>
	TymedIstream = 4,
	/// <summary>
	/// <b>TYMED_ISTORAGE</b> = 8
	/// </summary>
	TymedIstorage = 8,
	/// <summary>
	/// <b>TYMED_GDI</b> = 16
	/// </summary>
	TymedGdi = 16,
	/// <summary>
	/// <b>TYMED_MFPICT</b> = 32
	/// </summary>
	TymedMfpict = 32,
	/// <summary>
	/// <b>TYMED_ENHMF</b> = 64
	/// </summary>
	TymedEnhmf = 64,
	/// <summary>
	/// <b>TYMED_NULL</b> = 0
	/// </summary>
	TymedNull = 0,
}

/// <summary>
/// ENUM <b>tagDATADIR</b> (DATADIR)<br/>
/// OBJIDL.h
/// </summary>
public enum TagDATADIR : uint {
	/// <summary>
	/// <b>DATADIR_GET</b> = 1
	/// </summary>
	DatadirGet = 1,
	/// <summary>
	/// <b>DATADIR_SET</b> = 2
	/// </summary>
	DatadirSet = 2,
}

/// <summary>
/// ENUM <b>tagCALLTYPE</b> (CALLTYPE)<br/>
/// OBJIDL.h
/// </summary>
public enum TagCALLTYPE : uint {
	/// <summary>
	/// <b>CALLTYPE_TOPLEVEL</b> = 1
	/// </summary>
	CalltypeToplevel = 1,
	/// <summary>
	/// <b>CALLTYPE_NESTED</b> = 2
	/// </summary>
	CalltypeNested = 2,
	/// <summary>
	/// <b>CALLTYPE_ASYNC</b> = 3
	/// </summary>
	CalltypeAsync = 3,
	/// <summary>
	/// <b>CALLTYPE_TOPLEVEL_CALLPENDING</b> = 4
	/// </summary>
	CalltypeToplevelCallpending = 4,
	/// <summary>
	/// <b>CALLTYPE_ASYNC_CALLPENDING</b> = 5
	/// </summary>
	CalltypeAsyncCallpending = 5,
}

/// <summary>
/// ENUM <b>tagSERVERCALL</b> (SERVERCALL)<br/>
/// OBJIDL.h
/// </summary>
public enum TagSERVERCALL : uint {
	/// <summary>
	/// <b>SERVERCALL_ISHANDLED</b> = 0
	/// </summary>
	ServercallIshandled = 0,
	/// <summary>
	/// <b>SERVERCALL_REJECTED</b> = 1
	/// </summary>
	ServercallRejected = 1,
	/// <summary>
	/// <b>SERVERCALL_RETRYLATER</b> = 2
	/// </summary>
	ServercallRetrylater = 2,
}

/// <summary>
/// ENUM <b>tagPENDINGTYPE</b> (PENDINGTYPE)<br/>
/// OBJIDL.h
/// </summary>
public enum TagPENDINGTYPE : uint {
	/// <summary>
	/// <b>PENDINGTYPE_TOPLEVEL</b> = 1
	/// </summary>
	PendingtypeToplevel = 1,
	/// <summary>
	/// <b>PENDINGTYPE_NESTED</b> = 2
	/// </summary>
	PendingtypeNested = 2,
}

/// <summary>
/// ENUM <b>tagPENDINGMSG</b> (PENDINGMSG)<br/>
/// OBJIDL.h
/// </summary>
public enum TagPENDINGMSG : uint {
	/// <summary>
	/// <b>PENDINGMSG_CANCELCALL</b> = 0
	/// </summary>
	PendingmsgCancelcall = 0,
	/// <summary>
	/// <b>PENDINGMSG_WAITNOPROCESS</b> = 1
	/// </summary>
	PendingmsgWaitnoprocess = 1,
	/// <summary>
	/// <b>PENDINGMSG_WAITDEFPROCESS</b> = 2
	/// </summary>
	PendingmsgWaitdefprocess = 2,
}

/// <summary>
/// ENUM <b>tagApplicationType</b> (ApplicationType)<br/>
/// OBJIDL.h
/// </summary>
public enum TagApplicationType : uint {
	/// <summary>
	/// <b>ServerApplication</b> = 0
	/// </summary>
	ServerApplication = 0,
	/// <summary>
	/// <b>LibraryApplication</b> = ( ServerApplication + 1 )
	/// </summary>
	LibraryApplication = (TagApplicationType.ServerApplication + 1),
}

/// <summary>
/// ENUM <b>tagShutdownType</b> (ShutdownType)<br/>
/// OBJIDL.h
/// </summary>
public enum TagShutdownType : uint {
	/// <summary>
	/// <b>IdleShutdown</b> = 0
	/// </summary>
	IdleShutdown = 0,
	/// <summary>
	/// <b>ForcedShutdown</b> = ( IdleShutdown + 1 )
	/// </summary>
	ForcedShutdown = (TagShutdownType.IdleShutdown + 1),
}

*/