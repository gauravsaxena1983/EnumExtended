
namespace EnumExtended
{
	public enum Number1
	{
		One = 1,
		Two = 2,
	}

	public static class Number1Util
    {
		public static Number1 GetNumber1(string key)
			=> key switch
			{
				"X" => Number1.One,
				"XX" => Number1.Two,
				_ => 0,
			};
	}

	public static class Number1Extension
	{
        
        public static readonly Number1Detail Number1_One = new Number1Detail("One", 1, "X");
		public static readonly Number1Detail Number1_Two = new Number1Detail("Two", 2, "XX");

		public static string ToStringLite(this Number1 number)
		=> number switch
		{
			Number1.One => nameof(Number1.One),
			Number1.Two => nameof(Number1.Two),
			_ => number.ToString(),
		};

		

		public static Number1Detail Details(this Number1 number)
		=> number switch
		{
			Number1.One => Number1_One,
			Number1.Two => Number1_Two,
			_ => null,
		};

	}

	public class Number1Detail
	{
		public Number1Detail(string Name, int Value, string Key)
        {
			this.Name = Name;
			this.Value = Value;
			this.Key = Key;
        }
		public string Name { get; private set; }
		public int Value { get; private set; }
		public string Key { get; private set; }
	}

}