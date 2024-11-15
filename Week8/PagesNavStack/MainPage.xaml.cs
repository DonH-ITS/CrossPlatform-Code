namespace PagesNavStack
{
    public partial class MainPage : ContentPage
    {

        public MainPage() {
            InitializeComponent();
        }

        private async void ButtonPage2_Clicked(object sender, EventArgs e) {
            if (nameEntry != null) {
                string passing = nameEntry.Text;

                var secondPage = new SecondPage(passing);

                secondPage.DataSentBack += (s, data) =>
                {
                    Animal animal = (Animal)data;
                    // Handle the data received from the second page
                    Label label = new Label();
                    label.Text = "Received Data from Page 2: " + data.Name + " " + data.Type;
                    mainlayout.Add(label);
                };

                await Navigation.PushAsync(secondPage);
            }
        }

        private async void OpenModalPage_Clicked(object sender, EventArgs e) {
            var modalPage = new ModalPage(); // Create your modal page
            await Navigation.PushModalAsync(modalPage, true); // Display the modal page
        }
    }

}
