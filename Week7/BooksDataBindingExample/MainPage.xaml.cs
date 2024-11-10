

namespace DataBindingLecture
{
    public partial class MainPage : ContentPage
    {

        BookViewModel bookviewModel;


        public MainPage() {
            InitializeComponent();   


            bookviewModel = new BookViewModel();
            BindingContext = bookviewModel;
        }

        private void Button_Clicked(object sender, EventArgs e) {
            Int32.TryParse(publishedyear.Text, out int year);
            bookviewModel.AddBooks(title.Text, author.Text, year);
        }
    }

}
