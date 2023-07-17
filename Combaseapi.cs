using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// COMBASEAPI.h
/// </summary>
unsafe public static partial class COMBASEAPI {

	[LibraryImport ("OLE32.dll")]
	private static partial int CoCreateInstance (Guid rclsid, void* pUnkOuter, TagCLSCTX dwClsContext, Guid riid, void** ppv);

	/// <summary>
	/// <b>CoCreateInstance (REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID FAR * ppv)</b><br/>
	/// COMBASEAPI.h<br/>
	/// OLE32.dll
	/// </summary>
	/// <param name="rclsid">_In_ <b>REFCLSID rclsid</b></param>
	/// <param name="pUnkOuter">_In_opt_ <b>LPUNKNOWN pUnkOuter</b></param>
	/// <param name="dwClsContext">_In_ <b>DWORD dwClsContext</b></param>
	/// <param name="riid">_In_ <b>REFIID riid</b></param>
	/// <param name="ppv">_COM_Outptr_ _At_(*ppv, _Post_readable_size_(_Inexpressible_(varies))) <b>LPVOID FAR * ppv</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CoCreateInstance<T0> (Guid rclsid, void* pUnkOuter, TagCLSCTX dwClsContext, Guid riid, T0** ppv) where T0 : unmanaged, IUnknown {
		var hr = CoCreateInstance (rclsid, pUnkOuter, dwClsContext, riid, (void**) ppv);
		return hr;
	}

	/// <summary>
	/// <b>CoCreateInstance (REFCLSID rclsid, LPUNKNOWN pUnkOuter, DWORD dwClsContext, REFIID riid, LPVOID FAR * ppv)</b><br/>
	/// COMBASEAPI.h<br/>
	/// OLE32.dll
	/// </summary>
	/// <param name="rclsid">_In_ <b>REFCLSID rclsid</b></param>
	/// <param name="pUnkOuter">_In_opt_ <b>LPUNKNOWN pUnkOuter</b></param>
	/// <param name="dwClsContext">_In_ <b>DWORD dwClsContext</b></param>
	/// <!--param name="riid">_In_ <b>REFIID riid</b></param-->
	/// <param name="ppv">_COM_Outptr_ _At_(*ppv, _Post_readable_size_(_Inexpressible_(varies))) <b>LPVOID FAR * ppv</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int CoCreateInstance<T0> (Guid rclsid, void* pUnkOuter, TagCLSCTX dwClsContext, out T0* ppv) where T0 : unmanaged, IUnknown {
		fixed (T0** _ppv = &ppv) {
			var hr = CoCreateInstance (rclsid, pUnkOuter, dwClsContext, T0.GUID, (void**) _ppv);
			return hr;
		}
	}
}
