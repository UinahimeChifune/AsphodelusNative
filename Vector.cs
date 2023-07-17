using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// 通用INT32类型二维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector2I : IEquatable<Vector2I>, IEqualityOperators<Vector2I, Vector2I, bool>, IAdditionOperators<Vector2I, Vector2I, Vector2I>, ISubtractionOperators<Vector2I, Vector2I, Vector2I>, IMultiplyOperators<Vector2I, Vector2I, Vector2I>, IMultiplyOperators<Vector2I, int, Vector2I>, IDivisionOperators<Vector2I, Vector2I, Vector2I>, IDivisionOperators<Vector2I, int, Vector2I> {

	readonly int _0;
	readonly int _1;

	/// <summary>
	/// X
	/// </summary>
	public readonly int X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly int Y { get => _1; init => _1 = value; }

	/// <summary>
	/// 宽度
	/// </summary>
	public readonly int SizeWidth { get => _0; init => _0 = value; }
	/// <summary>
	/// 高度
	/// </summary>
	public readonly int SizeHeight { get => _0; init => _0 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	public Vector2I (int _0, int _1) {
		this._0 = _0;
		this._1 = _1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector2I v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector2I other) {
		return _0 == other._0 && _1 == other._1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0}, {_1})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector2I left, Vector2I right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector2I left, Vector2I right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator + (Vector2I left, Vector2I right) {
		return new Vector2I (left._0 + right._0, left._1 + right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator - (Vector2I left, Vector2I right) {
		return new Vector2I (left._0 - right._0, left._1 - right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator * (Vector2I left, Vector2I right) {
		return new Vector2I (left._0 * right._0, left._1 * right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator * (Vector2I left, int right) {
		return new Vector2I (left._0 * right, left._1 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator / (Vector2I left, Vector2I right) {
		return new Vector2I (left._0 / right._0, left._1 / right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2I operator / (Vector2I left, int right) {
		return new Vector2I (left._0 / right, left._1 / right);
	}
}

/// <summary>
/// 通用UINT32类型二维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector2U : IEquatable<Vector2U>, IEqualityOperators<Vector2U, Vector2U, bool>, IAdditionOperators<Vector2U, Vector2U, Vector2U>, ISubtractionOperators<Vector2U, Vector2U, Vector2U>, IMultiplyOperators<Vector2U, Vector2U, Vector2U>, IMultiplyOperators<Vector2U, uint, Vector2U>, IDivisionOperators<Vector2U, Vector2U, Vector2U>, IDivisionOperators<Vector2U, uint, Vector2U> {

	readonly uint _0;
	readonly uint _1;

	/// <summary>
	/// X
	/// </summary>
	public readonly uint X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly uint Y { get => _1; init => _1 = value; }

	/// <summary>
	/// 宽度
	/// </summary>
	public readonly uint SizeWidth { get => _0; init => _0 = value; }
	/// <summary>
	/// 高度
	/// </summary>
	public readonly uint SizeHeight { get => _0; init => _0 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	public Vector2U (uint _0, uint _1) {
		this._0 = _0;
		this._1 = _1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector2U v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector2U other) {
		return _0 == other._0 && _1 == other._1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0}, {_1})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector2U left, Vector2U right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector2U left, Vector2U right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator + (Vector2U left, Vector2U right) {
		return new Vector2U (left._0 + right._0, left._1 + right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator - (Vector2U left, Vector2U right) {
		return new Vector2U (left._0 - right._0, left._1 - right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator * (Vector2U left, Vector2U right) {
		return new Vector2U (left._0 * right._0, left._1 * right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator * (Vector2U left, uint right) {
		return new Vector2U (left._0 * right, left._1 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator / (Vector2U left, Vector2U right) {
		return new Vector2U (left._0 / right._0, left._1 / right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2U operator / (Vector2U left, uint right) {
		return new Vector2U (left._0 / right, left._1 / right);
	}
}

/// <summary>
/// 通用FLOAT类型二维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector2F : IEquatable<Vector2F>, IEqualityOperators<Vector2F, Vector2F, bool>, IAdditionOperators<Vector2F, Vector2F, Vector2F>, ISubtractionOperators<Vector2F, Vector2F, Vector2F>, IMultiplyOperators<Vector2F, Vector2F, Vector2F>, IMultiplyOperators<Vector2F, float, Vector2F>, IDivisionOperators<Vector2F, Vector2F, Vector2F>, IDivisionOperators<Vector2F, float, Vector2F> {

	readonly float _0;
	readonly float _1;

	/// <summary>
	/// X
	/// </summary>
	public readonly float X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly float Y { get => _1; init => _1 = value; }

	/// <summary>
	/// 宽度
	/// </summary>
	public readonly float SizeWidth { get => _0; init => _0 = value; }
	/// <summary>
	/// 高度
	/// </summary>
	public readonly float SizeHeight { get => _0; init => _0 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	public Vector2F (float _0, float _1) {
		this._0 = _0;
		this._1 = _1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector2F v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector2F other) {
		return _0 == other._0 && _1 == other._1;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector2F left, Vector2F right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector2F left, Vector2F right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator + (Vector2F left, Vector2F right) {
		return new Vector2F (left._0 + right._0, left._1 + right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator - (Vector2F left, Vector2F right) {
		return new Vector2F (left._0 - right._0, left._1 - right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator * (Vector2F left, Vector2F right) {
		return new Vector2F (left._0 * right._0, left._1 * right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator * (Vector2F left, float right) {
		return new Vector2F (left._0 * right, left._1 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator / (Vector2F left, Vector2F right) {
		return new Vector2F (left._0 / right._0, left._1 / right._1);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector2F operator / (Vector2F left, float right) {
		return new Vector2F (left._0 / right, left._1 / right);
	}
}

/// <summary>
/// 通用INT类型三维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector3I : IEquatable<Vector3I>, IEqualityOperators<Vector3I, Vector3I, bool>, IAdditionOperators<Vector3I, Vector3I, Vector3I>, ISubtractionOperators<Vector3I, Vector3I, Vector3I>, IMultiplyOperators<Vector3I, Vector3I, Vector3I>, IMultiplyOperators<Vector3I, int, Vector3I>, IDivisionOperators<Vector3I, Vector3I, Vector3I>, IDivisionOperators<Vector3I, int, Vector3I> {

	readonly int _0;
	readonly int _1;
	readonly int _2;
	/// <summary>
	/// X
	/// </summary>
	public readonly int X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly int Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly int Z { get => _2; init => _2 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	public Vector3I (int _0, int _1, int _2) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector3I v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector3I other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector3I left, Vector3I right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector3I left, Vector3I right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator + (Vector3I left, Vector3I right) {
		return new Vector3I (left._0 + right._0, left._1 + right._1, left._2 + right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator - (Vector3I left, Vector3I right) {
		return new Vector3I (left._0 - right._0, left._1 - right._1, left._2 - right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator * (Vector3I left, Vector3I right) {
		return new Vector3I (left._0 * right._0, left._1 * right._1, left._2 * right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator * (Vector3I left, int right) {
		return new Vector3I (left._0 * right, left._1 * right, left._2 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator / (Vector3I left, Vector3I right) {
		return new Vector3I (left._0 / right._0, left._1 / right._1, left._2 / right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3I operator / (Vector3I left, int right) {
		return new Vector3I (left._0 / right, left._1 / right, left._2 / right);
	}
}

/// <summary>
/// 通用UINT类型三维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector3U : IEquatable<Vector3U>, IEqualityOperators<Vector3U, Vector3U, bool>, IAdditionOperators<Vector3U, Vector3U, Vector3U>, ISubtractionOperators<Vector3U, Vector3U, Vector3U>, IMultiplyOperators<Vector3U, Vector3U, Vector3U>, IMultiplyOperators<Vector3U, uint, Vector3U>, IDivisionOperators<Vector3U, Vector3U, Vector3U>, IDivisionOperators<Vector3U, uint, Vector3U> {

	readonly uint _0;
	readonly uint _1;
	readonly uint _2;
	/// <summary>
	/// X
	/// </summary>
	public readonly uint X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly uint Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly uint Z { get => _2; init => _2 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	public Vector3U (uint _0, uint _1, uint _2) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector3U v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector3U other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector3U left, Vector3U right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector3U left, Vector3U right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator + (Vector3U left, Vector3U right) {
		return new Vector3U (left._0 + right._0, left._1 + right._1, left._2 + right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator - (Vector3U left, Vector3U right) {
		return new Vector3U (left._0 - right._0, left._1 - right._1, left._2 - right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator * (Vector3U left, Vector3U right) {
		return new Vector3U (left._0 * right._0, left._1 * right._1, left._2 * right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator * (Vector3U left, uint right) {
		return new Vector3U (left._0 * right, left._1 * right, left._2 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator / (Vector3U left, Vector3U right) {
		return new Vector3U (left._0 / right._0, left._1 / right._1, left._2 / right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3U operator / (Vector3U left, uint right) {
		return new Vector3U (left._0 / right, left._1 / right, left._2 / right);
	}
}

/// <summary>
/// 通用FLOAT类型三维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector3F : IEquatable<Vector3F>, IEqualityOperators<Vector3F, Vector3F, bool>, IAdditionOperators<Vector3F, Vector3F, Vector3F>, ISubtractionOperators<Vector3F, Vector3F, Vector3F>, IMultiplyOperators<Vector3F, Vector3F, Vector3F>, IMultiplyOperators<Vector3F, float, Vector3F>, IDivisionOperators<Vector3F, Vector3F, Vector3F>, IDivisionOperators<Vector3F, float, Vector3F> {

	readonly float _0;
	readonly float _1;
	readonly float _2;
	/// <summary>
	/// X
	/// </summary>
	public readonly float X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly float Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly float Z { get => _2; init => _2 = value; }

	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBColorRed { get => _0; init => _0 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBColorGreen { get => _1; init => _1 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBColorBlue { get => _2; init => _2 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	public Vector3F (float _0, float _1, float _2) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector3F v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector3F other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector3F left, Vector3F right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector3F left, Vector3F right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator + (Vector3F left, Vector3F right) {
		return new Vector3F (left._0 + right._0, left._1 + right._1, left._2 + right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator - (Vector3F left, Vector3F right) {
		return new Vector3F (left._0 - right._0, left._1 - right._1, left._2 - right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator * (Vector3F left, Vector3F right) {
		return new Vector3F (left._0 * right._0, left._1 * right._1, left._2 * right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator * (Vector3F left, float right) {
		return new Vector3F (left._0 * right, left._1 * right, left._2 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator / (Vector3F left, Vector3F right) {
		return new Vector3F (left._0 / right._0, left._1 / right._1, left._2 / right._2);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector3F operator / (Vector3F left, float right) {
		return new Vector3F (left._0 / right, left._1 / right, left._2 / right);
	}
}

/// <summary>
/// 通用INT类型四维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector4I : IEquatable<Vector4I>, IEqualityOperators<Vector4I, Vector4I, bool>, IAdditionOperators<Vector4I, Vector4I, Vector4I>, ISubtractionOperators<Vector4I, Vector4I, Vector4I>, IMultiplyOperators<Vector4I, Vector4I, Vector4I>, IMultiplyOperators<Vector4I, int, Vector4I>, IDivisionOperators<Vector4I, Vector4I, Vector4I>, IDivisionOperators<Vector4I, int, Vector4I> {

	readonly int _0;
	readonly int _1;
	readonly int _2;
	readonly int _3;

	/// <summary>
	/// X
	/// </summary>
	public readonly int X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly int Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly int Z { get => _2; init => _2 = value; }
	/// <summary>
	/// W
	/// </summary>
	public readonly int W { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	public readonly int RectLeft { get => _0; init => _0 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly int RectTop { get => _1; init => _1 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly int RectRight { get => _2; init => _2 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly int RectBottom { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	/// <param name="_3"></param>
	public Vector4I (int _0, int _1, int _2, int _3) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
		this._3 = _3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector4I v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector4I other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2 && _3 == other._3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2, _3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2}, {_3:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector4I left, Vector4I right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector4I left, Vector4I right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator + (Vector4I left, Vector4I right) {
		return new Vector4I (left._0 + right._0, left._1 + right._1, left._2 + right._2, left._3 + right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator - (Vector4I left, Vector4I right) {
		return new Vector4I (left._0 - right._0, left._1 - right._1, left._2 - right._2, left._3 - right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator * (Vector4I left, Vector4I right) {
		return new Vector4I (left._0 * right._0, left._1 * right._1, left._2 * right._2, left._3 * right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator * (Vector4I left, int right) {
		return new Vector4I (left._0 * right, left._1 * right, left._2 * right, left._3 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator / (Vector4I left, Vector4I right) {
		return new Vector4I (left._0 / right._0, left._1 / right._1, left._2 / right._2, left._3 / right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4I operator / (Vector4I left, int right) {
		return new Vector4I (left._0 / right, left._1 / right, left._2 / right, left._3 / right);
	}
}

/// <summary>
/// 通用UINT类型四维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector4U : IEquatable<Vector4U>, IEqualityOperators<Vector4U, Vector4U, bool>, IAdditionOperators<Vector4U, Vector4U, Vector4U>, ISubtractionOperators<Vector4U, Vector4U, Vector4U>, IMultiplyOperators<Vector4U, Vector4U, Vector4U>, IMultiplyOperators<Vector4U, uint, Vector4U>, IDivisionOperators<Vector4U, Vector4U, Vector4U>, IDivisionOperators<Vector4U, uint, Vector4U> {

	readonly uint _0;
	readonly uint _1;
	readonly uint _2;
	readonly uint _3;

	/// <summary>
	/// X
	/// </summary>
	public readonly uint X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly uint Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly uint Z { get => _2; init => _2 = value; }
	/// <summary>
	/// W
	/// </summary>
	public readonly uint W { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	public readonly uint RectLeft { get => _0; init => _0 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly uint RectTop { get => _1; init => _1 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly uint RectRight { get => _2; init => _2 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly uint RectBottom { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	/// <param name="_3"></param>
	public Vector4U (uint _0, uint _1, uint _2, uint _3) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
		this._3 = _3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector4U v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector4U other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2 && _3 == other._3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2, _3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2}, {_3:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector4U left, Vector4U right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector4U left, Vector4U right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator + (Vector4U left, Vector4U right) {
		return new Vector4U (left._0 + right._0, left._1 + right._1, left._2 + right._2, left._3 + right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator - (Vector4U left, Vector4U right) {
		return new Vector4U (left._0 - right._0, left._1 - right._1, left._2 - right._2, left._3 - right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator * (Vector4U left, Vector4U right) {
		return new Vector4U (left._0 * right._0, left._1 * right._1, left._2 * right._2, left._3 * right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator * (Vector4U left, uint right) {
		return new Vector4U (left._0 * right, left._1 * right, left._2 * right, left._3 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator / (Vector4U left, Vector4U right) {
		return new Vector4U (left._0 / right._0, left._1 / right._1, left._2 / right._2, left._3 / right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4U operator / (Vector4U left, uint right) {
		return new Vector4U (left._0 / right, left._1 / right, left._2 / right, left._3 / right);
	}
}

/// <summary>
/// 通用FLOAT类型四维向量
/// </summary>
[StructLayout (LayoutKind.Sequential)]
public readonly struct Vector4F : IEquatable<Vector4F>, IEqualityOperators<Vector4F, Vector4F, bool>, IAdditionOperators<Vector4F, Vector4F, Vector4F>, ISubtractionOperators<Vector4F, Vector4F, Vector4F>, IMultiplyOperators<Vector4F, Vector4F, Vector4F>, IMultiplyOperators<Vector4F, float, Vector4F>, IDivisionOperators<Vector4F, Vector4F, Vector4F>, IDivisionOperators<Vector4F, float, Vector4F> {

	readonly float _0;
	readonly float _1;
	readonly float _2;
	readonly float _3;

	/// <summary>
	/// X
	/// </summary>
	public readonly float X { get => _0; init => _0 = value; }
	/// <summary>
	/// Y
	/// </summary>
	public readonly float Y { get => _1; init => _1 = value; }
	/// <summary>
	/// Z
	/// </summary>
	public readonly float Z { get => _2; init => _2 = value; }
	/// <summary>
	/// W
	/// </summary>
	public readonly float W { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	public readonly float RectLeft { get => _0; init => _0 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RectTop { get => _1; init => _1 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RectRight { get => _2; init => _2 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RectBottom { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBAColorRed { get => _0; init => _0 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBAColorGreen { get => _1; init => _1 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBAColorBlue { get => _2; init => _2 = value; }
	/// <summary>
	/// 
	/// </summary>
	public readonly float RGBAColorAlpha { get => _3; init => _3 = value; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	/// <param name="_3"></param>
	public Vector4F (float _0, float _1, float _2, float _3) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
		this._3 = _3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Vector4F v && Equals (v);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Vector4F other) {
		return _0 == other._0 && _1 == other._1 && _2 == other._2 && _3 == other._3;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		return HashCode.Combine (_0, _1, _2, _3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override string ToString () {
		return $"({_0:f2}, {_1:f2}, {_2:f2}, {_3:f2})";
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Vector4F left, Vector4F right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Vector4F left, Vector4F right) {
		return !(left == right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator + (Vector4F left, Vector4F right) {
		return new Vector4F (left._0 + right._0, left._1 + right._1, left._2 + right._2, left._3 + right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator - (Vector4F left, Vector4F right) {
		return new Vector4F (left._0 - right._0, left._1 - right._1, left._2 - right._2, left._3 - right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator * (Vector4F left, Vector4F right) {
		return new Vector4F (left._0 * right._0, left._1 * right._1, left._2 * right._2, left._3 * right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator * (Vector4F left, float right) {
		return new Vector4F (left._0 * right, left._1 * right, left._2 * right, left._3 * right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator / (Vector4F left, Vector4F right) {
		return new Vector4F (left._0 / right._0, left._1 / right._1, left._2 / right._2, left._3 / right._3);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static Vector4F operator / (Vector4F left, float right) {
		return new Vector4F (left._0 / right, left._1 / right, left._2 / right, left._3 / right);
	}
}
