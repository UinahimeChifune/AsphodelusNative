using System;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// 通用FLOAT类型3x2矩阵
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Matrix3x2F : IEquatable<Matrix3x2F>, IEqualityOperators<Matrix3x2F, Matrix3x2F, bool>, IAdditionOperators<Matrix3x2F, Matrix3x2F, Matrix3x2F>, ISubtractionOperators<Matrix3x2F, Matrix3x2F, Matrix3x2F>, IMultiplyOperators<Matrix3x2F, Matrix3x2F, Matrix3x2F>, IMultiplyOperators<Matrix3x2F, float, Matrix3x2F>, IDivisionOperators<Matrix3x2F, float, Matrix3x2F> {

	readonly float _0;
	readonly float _1;
	readonly float _2;
	readonly float _3;
	readonly float _4;
	readonly float _5;

	/// <summary>
	/// M11
	/// </summary>
	public readonly float M11 { get => _0; init => _0 = value; }
	/// <summary>
	/// M12
	/// </summary>
	public readonly float M12 { get => _1; init => _1 = value; }
	/// <summary>
	/// M21
	/// </summary>
	public readonly float M21 { get => _2; init => _2 = value; }
	/// <summary>
	/// M22
	/// </summary>
	public readonly float M22 { get => _3; init => _3 = value; }
	/// <summary>
	/// M31
	/// </summary>
	public readonly float M31 { get => _4; init => _4 = value; }
	/// <summary>
	/// M32
	/// </summary>
	public readonly float M32 { get => _5; init => _5 = value; }

	/// <summary>
	/// 值序列
	/// </summary>
	public readonly Span<float> Values { get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in this)), 6); }

	/// <summary>
	/// 创建位移缩放矩阵
	/// </summary>
	/// <param name="offsetX"></param>
	/// <param name="offsetY"></param>
	/// <param name="scaleX"></param>
	/// <param name="scaleY"></param>
	public Matrix3x2F (float offsetX, float offsetY, float scaleX = 1, float scaleY = 1) {
		_0 = scaleX;
		_1 = 0;
		_2 = 0;
		_3 = scaleY;
		_4 = offsetX;
		_5 = offsetY;
	}

	/// <summary>
	/// 创建旋转矩阵
	/// </summary>
	/// <param name="angle"></param>
	/// <param name="centerX"></param>
	/// <param name="centerY"></param>
	public Matrix3x2F (float angle, float centerX, float centerY) {
		_0 = float.Cos (angle);
		_1 = float.Sin (angle);
		_2 = -_1;
		_3 = _0;
		_4 = centerX - _0 * centerX + _1 * centerY;
		_5 = centerY - _1 * centerX - _0 * centerY;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	/// <param name="_3"></param>
	/// <param name="_4"></param>
	/// <param name="_5"></param>
	public Matrix3x2F (float _0, float _1, float _2, float _3, float _4, float _5) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
		this._3 = _3;
		this._4 = _4;
		this._5 = _5;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Matrix3x2F f && Equals (f);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Matrix3x2F other) {
		return Values.SequenceEqual (other.Values);
	}

	/// <inheritdoc />
	public override int GetHashCode () {
		var values = Values;
		var hashCode = 0;
		for (var i = 0; i != values.Length; i++)
			hashCode = HashCode.Combine (hashCode, values [i]);
		return hashCode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Matrix3x2F left, Matrix3x2F right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Matrix3x2F left, Matrix3x2F right) {
		return !(left == right);
	}

	/// <inheritdoc />
	public static Matrix3x2F operator + (Matrix3x2F left, Matrix3x2F right) {
		Matrix3x2F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		var pRight = (float*) &right;
		for (var i = 0; i != 6; i++)
			pValue [i] = pLeft [i] + pRight [i];
		return value;
	}

	/// <inheritdoc />
	public static Matrix3x2F operator - (Matrix3x2F left, Matrix3x2F right) {
		Matrix3x2F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		var pRight = (float*) &right;
		for (var i = 0; i != 6; i++)
			pValue [i] = pLeft [i] - pRight [i];
		return value;
	}

	/// <inheritdoc />
	public static Matrix3x2F operator * (Matrix3x2F left, Matrix3x2F right) {
		return new Matrix3x2F (
			left._0 * right._0 + left._1 * right._2,
			left._0 * right._1 + left._1 * right._3,
			left._2 * right._0 + left._3 * right._2,
			left._2 * right._1 + left._3 * right._3,
			left._4 * right._0 + left._5 * right._2 + right._4,
			left._4 * right._1 + left._5 * right._3 + right._5);
	}

	/// <inheritdoc />
	public static Matrix3x2F operator * (Matrix3x2F left, float right) {
		Matrix3x2F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		for (var i = 0; i != 6; i++)
			pValue [i] = pLeft [i] * right;
		return value;
	}

	/// <inheritdoc />
	public static Matrix3x2F operator / (Matrix3x2F left, float right) {
		Matrix3x2F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		for (var i = 0; i != 6; i++)
			pValue [i] = pLeft [i] / right;
		return value;
	}
}

