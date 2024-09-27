namespace MauiApp12
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage() {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e) {
            count++;
            CounterBtn.BackgroundColor = Color.FromRgb(50, 100, 100);
            if (MyActivityIndicator.IsRunning)
                MyActivityIndicator.IsRunning = false;
            else
                MyActivityIndicator.IsRunning = true;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            //MainVerticalStackLayout.FadeTo(0, 2000);
            Label greetingLabel = new Label
            {
                Text = "Welcome to our app!" + count,
                FontSize = 24,
                TextColor = Color.FromRgb(0, 0, 0)
            };
            MainVerticalStackLayout.Add(greetingLabel);
            Button anotherButton = new Button
            {
                Text = "Another Button"
            };
            MainVerticalStackLayout.Add(anotherButton);

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e) {
            Button anotherButton = new Button
            {
                Text = "Another Button"
            };
            MainVerticalStackLayout.Add(anotherButton);
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e) {
            LabelHello.Text = "Hello " + NameEntry.Text;
        }
    }

}
