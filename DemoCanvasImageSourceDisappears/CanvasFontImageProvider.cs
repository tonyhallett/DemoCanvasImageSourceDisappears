using System;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoCanvasImageSourceDisappears
{
    internal static class CanvasFontImageProvider
    {
        public static event EventHandler DeviceLost;
        public static Image Get(string fontFamily, float fontSize, string glyph, Windows.UI.Color iconColor)
        {
            FontCanvasImageSourceProvider.DeviceLost += (sender, e) => DeviceLost?.Invoke(sender, e);
            var canvasImageSource = FontCanvasImageSourceProvider.Provide(fontFamily, fontSize, glyph, iconColor);
            return new Image
            {
                Source = canvasImageSource,
                Width = canvasImageSource.Size.Width,
                Height = canvasImageSource.Size.Height
            };
        }
    }
}
