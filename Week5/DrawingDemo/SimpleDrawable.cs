
namespace DrawingDemo
{
    public class SimpleDrawable : IDrawable
    {
        private readonly List<Point> points;
        public SimpleDrawable(List<Point> strokes) {
            points = strokes;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect) {
            // Draw each line in the strokes list
            canvas.StrokeColor = Colors.Black; // Set stroke color to black
            canvas.StrokeSize = 5; // Set stroke size

            PathF path = new PathF();
            if (points.Count > 0) {
                path.MoveTo(points[0]);
                for (int i = 1; i < points.Count; i++) {
                    path.LineTo(points[i]);
                }
            }
            canvas.DrawPath(path);
        }
    }
}
