﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cix.AST
{
	public sealed class NumericLiteral : ExpressionElement
	{
		private ulong integralValue;
		private double floatingValue;

		public LiteralType LiteralType { get; }
		public Type UnderlyingType { get; }
		
		public long SignedIntegralValue
		{
			get
			{
				if (LiteralType != LiteralType.SignedIntegral)
				{
					throw new ArgumentException($"This numeric literal was attempted to be accessed as a signed integer, but it is actually a {LiteralType}.");
				}

				unchecked
				{
					return (long)integralValue;
				}
			}
		}

		public ulong UnsignedIntegralValue
		{
			get
			{
				if (LiteralType != LiteralType.UnsignedIntegral)
				{
					throw new ArgumentException($"This numeric literal was attempted to be accessed as an unsigned integer, but it is actually a {LiteralType}.");
				}

				return integralValue;
			}
		}

		public double FloatingValue
		{
			get
			{
				if (LiteralType != LiteralType.Floating)
				{
					throw new ArgumentException($"This numeric literal was attempted to be accessed as a floating point number, but it is actually a {LiteralType}.");
				}

				return floatingValue;
			}
		}

		public NumericLiteral(byte value)
		{
			LiteralType = LiteralType.UnsignedIntegral;
			UnderlyingType = typeof(byte);
			integralValue = value;
		}

		public NumericLiteral(sbyte value)
		{
			LiteralType = LiteralType.SignedIntegral;
			UnderlyingType = typeof(sbyte);
			integralValue = unchecked((ulong)value);
		}

		public NumericLiteral(short value)
		{
			LiteralType = LiteralType.SignedIntegral;
			UnderlyingType = typeof(short);
			integralValue = unchecked((ulong)value);
		}

		public NumericLiteral(ushort value)
		{
			LiteralType = LiteralType.UnsignedIntegral;
			UnderlyingType = typeof(ushort);
			integralValue = value;
		}

		public NumericLiteral(int value)
		{
			LiteralType = LiteralType.SignedIntegral;
			UnderlyingType = typeof(int);
			integralValue = unchecked((ulong)value);
		}

		public NumericLiteral(uint value)
		{
			LiteralType = LiteralType.UnsignedIntegral;
			UnderlyingType = typeof(uint);
			integralValue = value;
		}

		public NumericLiteral(long value)
		{
			LiteralType = LiteralType.SignedIntegral;
			UnderlyingType = typeof(long);
			integralValue = unchecked((ulong)value);
		}

		public NumericLiteral(ulong value)
		{
			LiteralType = LiteralType.UnsignedIntegral;
			UnderlyingType = typeof(ulong);
			integralValue = value;
		}

		public NumericLiteral(float value)
		{
			LiteralType = LiteralType.Floating;
			UnderlyingType = typeof(float);
			floatingValue = value;
		}

		public NumericLiteral(double value)
		{
			LiteralType = LiteralType.Floating;
			UnderlyingType = typeof(double);
			floatingValue = value;
		}

		public static NumericLiteral Parse(string value)
		{
			if (!value.IsNumericLiteral())
			{
				throw new ArgumentException("Tried to parse a numeric literal that wasn't actually a numeric literal.");
			}

			value = value.ToLowerInvariant();

			if (value.EndsWith("f"))
			{
				float result = 0f;
				float.TryParse(value, out result);
				return new NumericLiteral(result);
			}
			else if (value.EndsWith("d") || value.Contains('.'))
			{
				double result = 0d;
				double.TryParse(value, out result);
				return new NumericLiteral(result);
			}
			else if (value.EndsWith("l"))
			{
				long result = 0L;
				long.TryParse(value, out result);
				return new NumericLiteral(result);
			}
			else if (value.EndsWith("ul"))
			{
				ulong result = 0UL;
				ulong.TryParse(value, out result);
				return new NumericLiteral(result);
			}
			else if (value.EndsWith("u"))
			{
				ulong result = 0UL;
				ulong.TryParse(value, out result);

				if (result > uint.MaxValue)
				{
					return new NumericLiteral(result);
				}
				else if (result > ushort.MaxValue && result < uint.MaxValue)
				{
					return new NumericLiteral((uint)result);
				}
				else if (result > byte.MaxValue && result < ushort.MaxValue)
				{
					return new NumericLiteral((ushort)result);
				}
				else if (result <= byte.MaxValue)
				{
					return new NumericLiteral((byte)result);
				}
			}
			else
			{
				long result = 0L;
				long.TryParse(value, out result);

				if (result > int.MaxValue)
				{
					return new NumericLiteral(result);
				}
				else if (result > short.MaxValue && result < int.MaxValue)
				{
					return new NumericLiteral((int)result);
				}
				else if (result > sbyte.MaxValue && result < short.MaxValue)
				{
					return new NumericLiteral((short)result);
				}
				else if (result <= sbyte.MaxValue)
				{
					return new NumericLiteral((sbyte)result);
				}
			}

			throw new InvalidProgramException("Unreachable.");
		}
	}

	public enum LiteralType
	{
		SignedIntegral,
		UnsignedIntegral,
		Floating
	}
}