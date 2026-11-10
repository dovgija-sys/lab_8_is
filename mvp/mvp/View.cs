using mvp.Interfaces;
using System.ComponentModel;

namespace mvp
{
    public partial class View : Form, ILotteryView
    {
        private LotteryPresenter presenter;

        public View()
        {
            InitializeComponent();
            // тут збираємо всі три частини разом
            presenter = new LotteryPresenter(this, new Lottery());
        }

        // реалізація ILotteryView
        public string CombinationsText { get { return textBox1.Text; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Result { set { label2.Text = value; } }
        public void ShowError(string message) { MessageBox.Show(message); }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Calculate();   // форма лише передає керування
        }
    }
}
