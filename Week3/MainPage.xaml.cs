using System.Diagnostics;

namespace PressandRelease
{
    public partial class MainPage : ContentPage
    {
        IDispatcherTimer timer;
        int timeElapsed = 0;
        bool tapGesture = false;

        public MainPage() {
            InitializeComponent();
            timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += (s, e) =>
            {
                label.RotationX = 360 * timeElapsed / 1000.0;
                timeElapsed += 100;
            };
        }

        void OnButtonPressed(object sender, EventArgs args) {
            Button theButn = (Button)sender;
            theButn.BackgroundColor = Color.FromRgb(200, 10, 10);
            timer.Start();
        }

        void OnButtonReleased(object sender, EventArgs args) {
            Button theButn = (Button)sender;
            theButn.BackgroundColor = Colors.BlueViolet;
            lblTimer.Text = "Button has been held down for " + timeElapsed / 1000.0 + "seconds";
            timer.Stop();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e) {
            Entry entry = (Entry)sender;
            lblEntryChange.Text = "My name is " + entry.Text;
        }

        private void Entry_Completed(object sender, EventArgs e) {
            Entry entry = (Entry)sender;
            lblEntryFinished.Text = "Finished Entry " + entry.Text;
        }

        private void OnSwipeGesture(object sender, SwipedEventArgs e) {
            BoxView swipedLabel = (BoxView)sender; 
            LblWork.Text = $"Swiped {e.Direction} on box";
        }

        private void btnWhichPlatform_Clicked(object sender, EventArgs e) {
            LblWork.Text = DeviceInfo.Current.Platform.ToString();
            if (!tapGesture) {
                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += OnImageTapped;
                imgBot.GestureRecognizers.Add(tapGestureRecognizer);
            }
        }

        private void OnImageTapped(object sender, EventArgs e) {
            DisplayAlert("You have tapped the image", "img tap", "OK");
        }

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e) {

        }
    }
}
