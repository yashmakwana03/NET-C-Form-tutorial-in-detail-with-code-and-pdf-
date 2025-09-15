namespace _23SOECE11059_YASHMAKWANA
{
    public partial class Form1 : Form
    {
        int num1, num2, result;
        string ansString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //take input from user for number 1
            num1 = int.Parse(tb1.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            // take input from user for number 2
            num2 = int.Parse(tb2.Text);
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            // addition operation
            num1 = int.Parse(tb1.Text);
            num2 = int.Parse(tb2.Text);
            result = num1 + num2;
            ansString = num1 + " and " + num2 + " Addition  is " + result;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            //subtraction operation
            num1 = int.Parse(tb1.Text);
            num2 = int.Parse(tb2.Text);
            result = num1 - num2;
            ansString = num1 + " and " + num2 + " Subtraction is " + result;
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            //multiplication operation
            num1 = int.Parse(tb1.Text);
            num2 = int.Parse(tb2.Text);
            result = num1 * num2;
            ansString = num1 + " and " + num2 + " Multiplication is " + result;
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            num1 = int.Parse(tb1.Text);
            num2 = int.Parse(tb2.Text);
            result = num1 / num2;
            ansString = num1 + " and " + num2 + " Division is " + result;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //button clicl show lable answer
            a.Text = ansString;
        }
    }
}
