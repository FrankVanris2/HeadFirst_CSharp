using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MAUITestingEnvironment
{
    class Moods : INotifyPropertyChanged
    {
        public string CurrentMood { get; private set; } = "I'm happy!";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public void UpdateMood()
        {
            switch (Random.Shared.Next(1, 4))
            {
                case 1:
                    CurrentMood = "I'm happy !";
                    break;

                case 2:
                    CurrentMood = "Oh so sad.";
                    break;

                case 3:
                    CurrentMood = "Feeling good.";
                    break;
            }

            SemanticScreenReader.Announce(CurrentMood);
            OnPropertyChanged("CurrentMood");
        }
    }
}
