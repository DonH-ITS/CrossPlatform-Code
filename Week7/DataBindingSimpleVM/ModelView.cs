using System.ComponentModel;

namespace DataBindingTests2
{
    public class ModelView : INotifyPropertyChanged
    {
        private int count;
        private System.Timers.Timer timer;
        private bool isRunning = false;
        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
            set
            {
                isRunning = value;
                OnPropertyChanged(nameof(StartStop));
            }
        }

        public Command StartTimerCommand { get; }


        public string StartStop
        {
            get
            {
                if (isRunning)
                    return "Stop Timer";
                else
                    return "Start Timer";
            }
        }
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

        public ModelView() {
            timer = new System.Timers.Timer
            {
                Interval = 1000
            };
            timer.Elapsed += (s, e) =>
            {
                ++Count;
            };
            StartTimerCommand = new Command(() =>
            {
                if (isRunning)
                    timer.Stop();
                else
                    timer.Start();
                IsRunning = !isRunning;
            });
        }


        protected virtual void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
