
namespace EnumExtended
{
    public enum Number1
    {
        One = 1,
        Two = 2,
    }

    public static class Number1Ext
    {

        public static readonly Number1Detail Number1_One = new Number1Detail("One", 1, "#");
        public static readonly Number1Detail Number1_Two = new Number1Detail("Two", 2, "##");

        public static string ToStringLite(this Number1 number)
        => number switch
        {
            Number1.One => nameof(Number1.One),
            Number1.Two => nameof(Number1.Two),
            _ => number.ToString(),
        };

        public static Number1 ValueOf(string value)
        => value switch
        {
            "One" => Number1.One,
            "Two" => Number1.Two,
            _ => 0,
        };

        public static Number1 KeyOf(string value)
        => value switch
        {
            "#" => Number1.One,
            "##" => Number1.Two,
            _ => 0,
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