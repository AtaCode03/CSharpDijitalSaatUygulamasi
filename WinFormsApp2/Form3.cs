using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        int sayac1 = 0;
        int sayac2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            if(sayac == 60)
            {
                sayac1++;
                label2.Text = sayac1.ToString();
                sayac = 0;
                if(sayac1 == 60)
                {
                    sayac2++;
                    label1.Text = sayac2.ToString();
                    if(sayac2 == 24)
                    {
                        sayac = 0;
                        sayac1 = 0;
                        sayac2 = 0;
                    }
                }
            }
        }
    }
}
