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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac <= 10)
            {
                this.BackColor = Color.Red; 
            }
            if (sayac > 10 && sayac<=15)
            {
                this.BackColor = Color.Yellow;
            }
            if(sayac>15 && sayac <= 25)
            {
                this.BackColor = Color.Green;
            }
            if(sayac == 25)
            {
                sayac = 0;
            }
        }
    }
}
