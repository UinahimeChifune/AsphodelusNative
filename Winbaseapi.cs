using System;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// WINBASEAPI.h
/// </summary>
unsafe public static partial class WINBASEAPI {

	/// <summary>
	/// WINAPI <b>LPVOID GlobalLock (HGLOBAL hMem)</b><br/>
	/// WINBASEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="hMem">_In_ <b>HGLOBAL hMem</b></param>
	/// <returns></returns>
	[LibraryImport ("KERNEL32.dll")]
	public static partial void* GlobalLock (IntPtr hMem);

	/// <summary>
	/// WINAPI <b>LPVOID GlobalUnlock (HGLOBAL hMem)</b><br/>
	/// WINBASEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="hMem">_In_ <b>HGLOBAL hMem</b></param>
	/// <returns></returns>
	[LibraryImport ("KERNEL32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool GlobalUnlock (IntPtr hMem);

	public static void GlobalUnlock (void* ptr) {
		throw new NotImplementedException ();
	}
}
