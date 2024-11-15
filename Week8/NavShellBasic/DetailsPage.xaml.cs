namespace NavShellBasic;

[QueryProperty(nameof(Name), "name")]
public partial class DetailsPage : ContentPage
{
    public string Name
    { get; set; }

	public DetailsPage()
	{
		InitializeComponent();
	}

    private async void OnBackToHomeClicked(object sender, EventArgs e) {
        // Navigate back to the previous page (HomePage)
        await Shell.Current.GoToAsync("..");
    }

    protected override void OnAppearing() {
        base.OnAppearing();
        NameLbl.Text = Name;
    }
}