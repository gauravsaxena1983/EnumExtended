using System;



namespace EnumExtended
{
	public enum Enum3
	{
		A = 1,
		B = 2,
		C = 3,
	}
	public static partial class Enum3Ext
	{
		public static readonly Enum3Detail Enum3_A = new Enum3Detail("A", 1, "A_1");
		public static readonly Enum3Detail Enum3_B = new Enum3Detail("B", 2, "B_2");
		public static readonly Enum3Detail Enum3_C = new Enum3Detail("C", 3, "C_C");
		public static string ToStringLite(this Enum3 e)
		=> e switch
		{
			Enum3.A => nameof(Enum3.A),
			Enum3.B => nameof(Enum3.B),
			Enum3.C => nameof(Enum3.C),
			_ => e.ToString(),
		};

		public static Enum3Detail Details(this Enum3 number)
		=> number switch
		{
			Enum3.A => Enum3_A,
			Enum3.B => Enum3_B,
			Enum3.C => Enum3_C,
			_ => null,
		};


		public static Enum3 KeyOf(string key)
		=> key switch
			{
			"A_1" => Enum3.A,
			"B_2" => Enum3.B,
			"C_C" => Enum3.C,
			_ => 0,
		};

		public static Enum3 ValueOf(string value)
		=> value switch
			{
			nameof(Enum3.A) => Enum3.A,
			nameof(Enum3.B) => Enum3.B,
			nameof(Enum3.C) => Enum3.C,
			_ => 0,
		};
	}

	public class Enum3Detail
	{
		public Enum3Detail(String Name, Int32 Value, String Key)
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