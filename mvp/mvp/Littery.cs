using mvp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvp
{
    public class Lottery : ILottery
    {
        private double _combinations;

        public double Combinations
        {
            get { return _combinations; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Кількість комбінацій має бути більше 0");
                _combinations = value;
            }
        }

        public double Probability
        {
            get { return 1 / Combinations; }
        }
    }
}
