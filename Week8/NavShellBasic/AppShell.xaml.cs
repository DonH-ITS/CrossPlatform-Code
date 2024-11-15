namespace NavShellBasic
{
    public partial class AppShell : Shell
    {
        public AppShell() {
            InitializeComponent(); 
            Routing.RegisterRoute("home", typeof(HomePage));
            Routing.RegisterRoute("main", typeof(HomePage));
            Routing.RegisterRoute("details", typeof(DetailsPage));
        }
    }
}
