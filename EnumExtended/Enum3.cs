
namespace EnumExtended
{
	public enum Enum3
	{
		One = 1,
		Two = 2,
	}
	
	public static class Enum3Extension
	{
		public static string ToStringLite(this Enum3 number)
		=> number switch
		{
			Enum3.One => nameof(Enum3.One),
			Enum3.Two => nameof(Enum3.Two),
			_ => number.ToString(),
		};

		public static Enum3Detail Details(this Enum3 number)
		=> number switch
		{
			Enum3.One => new Enum3Detail(){
				Name = "One",
				Value = "1",
				Count = "X",

			},
			Enum3.Two => new Enum3Detail(){
				Name = "Two",
				Value = "2",
				Count = "XX",

			},
			_ => null,
		};
		
	}

	public class Enum3Detail
	{
		public string Name {get; set;}
		public string Value {get; set;}
		public string Count {get; set;}
	}

}