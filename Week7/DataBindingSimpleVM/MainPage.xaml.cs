namespace DataBindingTests2
{
    public partial class MainPage : ContentPage
    {
        ModelView modelview;

        public MainPage() {
            InitializeComponent();
            modelview = new ModelView();
            BindingContext = modelview;
        }

    }

}
