﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// INTERFACE <b>IEnumUnknown</b> : IUnknown<br/>
/// OBJIDL.h
/// </summary>
unsafe public interface IEnumUnknown : IUnknown {
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Next (ULONG celt, IUnknown** rgelt, ULONG* pceltFetched)</b><br/>
	/// </summary>
	/// <param name="celt">_In_ <b>ULONG celt</b></param>
	/// <param name="rgelt">_Out_writes_to_(celt,*pceltFetched) <b>IUnknown** rgelt</b></param>
	/// <param name="pceltFetched">_Out_opt_ <b>ULONG* pceltFetched</b></param>
	int Next<T0> (uint celt, T0** rgelt, uint* pceltFetched) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Next (ULONG celt, IUnknown** rgelt, ULONG* pceltFetched)</b><br/>
	/// </summary>
	/// <param name="celt">_In_ <b>ULONG celt</b></param>
	/// <param name="rgelt">_Out_writes_to_(celt,*pceltFetched) <b>IUnknown** rgelt</b></param>
	/// <param name="pceltFetched">_Out_opt_ <b>ULONG* pceltFetched</b></param>
	int Next<T0> (uint celt, out T0* rgelt, out uint pceltFetched) where T0 : unmanaged, IUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Skip (ULONG celt)</b><br/>
	/// </summary>
	/// <param name="celt"><b>ULONG celt</b></param>
	int Skip (uint celt);
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Reset ()</b><br/>
	/// </summary>
	int Reset ();
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Clone (IEnumUnknown** ppenum)</b><br/>
	/// </summary>
	/// <param name="ppenum">__RPC__deref_out_opt <b>IEnumUnknown** ppenum</b></param>
	int Clone<T0> (T0** ppenum) where T0 : unmanaged, IEnumUnknown;
	/// <summary>
	/// STDMETHODCALLTYPE <b>HRESULT IEnumUnknown::Clone (IEnumUnknown** ppenum)</b><br/>
	/// </summary>
	/// <param name="ppenum">__RPC__deref_out_opt <b>IEnumUnknown** ppenum</b></param>
	int Clone<T0> (out T0* ppenum) where T0 : unmanaged, IEnumUnknown;
}

/// <summary>
/// Instance of <b>IEnumUnknown</b><br/>
/// OBJIDL.h
/// </summary>
unsafe public readonly struct EnumUnknown : IEnumUnknown {
	//unsafe public readonly struct IEnumUnknownObj : IEnumUnknown {

	readonly void** _pointer;

	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	readonly EnumUnknown* GetCurrentPointer () => (EnumUnknown*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));
	//readonly IEnumUnknownObj* GetCurrentPointer () => (IEnumUnknownObj*) Unsafe.AsPointer (ref Unsafe.AsRef (in this));

	/// <inheritdoc />
	public static Guid GUID { get => _guid; }
	static readonly Guid _guid = new (0x00000100, 0x0000, 0x0000, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

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
	public readonly int Next<T0> (uint celt, T0** rgelt, uint* pceltFetched) where T0 : unmanaged, IUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Next (ptr, celt, (void**) rgelt, pceltFetched);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Next<T0> (uint celt, out T0* rgelt, out uint pceltFetched) where T0 : unmanaged, IUnknown {
		fixed (T0** _rgelt = &rgelt) {
			fixed (uint* _pceltFetched = &pceltFetched) {
				var ptr = GetCurrentPointer ();
				var hr = ((FunctionPointer*) ptr->_pointer)->Next (ptr, celt, (void**) _rgelt, _pceltFetched);
				return hr;
			}
		}
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Skip (uint celt) {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Skip (ptr, celt);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Reset () {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Reset (ptr);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (T0** ppenum) where T0 : unmanaged, IEnumUnknown {
		var ptr = GetCurrentPointer ();
		var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) ppenum);
		return hr;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public readonly int Clone<T0> (out T0* ppenum) where T0 : unmanaged, IEnumUnknown {
		fixed (T0** _ppenum = &ppenum) {
			var ptr = GetCurrentPointer ();
			var hr = ((FunctionPointer*) ptr->_pointer)->Clone (ptr, (void**) _ppenum);
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
		public readonly delegate* unmanaged[Stdcall]<void*, uint, void**, uint*, int> Next;
		/// <summary>
		/// OFFSET 4
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, uint, int> Skip;
		/// <summary>
		/// OFFSET 5
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, int> Reset;
		/// <summary>
		/// OFFSET 6
		/// </summary>
		public readonly delegate* unmanaged[Stdcall]<void*, void**, int> Clone;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public void Dispose () => Release ();
}
