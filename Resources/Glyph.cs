namespace SitelenPonaKeyboard.Resources
{
    public class Glyph
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Glyph(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}