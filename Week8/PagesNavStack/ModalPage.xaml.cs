namespace PagesNavStack;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e) {
        await Navigation.PopModalAsync();
    }
}