using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// INTERFACE <b>IStream</b> : ISequentialStream<br/>
/// OBJIDL.h
/// </summary>
unsafe public interface IStream : ISequentialStream {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Seek (LARGE_INTEGER dlibMove, DWORD dwOrigin, ULARGE_INTEGER* plibNewPosition)</b><br/>
	/// </summary>
	/// <param name="dlibMove"><b>LARGE_INTEGER dlibMove</b></param>
	/// <param name="dwOrigin"><b>DWORD dwOrigin</b></param>
	/// <param name="plibNewPosition">_Out_opt_ <b>ULARGE_INTEGER* plibNewPosition</b></param>
	int Seek (long dlibMove, uint dwOrigin, ulong* plibNewPosition);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Seek (LARGE_INTEGER dlibMove, DWORD dwOrigin, ULARGE_INTEGER* plibNewPosition)</b><br/>
	/// </summary>
	/// <param name="dlibMove"><b>LARGE_INTEGER dlibMove</b></param>
	/// <param name="dwOrigin"><b>DWORD dwOrigin</b></param>
	/// <param name="plibNewPosition">_Out_opt_ <b>ULARGE_INTEGER* plibNewPosition</b></param>
	int Seek (long dlibMove, uint dwOrigin, out ulong plibNewPosition);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::SetSize (ULARGE_INTEGER libNewSize)</b><br/>
	/// </summary>
	/// <param name="libNewSize"><b>ULARGE_INTEGER libNewSize</b></param>
	int SetSize (ulong libNewSize);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::CopyTo (IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)</b><br/>
	/// </summary>
	/// <param name="pstm">_In_ <b>IStream* pstm</b></param>
	/// <param name="cb"><b>ULARGE_INTEGER cb</b></param>
	/// <param name="pcbRead">_Out_opt_ <b>ULARGE_INTEGER* pcbRead</b></param>
	/// <param name="pcbWritten">_Out_opt_ <b>ULARGE_INTEGER* pcbWritten</b></param>
	int CopyTo<T0> (T0* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::CopyTo (IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)</b><br/>
	/// </summary>
	/// <param name="pstm">_In_ <b>IStream* pstm</b></param>
	/// <param name="cb"><b>ULARGE_INTEGER cb</b></param>
	/// <param name="pcbRead">_Out_opt_ <b>ULARGE_INTEGER* pcbRead</b></param>
	/// <param name="pcbWritten">_Out_opt_ <b>ULARGE_INTEGER* pcbWritten</b></param>
	int CopyTo<T0> (T0* pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Commit (DWORD grfCommitFlags)</b><br/>
	/// </summary>
	/// <param name="grfCommitFlags"><b>DWORD grfCommitFlags</b></param>
	int Commit (uint grfCommitFlags);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Revert ()</b><br/>
	/// </summary>
	int Revert ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::LockRegion (ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType)</b><br/>
	/// </summary>
	/// <param name="libOffset"><b>ULARGE_INTEGER libOffset</b></param>
	/// <param name="cb"><b>ULARGE_INTEGER cb</b></param>
	/// <param name="dwLockType"><b>DWORD dwLockType</b></param>
	int LockRegion (ulong libOffset, ulong cb, uint dwLockType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::UnlockRegion (ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, DWORD dwLockType)</b><br/>
	/// </summary>
	/// <param name="libOffset"><b>ULARGE_INTEGER libOffset</b></param>
	/// <param name="cb"><b>ULARGE_INTEGER cb</b></param>
	/// <param name="dwLockType"><b>DWORD dwLockType</b></param>
	int UnlockRegion (ulong libOffset, ulong cb, uint dwLockType);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Stat (STATSTG* pstatstg, DWORD grfStatFlag)</b><br/>
	/// </summary>
	/// <param name="pstatstg">__RPC__out <b>STATSTG* pstatstg</b></param>
	/// <param name="grfStatFlag"><b>DWORD grfStatFlag</b></param>
	int Stat (STATSTG* pstatstg, uint grfStatFlag);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Stat (STATSTG* pstatstg, DWORD grfStatFlag)</b><br/>
	/// </summary>
	/// <param name="pstatstg">__RPC__out <b>STATSTG* pstatstg</b></param>
	/// <param name="grfStatFlag"><b>DWORD grfStatFlag</b></param>
	int Stat (out STATSTG pstatstg, uint grfStatFlag);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Clone (IStream** ppstm)</b><br/>
	/// </summary>
	/// <param name="ppstm">__RPC__deref_out_opt <b>IStream** ppstm</b></param>
	int Clone<T0> (T0** ppstm) where T0 : unmanaged, IStream;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IStream::Clone (IStream** ppstm)</b><br/>
	/// </summary>
	/// <param name="ppstm">__RPC__deref_out_opt <b>IStream** ppstm</b></param>
	int Clone<T0> (out T0* ppstm) where T0 : unmanaged, IStream;
}

/// <summary>
/// Instance of <b>IStream</b><br/>
/// OBJIDL.h
/// </summary>
unsafe public readonly struct Stream : IStream {
	//unsafe public readonly struct IStreamObj : IStream {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly Stream* GetCurrentPointer () => (Stream*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IStreamObj* GetCurrentPointer () => (IStreamObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x0000000c, 0x0000, 0x0000, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

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

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Seek (long dlibMove, uint dwOrigin, ulong* plibNewPosition) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Seek (ptr, dlibMove, dwOrigin, plibNewPosition);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Seek (long dlibMove, uint dwOrigin, out ulong plibNewPosition) {
		fixed (ulong* _plibNewPosition = &plibNewPosition) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Seek (ptr, dlibMove, dwOrigin, _plibNewPosition);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int SetSize (ulong libNewSize) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->SetSize (ptr, libNewSize);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyTo<T0> (T0* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->CopyTo (ptr, pstm, cb, pcbRead, pcbWritten);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int CopyTo<T0> (T0* pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten) where T0 : unmanaged, IStream {
		fixed (ulong* _pcbRead = &pcbRead) {
			fixed (ulong* _pcbWritten = &pcbWritten) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->CopyTo (ptr, pstm, cb, _pcbRead, _pcbWritten);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Commit (uint grfCommitFlags) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Commit (ptr, grfCommitFlags);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Revert () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Revert (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int LockRegion (ulong libOffset, ulong cb, uint dwLockType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->LockRegion (ptr, libOffset, cb, dwLockType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int UnlockRegion (ulong libOffset, ulong cb, uint dwLockType) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->UnlockRegion (ptr, libOffset, cb, dwLockType);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Stat (STATSTG* pstatstg, uint grfStatFlag) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Stat (ptr, pstatstg, grfStatFlag);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Stat (out STATSTG pstatstg, uint grfStatFlag) {
		fixed (STATSTG* _pstatstg = &pstatstg) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Stat (ptr, _pstatstg, grfStatFlag);
			return hr;
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** ppstm) where T0 : unmanaged, IStream {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) ppstm);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* ppstm) where T0 : unmanaged, IStream {
		fixed (T0** _ppstm = &ppstm) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _ppstm);
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
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, long, uint, ulong*, int> Seek;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, int> SetSize;
		/// <summary>
		/// OFFSET 7
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void*, ulong, ulong*, ulong*, int> CopyTo;
		/// <summary>
		/// OFFSET 8
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> Commit;
		/// <summary>
		/// OFFSET 9
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Revert;
		/// <summary>
		/// OFFSET 10
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, uint, int> LockRegion;
		/// <summary>
		/// OFFSET 11
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, ulong, ulong, uint, int> UnlockRegion;
		/// <summary>
		/// OFFSET 12
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, STATSTG*, uint, int> Stat;
		/// <summary>
		/// OFFSET 13
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
