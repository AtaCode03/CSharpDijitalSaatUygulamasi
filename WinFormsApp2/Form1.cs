using System.Numerics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int total = 0;
            for (int i = 1; i < sayi; i++)
            {
                if(i % 2 == 0)
                {
                    total += i;
                }
            }
            label2.Text = total.ToString();
        }
    }
}
