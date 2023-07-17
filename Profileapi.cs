using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// PROFILEAPI.h
/// </summary>
unsafe public static partial class PROFILEAPI {

	/// <summary>
	/// WINAPI <b>BOOL QueryPerformanceCounter (LARGE_INTEGER* lpPerformanceCount)</b><br/>
	/// PROFILEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="lpPerformanceCount">_Out_ <b>LARGE_INTEGER* lpPerformanceCount</b></param>
	[LibraryImport ("KERNEL32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool QueryPerformanceCounter (long* lpPerformanceCount);

	/// <summary>
	/// WINAPI <b>BOOL QueryPerformanceCounter (LARGE_INTEGER* lpPerformanceCount)</b><br/>
	/// PROFILEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="lpPerformanceCount">_Out_ <b>LARGE_INTEGER* lpPerformanceCount</b></param>
	public static bool QueryPerformanceCounter (out long lpPerformanceCount) {
		fixed (long* _lpPerformanceCount = &lpPerformanceCount) {
			return QueryPerformanceCounter (_lpPerformanceCount);
		}
	}

	/// <summary>
	/// WINAPI <b>BOOL QueryPerformanceFrequency (LARGE_INTEGER* lpFrequency)</b><br/>
	/// PROFILEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="lpFrequency">_Out_ <b>LARGE_INTEGER* lpFrequency</b></param>
	[LibraryImport ("KERNEL32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool QueryPerformanceFrequency (long* lpFrequency);

	/// <summary>
	/// WINAPI <b>BOOL QueryPerformanceFrequency (LARGE_INTEGER* lpFrequency)</b><br/>
	/// PROFILEAPI.h<br/>
	/// KERNEL32.dll
	/// </summary>
	/// <param name="lpFrequency">_Out_ <b>LARGE_INTEGER* lpFrequency</b></param>
	public static bool QueryPerformanceFrequency (out long lpFrequency) {
		fixed (long* _lpFrequency = &lpFrequency) {
			return QueryPerformanceFrequency (_lpFrequency);
		}
	}
}
