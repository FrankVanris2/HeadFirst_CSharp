namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;
            Console.WriteLine("testing push");
            List<string> animalEmoji = [
                "🐶", "🐰", 
                "🐱", "😺",
                "🐭", "🐭", 
                "🐹", "🐹",
                "🐰", "🐰",
                "🦊", "🦊",
                "🐻", "🐻",
                "🐼", "🐼",
            ];

            foreach(var buttons in AnimalButtons.Children.OfType<Button>())
            {
                int index = Random.Shared.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                buttons.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }

        private void AnimalButtons_Clicked(object sender, EventArgs e)
        {

        }

    }
}