/// <summary>
/// 通用FLOAT类型4x4矩阵
/// </summary>
[StructLayout (LayoutKind.Sequential)]
unsafe public readonly struct Matrix4x4F : IEquatable<Matrix4x4F>, IEqualityOperators<Matrix4x4F, Matrix4x4F, bool>, IAdditionOperators<Matrix4x4F, Matrix4x4F, Matrix4x4F>, ISubtractionOperators<Matrix4x4F, Matrix4x4F, Matrix4x4F>, IMultiplyOperators<Matrix4x4F, Matrix4x4F, Matrix4x4F>, IMultiplyOperators<Matrix4x4F, float, Matrix4x4F>, IDivisionOperators<Matrix4x4F, float, Matrix4x4F> {

	readonly float _0;
	readonly float _1;
	readonly float _2;
	readonly float _3;
	readonly float _4;
	readonly float _5;
	readonly float _6;
	readonly float _7;
	readonly float _8;
	readonly float _9;
	readonly float _a;
	readonly float _b;
	readonly float _c;
	readonly float _d;
	readonly float _e;
	readonly float _f;

	/// <summary>
	/// M11
	/// </summary>
	public readonly float M11 { get => _0; init => _0 = value; }
	/// <summary>
	/// M12
	/// </summary>
	public readonly float M12 { get => _1; init => _1 = value; }
	/// <summary>
	/// M13
	/// </summary>
	public readonly float M13 { get => _2; init => _2 = value; }
	/// <summary>
	/// M14
	/// </summary>
	public readonly float M14 { get => _3; init => _3 = value; }
	/// <summary>
	/// M21
	/// </summary>
	public readonly float M21 { get => _4; init => _4 = value; }
	/// <summary>
	/// M22
	/// </summary>
	public readonly float M22 { get => _5; init => _5 = value; }
	/// <summary>
	/// M23
	/// </summary>
	public readonly float M23 { get => _6; init => _6 = value; }
	/// <summary>
	/// M24
	/// </summary>
	public readonly float M24 { get => _7; init => _7 = value; }
	/// <summary>
	/// M31
	/// </summary>
	public readonly float M31 { get => _8; init => _8 = value; }
	/// <summary>
	/// M32
	/// </summary>
	public readonly float M32 { get => _9; init => _9 = value; }
	/// <summary>
	/// M33
	/// </summary>
	public readonly float M33 { get => _a; init => _a = value; }
	/// <summary>
	/// M34
	/// </summary>
	public readonly float M34 { get => _b; init => _b = value; }
	/// <summary>
	/// M41
	/// </summary>
	public readonly float M41 { get => _c; init => _c = value; }
	/// <summary>
	/// M42
	/// </summary>
	public readonly float M42 { get => _d; init => _d = value; }
	/// <summary>
	/// M43
	/// </summary>
	public readonly float M43 { get => _e; init => _e = value; }
	/// <summary>
	/// M44
	/// </summary>
	public readonly float M44 { get => _f; init => _f = value; }

	/// <summary>
	/// 值序列
	/// </summary>
	public readonly Span<float> Values { get => new (Unsafe.AsPointer (ref Unsafe.AsRef (in this)), 16); }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="_0"></param>
	/// <param name="_1"></param>
	/// <param name="_2"></param>
	/// <param name="_3"></param>
	/// <param name="_4"></param>
	/// <param name="_5"></param>
	/// <param name="_6"></param>
	/// <param name="_7"></param>
	/// <param name="_8"></param>
	/// <param name="_9"></param>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <param name="c"></param>
	/// <param name="d"></param>
	/// <param name="e"></param>
	/// <param name="f"></param>
	public Matrix4x4F (float _0, float _1, float _2, float _3, float _4, float _5, float _6, float _7, float _8, float _9, float a, float b, float c, float d, float e, float f) {
		this._0 = _0;
		this._1 = _1;
		this._2 = _2;
		this._3 = _3;
		this._4 = _4;
		this._5 = _5;
		this._6 = _6;
		this._7 = _7;
		this._8 = _8;
		this._9 = _9;
		_a = a;
		_b = b;
		_c = c;
		_d = d;
		_e = e;
		_f = f;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override bool Equals (object? obj) {
		return obj is Matrix4x4F f && Equals (f);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public bool Equals (Matrix4x4F other) {
		return Values.SequenceEqual (other.Values);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode () {
		var values = Values;
		var hashCode = 0;
		for (var i = 0; i != values.Length; i++)
			hashCode = HashCode.Combine (hashCode, values [i]);
		return hashCode;
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator == (Matrix4x4F left, Matrix4x4F right) {
		return left.Equals (right);
	}

	/// <inheritdoc />
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool operator != (Matrix4x4F left, Matrix4x4F right) {
		return !(left == right);
	}

	/// <inheritdoc />
	public static Matrix4x4F operator + (Matrix4x4F left, Matrix4x4F right) {
		Matrix4x4F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		var pRight = (float*) &right;
		for (var i = 0; i != 16; i++)
			pValue [i] = pLeft [i] + pRight [i];
		return value;
	}

	/// <inheritdoc />
	public static Matrix4x4F operator - (Matrix4x4F left, Matrix4x4F right) {
		Matrix4x4F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		var pRight = (float*) &right;
		for (var i = 0; i != 16; i++)
			pValue [i] = pLeft [i] - pRight [i];
		return value;
	}

	/// <inheritdoc />
	public static Matrix4x4F operator * (Matrix4x4F left, Matrix4x4F right) {
		return new (
			left._0 * right._0 + left._1 * right._4 + left._2 * right._8 + left._3 * right._c,
			left._0 * right._1 + left._1 * right._5 + left._2 * right._9 + left._3 * right._d,
			left._0 * right._2 + left._1 * right._6 + left._2 * right._a + left._3 * right._e,
			left._0 * right._3 + left._1 * right._7 + left._2 * right._b + left._3 * right._f,
			left._4 * right._0 + left._5 * right._4 + left._6 * right._8 + left._7 * right._c,
			left._4 * right._1 + left._5 * right._5 + left._6 * right._9 + left._7 * right._d,
			left._4 * right._2 + left._5 * right._6 + left._6 * right._a + left._7 * right._e,
			left._4 * right._3 + left._5 * right._7 + left._6 * right._b + left._7 * right._f,
			left._8 * right._0 + left._9 * right._4 + left._a * right._8 + left._b * right._c,
			left._8 * right._1 + left._9 * right._5 + left._a * right._9 + left._b * right._d,
			left._8 * right._2 + left._9 * right._6 + left._a * right._a + left._b * right._e,
			left._8 * right._3 + left._9 * right._7 + left._a * right._b + left._b * right._f,
			left._c * right._0 + left._d * right._4 + left._e * right._8 + left._f * right._c,
			left._c * right._1 + left._d * right._5 + left._e * right._9 + left._f * right._d,
			left._c * right._2 + left._d * right._6 + left._e * right._a + left._f * right._e,
			left._c * right._3 + left._d * right._7 + left._e * right._b + left._f * right._f);
	}

	/// <inheritdoc />
	public static Matrix4x4F operator * (Matrix4x4F left, float right) {
		Matrix4x4F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		for (var i = 0; i != 16; i++)
			pValue [i] = pLeft [i] * right;
		return value;
	}

	/// <inheritdoc />
	public static Matrix4x4F operator / (Matrix4x4F left, float right) {
		Matrix4x4F value;
		var pValue = (float*) &value;
		var pLeft = (float*) &left;
		for (var i = 0; i != 16; i++)
			pValue [i] = pLeft [i] / right;
		return value;
	}
}
