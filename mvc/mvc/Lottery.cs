using System;
using System.Collections.Generic;
using System.Text;

namespace mvc
{
    public class Lottery
    {
        public double Combinations { get; }
        public Lottery(double combinations)
        {
            if (combinations <= 0)
                throw new ArgumentException("Кількість комбінацій має бути більше 0");
            Combinations = combinations;
        }
        // Імовірність виграшу = 1 / Кількість можливих комбінацій
        public double Probability
        {
            get { return 1 / Combinations; }
        }
    }
}
