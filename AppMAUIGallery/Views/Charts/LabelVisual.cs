using LiveChartsCore.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;

namespace AppMAUIGallery.Views.Charts
{
    public class LabelVisual
    {
        public string Text { get; set; }
        public int TextSize { get; set; }

        public Padding Padding { get; set; } = new();

        public SolidColorPaint Paint { get; set; } = new();

    }
}
