using System.ComponentModel;

namespace DataBindingLecture
{
    
    public class MyViewModel : INotifyPropertyChanged
    {
        public string myText = string.Empty;
        public string MyText
        {
            get => myText;
            set
            {
                myText = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
