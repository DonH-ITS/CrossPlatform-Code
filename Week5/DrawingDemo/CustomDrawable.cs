
namespace DrawingDemo
{
    public class CustomDrawable : IDrawable
    {
        private int which = 1;
        public int Which
        {
            get { return which; }
            set { which = value; }
        }

        public void Draw(ICanvas canvas, RectF dirtyRect) {
            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 2;

            if (which == 1) {
                // Draw a rectangle
                canvas.DrawRectangle(50, 50, 100, 100);

                // Draw a circle
                canvas.FillColor = Colors.Blue;
                canvas.FillCircle(150, 150, 50);
            }
            else {

                // Draw a circle
                canvas.FillColor = Colors.Green;
                canvas.FillCircle(150, 150, 100);
            }
        }
    }

    public class DynamicDrawable : IDrawable
    {
        public float Width { get; set; } = 100;
        public float Height { get; set; } = 100;

        public void Draw(ICanvas canvas, RectF dirtyRect) {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;

            // Draw a dynamic rectangle
            canvas.DrawRectangle(50, 50, Width, Height);
        }
    }
}
