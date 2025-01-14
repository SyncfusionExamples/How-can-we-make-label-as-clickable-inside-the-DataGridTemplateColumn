namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            var customerName = (sender as Label).Text;
            DisplayAlert("Customer Name", $"Name : {customerName}", "ok");
        }
    }
}
