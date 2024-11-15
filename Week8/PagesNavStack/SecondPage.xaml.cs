namespace PagesNavStack;

public partial class SecondPage : ContentPage
{
    private Animal animal;
    public event EventHandler<Animal> DataSentBack;
    public SecondPage(string passed) {
        InitializeComponent();
        namelbl.Text = "Hello " + passed;
        animal = new Animal("Wolfie", "Dog");
    }

    private async void OnBackButtonClicked(object sender, System.EventArgs e) {
        // Navigate back to the first page
        DataSentBack?.Invoke(this, animal);
        await Navigation.PopAsync();
    }

    protected override bool OnBackButtonPressed() {
        DataSentBack?.Invoke(this, animal);
        return base.OnBackButtonPressed();
    }
}