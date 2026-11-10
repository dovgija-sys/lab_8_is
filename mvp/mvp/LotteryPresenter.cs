using mvp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvp
{
    public class LotteryPresenter
    {
        private readonly ILotteryView view;
        private readonly ILottery model;

        public LotteryPresenter(ILotteryView view, ILottery model)
        {
            this.view = view;
            this.model = model;
        }

        public void Calculate()
        {
            double k;
            if (!double.TryParse(view.CombinationsText, out k))
            {
                view.ShowError("Помилка введення");
                return;
            }
            try
            {
                model.Combinations = k;
                double p = model.Probability;
                view.Result = "P = " + p.ToString("0.##########") +
                              " (" + (p * 100).ToString("0.########") + " %)";
            }
            catch (ArgumentException ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
