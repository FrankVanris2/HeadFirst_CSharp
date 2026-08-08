using PickRandomCards;

namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsButton_Clicked(object sender, EventArgs e)
        {
            

            if(int.TryParse(NumberOfCards.Text, out int numOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numOfCards);
                PickedCards.Text = String.Empty;
                foreach (var card in pickedCards)
                {
                    PickedCards.Text += card + Environment.NewLine;
                }

                PickedCards.Text += Environment.NewLine + " You picked " + numOfCards + " cards.";
            } else
            {
                PickedCards.Text = "Please enter a valid number.";
            }
        }
    }
}
