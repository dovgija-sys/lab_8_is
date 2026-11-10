using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace mvvm
{
    public class MainVM : INotifyPropertyChanged
    {
        private double _combinations;

        // сюди Binding записує те, що ввів користувач
        public double Combinations
        {
            get { return _combinations; }
            set
            {
                _combinations = value;
                OnPropertyChanged("Combinations");
                OnPropertyChanged("Probability"); // повідомляємо, що результат змінився
                OnPropertyChanged("Percent");
            }
        }

        // властивість лише для читання, View зчитує її щоразу при зміні Combinations
        public string Probability
        {
            get
            {
                if (Combinations <= 0) return "Введіть число більше 0";
                var lottery = new Lottery(Combinations);
                return lottery.Probability.ToString("0.##########");
            }
        }

        public string Percent
        {
            get
            {
                if (Combinations <= 0) return "";
                var lottery = new Lottery(Combinations);
                return (lottery.Probability * 100).ToString("0.########") + " %";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
