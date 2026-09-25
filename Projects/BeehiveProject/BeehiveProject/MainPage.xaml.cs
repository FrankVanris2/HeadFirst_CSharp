namespace BeehiveProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            jobPicker.ItemsSource = new List<string> { "Nectar Collector", "Honey Manufacturer", "Egg Care" };
        }

        private void AssignJobButton_Clicked(object sender, EventArgs e)
        {

        }

        private void WorkShiftButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OutOfHoneyButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
