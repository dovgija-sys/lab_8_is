using System;
using System.Collections.Generic;
using System.Text;

namespace mvc
{
    public class LotteryController
    {
        public double Question(double combinations)
        {
            var lottery = new Lottery(combinations);
            return lottery.Probability;
        }
    }
}
