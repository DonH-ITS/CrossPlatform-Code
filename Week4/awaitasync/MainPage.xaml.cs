namespace AwaitAsyncApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {
            InitializeComponent();
        }

        private void SyncBtn_Clicked(object sender, EventArgs e) {
            var t = Task.Delay(6000);
            t.Wait();
            lblupd.Text = "I was updated by the Sync Method";
        }

        private async void ASyncBtn_Clicked(object sender, EventArgs e) {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            await Task.Delay(6000);
            lblupd.Text = "Updated by Asynchronous Method";
            btn.IsEnabled = true;
        }
        private async void Button_Clicked(object sender, EventArgs e) {
            await DisplayAlert("Alert", "You have been alerted", "OK");

            string result = await DisplayPromptAsync("Question 1", "What's your name?");

            if(result != null) 
                await DisplayAlert("Alert", "Hello " + result, "OK");
            else 
                await DisplayAlert("Alert", "Why you no give name", "OK");
        }
    }

}
