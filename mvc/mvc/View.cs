namespace mvc
{
    public partial class View : Form
    {
        // View знає про Controller
        LotteryController controller = new LotteryController();

        public View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var k = Convert.ToDouble(textBox1.Text);
                var p = controller.Question(k);
                label2.Text = "P = " + p.ToString("0.##########") +
                              " (" + (p * 100).ToString("0.########") + " %)";
            }
            catch { MessageBox.Show("Помилка введення"); }
        }
    }
}
