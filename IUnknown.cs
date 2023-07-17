using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// INTERFACE <b>IUnknown</b> : <br/>
/// UNKNWN.h
/// </summary>
unsafe public interface IUnknown : IDisposable {
	/// <summary>
	/// GUID
	/// </summary>
	abstract static Guid GUID { get; }
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IUnknown::QueryInterface (REFIID riid, void** ppvObject)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvObject">_COM_Outptr_ <b>void** ppvObject</b></param>
	int QueryInterface (Guid riid, void** ppvObject);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IUnknown::QueryInterface (REFIID riid, void** ppvObject)</b><br/>
	/// </summary>
	/// <param name="riid"><b>REFIID riid</b></param>
	/// <param name="ppvObject">_COM_Outptr_ <b>void** ppvObject</b></param>
	int QueryInterface (Guid riid, out void* ppvObject);
	/// <summary>
	/// STDMETHODCALLTYPE <b>ULONG IUnknown::AddRef ()</b><br/>
	/// </summary>
	uint AddRef ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>ULONG IUnknown::Release ()</b><br/>
	/// </summary>
	uint Release ();
}

/// <summary>
/// Instance of <b>IUnknown</b><br/>
/// UNKNWN.h
/// </summary>
unsafe public readonly struct Unknown : IUnknown {
	//unsafe public readonly struct IUnknownObj : IUnknown {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Unknown* GetCurrentPointer () => (Unknown*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IUnknownObj* GetCurrentPointer () => (IUnknownObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000000, 0x0000, 0x0000, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, void** ppvObject) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, ppvObject);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int QueryInterface (Guid riid, out void* ppvObject) {
		fixed (void** _ppvObject = &ppvObject) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->QueryInterface (ptr, riid, _ppvObject);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint AddRef () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->AddRef (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly uint Release () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Release (ptr);
		return hr;
	}

	[StructLayout (LayoutKind.Sequential)]
	readonly struct FunctionPointer {
		/// <summary>
		/// OFFSET 0
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid, void**, int> QueryInterface;
		/// <summary>
		/// OFFSET 1
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> AddRef;
		/// <summary>
		/// OFFSET 2
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint> Release;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
