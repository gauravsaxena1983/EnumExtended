using System;



namespace EnumExtended
{
	public enum Enum2
	{
		A = 1,
		B = 2,
		C = 3,
	}
	public static partial class Enum2Ext
	{
		public static readonly Enum2Detail Enum2_A = new Enum2Detail("A", 1, "A_1");
		public static readonly Enum2Detail Enum2_B = new Enum2Detail("B", 2, "B_2");
		public static readonly Enum2Detail Enum2_C = new Enum2Detail("C", 3, "C_C");
		public static string ToStringLite(this Enum2 e)
		=> e switch
		{
			Enum2.A => nameof(Enum2.A),
			Enum2.B => nameof(Enum2.B),
			Enum2.C => nameof(Enum2.C),
			_ => e.ToString(),
		};

		public static Enum2Detail Details(this Enum2 number)
		=> number switch
		{
			Enum2.A => Enum2_A,
			Enum2.B => Enum2_B,
			Enum2.C => Enum2_C,
			_ => null,
		};


		public static Enum2 KeyOf(string key)
		=> key switch
			{
			"A_1" => Enum2.A,
			"B_2" => Enum2.B,
			"C_C" => Enum2.C,
			_ => 0,
		};

		public static Enum2 ValueOf(string value)
		=> value switch
			{
			nameof(Enum2.A) => Enum2.A,
			nameof(Enum2.B) => Enum2.B,
			nameof(Enum2.C) => Enum2.C,
			_ => 0,
		};
	}

	public class Enum2Detail
	{
		public Enum2Detail(String Name, Int32 Value, String Key)
		{
			this.Name = Name;
			this.Value = Value;
			this.Key = Key;
		}

		public String Name { get; private set; }
		public Int32 Value { get; private set; }
		public String Key { get; private set; }
	}
}