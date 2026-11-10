using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace mvp.Interfaces
{
    public interface ILotteryView
    {
        string CombinationsText { get; }   // що ввів користувач
        string Result { set; }             // куди вивести результат
        void ShowError(string message);
    }
}
