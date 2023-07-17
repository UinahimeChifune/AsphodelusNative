using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// INTERFACE <b>ISequentialStream</b> : IUnknown<br/>
/// OBJIDL.h
/// </summary>
unsafe public interface ISequentialStream : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ISequentialStream::Read (void* pv, ULONG cb, ULONG* pcbRead)</b><br/>
	/// </summary>
	/// <param name="pv">_Out_writes_bytes_to_(cb, *pcbRead) <b>void* pv</b></param>
	/// <param name="cb">_In_ <b>ULONG cb</b></param>
	/// <param name="pcbRead">_Out_opt_ <b>ULONG* pcbRead</b></param>
	int Read (void* pv, uint cb, uint* pcbRead);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ISequentialStream::Read (void* pv, ULONG cb, ULONG* pcbRead)</b><br/>
	/// </summary>
	/// <param name="pv">_Out_writes_bytes_to_(cb, *pcbRead) <b>void* pv</b></param>
	/// <param name="cb">_In_ <b>ULONG cb</b></param>
	/// <param name="pcbRead">_Out_opt_ <b>ULONG* pcbRead</b></param>
	int Read (void* pv, uint cb, out uint pcbRead);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ISequentialStream::Write (void* pv, ULONG cb, ULONG* pcbWritten)</b><br/>
	/// </summary>
	/// <param name="pv">_In_reads_bytes_(cb) <b>void* pv</b></param>
	/// <param name="cb">_In_ <b>ULONG cb</b></param>
	/// <param name="pcbWritten">_Out_opt_ <b>ULONG* pcbWritten</b></param>
	int Write (void* pv, uint cb, uint* pcbWritten);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT ISequentialStream::Write (void* pv, ULONG cb, ULONG* pcbWritten)</b><br/>
	/// </summary>
	/// <param name="pv">_In_reads_bytes_(cb) <b>void* pv</b></param>
	/// <param name="cb">_In_ <b>ULONG cb</b></param>
	/// <param name="pcbWritten">_Out_opt_ <b>ULONG* pcbWritten</b></param>
	int Write (void* pv, uint cb, out uint pcbWritten);
}

/// <summary>
/// Instance of <b>ISequentialStream</b><br/>
/// OBJIDL.h
/// </summary>
unsafe public readonly struct SequentialStream : ISequentialStream {
	//unsafe public readonly struct ISequentialStreamObj : ISequentialStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly SequentialStream* GetCurrentPointer () => (SequentialStream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly ISequentialStreamObj* GetCurrentPointer () => (ISequentialStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0c733a30, 0x2a1c, 0x11ce, 0xad, 0xe5, 0x00, 0xaa, 0x00, 0x44, 0x77, 0x3d);

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
	public readonly int Read (void* pv, uint cb, uint* pcbRead) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Read (ptr, pv, cb, pcbRead);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Read (void* pv, uint cb, out uint pcbRead) {
		fixed (uint* _pcbRead = &pcbRead) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Read (ptr, pv, cb, _pcbRead);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Write (void* pv, uint cb, uint* pcbWritten) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Write (ptr, pv, cb, pcbWritten);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Write (void* pv, uint cb, out uint pcbWritten) {
		fixed (uint* _pcbWritten = &pcbWritten) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Write (ptr, pv, cb, _pcbWritten);
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
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, int> Read;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, uint, uint*, int> Write;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
