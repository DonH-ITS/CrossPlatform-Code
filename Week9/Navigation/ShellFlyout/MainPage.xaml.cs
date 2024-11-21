namespace ShellFlyoutSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage() {
            InitializeComponent();
            //this.Title = Shell.Current.CurrentItem.Title;
            lblThing.Text = Shell.Current.CurrentItem.Title;

        }


    }

}
