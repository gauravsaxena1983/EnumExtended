using System;
namespace EnumExtended
{
	public enum Enum1
	{
		A = 1,
		B = 2,
	}
	public static class Enum1Extension
	{
		public static string ToStringLite(this Enum1 e)
		=> e switch
		{
			Enum1.A => nameof(Enum1.A),
			Enum1.B => nameof(Enum1.B),
			_ => e.ToString(),
		};

	}
}