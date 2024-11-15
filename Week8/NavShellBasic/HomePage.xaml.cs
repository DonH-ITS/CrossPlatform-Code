namespace NavShellBasic
{
    public partial class HomePage : ContentPage
    {

        public HomePage() {
            InitializeComponent();
        }

        private async void OnGoToDetailsClicked(object sender, EventArgs e) {
            // Navigate to the DetailsPage using the route defined in AppShell.xaml
            await Shell.Current.GoToAsync("details");
        }

        private async void OnGoToDetailsClicked2(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("details?name=John");
        }
    }

}
