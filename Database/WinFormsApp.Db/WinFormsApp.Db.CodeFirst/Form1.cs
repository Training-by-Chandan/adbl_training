using System.Linq.Expressions;

namespace WinFormsApp.Db.CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private int num1 = 0, num2 = 0;
        private string ops;
        private int res = 0;

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtResult.Text);
            switch (ops)
            {
                case "+":
                    res = num1 + num2;
                    break;

                case "-":
                    res = num1 - num2;
                    break;

                case "x":
                    res = num1 * num2;
                    break;

                case "/":
                    res = num1 / num2;
                    break;

                default:
                    break;
            }
            txtResult.Text = res.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            ops = btn.Text;
            num1 = Convert.ToInt32(txtResult.Text);
            txtResult.Clear();
        }
    }
}