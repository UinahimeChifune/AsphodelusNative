using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// INTERFACE <b>IPersistStream</b> : IPersist<br/>
/// OBJIDL.h
/// </summary>
unsafe public interface IPersistStream : IPersist {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IPersistStream::IsDirty ()</b><br/>
	/// </summary>
	int IsDirty ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IPersistStream::Load (IStream* pStm)</b><br/>
	/// </summary>
	/// <param name="pStm">__RPC__in_opt <b>IStream* pStm</b></param>
	int Load<T0> (T0* pStm) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IPersistStream::Save (IStream* pStm, BOOL fClearDirty)</b><br/>
	/// </summary>
	/// <param name="pStm">__RPC__in_opt <b>IStream* pStm</b></param>
	/// <param name="fClearDirty"><b>BOOL fClearDirty</b></param>
	int Save<T0> (T0* pStm, bool fClearDirty) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IPersistStream::GetSizeMax (ULARGE_INTEGER* pcbSize)</b><br/>
	/// </summary>
	/// <param name="pcbSize">__RPC__out <b>ULARGE_INTEGER* pcbSize</b></param>
	int GetSizeMax (ulong* pcbSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IPersistStream::GetSizeMax (ULARGE_INTEGER* pcbSize)</b><br/>
	/// </summary>
	/// <param name="pcbSize">__RPC__out <b>ULARGE_INTEGER* pcbSize</b></param>
	int GetSizeMax (out ulong pcbSize);
}

/// <summary>
/// Instance of <b>IPersistStream</b><br/>
/// OBJIDL.h
/// </summary>
unsafe public readonly struct PersistStream : IPersistStream {
	//unsafe public readonly struct IPersistStreamObj : IPersistStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly PersistStream* GetCurrentPointer () => (PersistStream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IPersistStreamObj* GetCurrentPointer () => (IPersistStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000109, 0x0000, 0x0000, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClassID (Guid* pClassID) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetClassID (ptr, pClassID);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetClassID (out Guid pClassID) {
		fixed (Guid* _pClassID = &pClassID) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetClassID (ptr, _pClassID);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int IsDirty () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->IsDirty (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Load<T0> (T0* pStm) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Load (ptr, pStm);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Save<T0> (T0* pStm, bool fClearDirty) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Save (ptr, pStm, fClearDirty ? 1U : 0U);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSizeMax (ulong* pcbSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->GetSizeMax (ptr, pcbSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int GetSizeMax (out ulong pcbSize) {
		fixed (ulong* _pcbSize = &pcbSize) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->GetSizeMax (ptr, _pcbSize);
			return hr;
		}
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
		/// <summary>
		/// OFFSET 3
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, Guid*, int> GetClassID;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> IsDirty;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, int> Load;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, int> Save;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong*, int> GetSizeMax;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
