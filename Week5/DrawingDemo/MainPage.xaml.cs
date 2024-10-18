namespace DrawingDemo
{
    public partial class MainPage : ContentPage
    {
        CustomDrawable drawable;
        DynamicDrawable dynamicDrawable;
        SimpleDrawable simpleDrawable;
        List<Point> _strokes;

        public MainPage() {
            InitializeComponent();
            drawable = new CustomDrawable();
            dynamicDrawable = new DynamicDrawable();
            DrawingCanvas.Drawable = drawable;
            DrawingCanvas2.Drawable = dynamicDrawable;

            _strokes = new List<Point>();
            simpleDrawable = new SimpleDrawable(_strokes);
            WritingCanvas.Drawable = simpleDrawable;
        }
        private void DrawingCanvas_StartInteraction(object sender, TouchEventArgs e) {
            _strokes.Add(e.Touches[0]);
            WritingCanvas.Invalidate();
        }

        private void DrawingCanvas_EndInteraction(object sender, TouchEventArgs e) {

        }

        private void DrawingCanvas_DragInteraction(object sender, TouchEventArgs e) {
            _strokes.Add(e.Touches[0]);
            WritingCanvas.Invalidate();
        }
        private void Button_Clicked(object sender, EventArgs e) {
            drawable.Which = 2;
            DrawingCanvas.Invalidate();

            dynamicDrawable.Width = 200;
            DrawingCanvas2.Invalidate();
        }
    }

}
