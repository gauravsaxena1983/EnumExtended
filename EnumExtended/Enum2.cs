
namespace EnumExtended
{
	public enum Enum2
	{
		One = 1,
		Two = 2,
	}
	
	public static class Enum2Extension
	{
		public static string ToStringLite(this Enum2 number)
		=> number switch
		{
			Enum2.One => nameof(Enum2.One),
			Enum2.Two => nameof(Enum2.Two),
			_ => number.ToString(),
		};

		public static Enum2Detail Details(this Enum2 number)
		=> number switch
		{
			Enum2.One => new Enum2Detail(){
				Name = "One",
				Value = "1",
				Count = "#",

			},
			Enum2.Two => new Enum2Detail(){
				Name = "Two",
				Value = "2",
				Count = "##",

			},
			_ => null,
		};
		
	}

	public class Enum2Detail
	{
		public string Name {get; set;}
		public string Value {get; set;}
		public string Count {get; set;}
	}

}