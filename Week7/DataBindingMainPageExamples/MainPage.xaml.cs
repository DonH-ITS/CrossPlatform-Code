
namespace DataBindingTests
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool isRunning = false;
        public bool IsRunning
        {
            get => isRunning;
            set
            {
                isRunning = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(StartString));
            }
        }

        public string TextShow { get; set; }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }

        private System.Timers.Timer timer;

        private string myText;
        public string MyText
        {
            get
            {
                return myText;
            }
            set
            {
                myText = value;
                OnPropertyChanged();
            }
        }

        public string StartString
        {
            get
            {
                if (!isRunning)
                    return "Start Timer";
                else
                    return "Stop Timer";
            }

        }
      

        public MainPage() {
            MyText = "I'm set in C#";
            BindingContext = this;
            InitializeComponent();
            InitialiseThings();
        }

        private void ChangeText_Clicked(object sender, EventArgs e) {
            MyText = "Change me";
        }

        private void WhatIs_Clicked(object sender, EventArgs e) {
            DisplayAlert("hello", MyText, "ok");
        }

        private void StartTimer_Clicked(object sender, EventArgs e) {
            if(isRunning)
                timer.Stop();
            else
                timer.Start();
            IsRunning = !isRunning;
        }

        private void InitialiseThings() {
            timer = new System.Timers.Timer
            {
                Interval = 1000
            };
            timer.Elapsed += (s, e) =>
            {
                ++Count;
            };

        }


    }

}
