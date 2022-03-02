using DemoCanvasImageSourceDisappears.GoogleFontIcons;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoCanvasImageSourceDisappears
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var fontProvider = new MaterialOutlineFontProvider();
            var fontFamily = $"Assets/Fonts/MaterialIconsOutlined-Regular.otf#Material Icons Outlined";
            var deviceLostTextBlock = new TextBlock() { Text = "Device not lost" };
            CanvasFontImageProvider.DeviceLost += (sender, e) =>
            {
                deviceLostTextBlock.Text = "Device lost";
            };
            var glyphImage = CanvasFontImageProvider.Get(fontFamily, 96,MaterialIconsOutlined.ActionCategory.AlarmOn, Windows.UI.Colors.Red);
            stackPanel.Children.Add(glyphImage);
            stackPanel.Children.Add(deviceLostTextBlock);
        }
    }
}
