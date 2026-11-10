using System;
using System.Collections.Generic;
using System.Text;

namespace mvp.Interfaces
{
    public interface ILottery
    {
        double Combinations { get; set; }
        double Probability { get; }
    }
}
