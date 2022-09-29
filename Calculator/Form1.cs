namespace Calculator
{
    public partial class Form1 : Form
    {
        private string? sign;
        private List<int> values = new List<int>();

        public Form1()
        {
            InitializeComponent();
            CalcTxt.Text = "";
        }

        #region numbers

        private void button1_Click(object sender, EventArgs e)
            => CalcTxt.Text += "1";
        private void button2_Click(object sender, EventArgs e)
            => CalcTxt.Text += "2";
        private void button3_Click(object sender, EventArgs e)
            => CalcTxt.Text += "3";
        private void button11_Click(object sender, EventArgs e)
            => CalcTxt.Text += "4";
        private void button10_Click(object sender, EventArgs e)
            => CalcTxt.Text += "5";
        private void button9_Click(object sender, EventArgs e) 
            => CalcTxt.Text += "6";
        private void button14_Click(object sender, EventArgs e)
            => CalcTxt.Text += "7";
        private void button13_Click(object sender, EventArgs e)
            => CalcTxt.Text += "8";
        private void button12_Click(object sender, EventArgs e)
            => CalcTxt.Text += "9";
        #endregion


        private void button4_Click(object sender, EventArgs e)
        {
            sign = "+";
            values.Add(Int32.Parse(CalcTxt.Text));

            CalcTxt.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sign = "-";
            values.Add(Int32.Parse(CalcTxt.Text));

            CalcTxt.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sign = "*";
            values.Add(Int32.Parse(CalcTxt.Text));

            CalcTxt.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sign = "/";
            values.Add(Int32.Parse(CalcTxt.Text));
            CalcTxt.Text = "";
        }


        private void CalcItButton_Click(object sender, EventArgs e)
        {
            values.Add(Int32.Parse(CalcTxt.Text));

            int sum = 0;
            if (sign == "+")
            {
                foreach (var item in values)
                {
                    sum += item;
                }
                CalcTxt.Text = sum.ToString();
            }
            else if(sign == "-")
            {
                sum = values[0] - values[1];
                CalcTxt.Text = sum.ToString();
            }
            else if (sign == "*")
            {
                sum = 1;
                foreach (var item in values)
                {
                    sum *= item;
                }
                CalcTxt.Text = sum.ToString();
            }
            else if (sign == "/")
            {
                sum = values[0] / values[1];

                CalcTxt.Text = sum.ToString();
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            values.Clear();
            CalcTxt.Text = "";
        }
    }
}