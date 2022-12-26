namespace NEW_JOB
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string all = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Ans.Text = this.Ans.Text + "1";
            this.Ans2.Text = this.Ans2.Text + "1";
        }

        private void BMN_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Ans.Text);
            this.Ans.Text = "";
            this.all = "-";

            this.Ans.Text = this.Ans2.Text + " - ";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "9";
            this.Ans2.Text = this.Ans2.Text + "9";
        }

        private void B2_Click(object sender, EventArgs e)
        {

            this.Ans.Text = this.Ans.Text + "2";
            this.Ans2.Text = this.Ans2.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "3";
            this.Ans2.Text = this.Ans2.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "4";
            this.Ans2.Text = this.Ans2.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "5";
            this.Ans2.Text = this.Ans2.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "6";
            this.Ans2.Text = this.Ans2.Text + "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "7";
            this.Ans2.Text = this.Ans2.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "8";
            this.Ans2.Text = this.Ans2.Text + "8";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + "0";
            this.Ans2.Text = this.Ans2.Text + "0";
        }

        private void BP_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Ans.Text);
            this.Ans.Text = "";
            this.all = "+";

            this.Ans2.Text = this.Ans2.Text + " + ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double input2 = double.Parse(this.Ans.Text);
            double result = 0;
            if (this.all == "+")
            {
                result = input1 + input2;
            }
            else if (this.all == "-")
            {
                result = input1 - input2;
            }
            else if (this.all == "*")
            {
                result = input1 * input2;
            }
            else if (this.all == "/")
            {
                result = input1 / input2;
            }
            this.Ans.Text = result.ToString("N0");
        }

        private void BH_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Ans.Text);
            this.Ans.Text = "";
            this.all = "/";

            this.Ans2.Text = this.Ans2.Text + " / ";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BX_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Ans.Text);
            this.Ans.Text = "";
            this.all = "*";

            this.Ans2.Text = this.Ans2.Text + " x ";
        }

        private void BBBB_Click(object sender, EventArgs e)
        {
            this.Ans.Text = this.Ans.Text + ".";
            this.Ans2.Text = this.Ans2.Text + ".";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double input1 = 0;
            double input2 = 0;
            this.Ans.Text = "";
            this.Ans2.Text = "";

        }
    }
}