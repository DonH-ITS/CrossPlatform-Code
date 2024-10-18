namespace DeviceOrientation
{
    public partial class MainPage : ContentPage
    {
        private System.Timers.Timer timer;
        bool timerStarted = false;
        int timeElapsed = 0, timeDispatchElapsed = 0;
        int interval = 1000;

        IDispatcherTimer timerDispatch;

        public MainPage() {
            InitializeComponent();
            Shell.Current.DisplayAlert("Orientation", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");
            DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;

            this.LayoutChanged += OnWindowChange;
            DisplayAlert("a","width: " + this.Width + "height " + this.Height, "ok");
#if ANDROID
            timerLbl.IsVisible = false;
            timerDispatchlbl.IsVisible = false;
            TimerBtn.IsVisible = false;
            TimerBtn2.IsVisible = false;
            TimerBtn3.IsVisible = false;
            TimerElapsed.IsVisible = false;
#else
            InitTimer();
#endif

        }

        public void InitTimer() {
            timer = new System.Timers.Timer
            {
                Interval = interval
            };
            timer.Elapsed += Timer_Elapsed;


            timerDispatch = Dispatcher.CreateTimer();
            timerDispatch.Interval = TimeSpan.FromMilliseconds(1000);
            timerDispatch.Tick += (s, e) =>
            {
                ++timeDispatchElapsed;
                timerDispatchlbl.Text = "Dispatch Timer Elapsed " + timeDispatchElapsed;
            };
        }

        private void Timer_Elapsed(object? sender, EventArgs e) {
            ++timeElapsed;
            timerLbl.Text = "Time is now " + timeElapsed;
        }


        private void OnWindowChange(object sender, EventArgs e) {
            widthDisplay.Text = "Width : " + this.Width;
            heightDisplay.Text = "Height : " + this.Height;
        }

        private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e) {
            DisplayAlert("Orientation", $"Current Orientation: {DeviceDisplay.Current.MainDisplayInfo.Orientation}", "Ok");
        }

        private void OnCounterClicked(object sender, EventArgs e) {
            Shell.Current.DisplayAlert("Orientation", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e) {
            Shell.Current.DisplayAlert("Dimensions", "Height: " + DeviceDisplay.Current.MainDisplayInfo.Height + " Width: " + DeviceDisplay.Current.MainDisplayInfo.Width, "Ok");
        }


        protected override void OnSizeAllocated(double width, double height) {
            base.OnSizeAllocated(width, height);
            outputLbl.Text = "hello " + this.Width;
        }

        protected override void OnDisappearing() {
            base.OnDisappearing();
        }

        protected override void OnAppearing() {
            base.OnAppearing();
        }

        private void Button_Clicked_1(object sender, EventArgs e) {
#if WINDOWS
                this.Window.Width = 600;
                this.Window.Height = 600;
#elif ANDROID
            Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
#endif
        }

        private void TimerBtn_Clicked(object sender, EventArgs e) {
            if (timerStarted) {
                timer.Stop();
                timerStarted = false;
                ((Button)sender).Text = "Timer went for " + timeElapsed + " seconds";
                
            }
            else {
                timerStarted = true;
                timeElapsed = 0;
                timer.Start();
                timerLbl.Text = "Time is now " + timeElapsed;
            }
            
        }

        private void TimerBtn2_Clicked(object sender, EventArgs e) {
            if (timerStarted) {
                timer.Stop();
                timerStarted = false;
                ((Button)sender).Text = "Timer went for " + timeElapsed + " seconds";
            }
            else {
                timerStarted = true;
                timeElapsed = 0;
                timer.Elapsed -= Timer_Elapsed;
                timer.Start();
                timer.Elapsed += Timer2_Elapsed;
                timerLbl.Text = "Time is now " + timeElapsed;
            }

        }

        private void Timer2_Elapsed(object? sender, EventArgs e) {
            ++timeElapsed;
            
            Dispatcher.Dispatch(
            () =>
            {
                timerLbl.Text = "Time is now " + timeElapsed;
            }
            );

        }

        private void DispatchTimerBtn_Clicked(object sender, EventArgs e) {
            if (timerStarted) {
                timerStarted = false;
                timerDispatch.Stop();
                timerDispatchlbl.Text = "dispatch timer stopped " + timeDispatchElapsed;
            }
            else {
                timerStarted = true;
                timeDispatchElapsed = 0;
                timerDispatch.Start();
                timerDispatchlbl.Text = "Dispatch Timer Started";
            }
        }



       private async void Button_Clicked_2(object sender, EventArgs e) {
            await DisplayAlert("ok", "Time Elapsed is " + timeElapsed, "ok");
        }
    }

}
