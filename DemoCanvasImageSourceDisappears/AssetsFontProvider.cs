namespace DemoCanvasImageSourceDisappears
{
    public abstract class AssetsFontProvider
    {
        protected abstract string FileName { get; }
        protected abstract string FontName { get; }
        public string FontFamily => $"Assets/Fonts/{FileName}#{FontName}";

        protected string GetGlyph(string codePoint)
        {
            int p = int.Parse(codePoint, System.Globalization.NumberStyles.HexNumber);
            return char.ConvertFromUtf32(p);
        }
    }
}
