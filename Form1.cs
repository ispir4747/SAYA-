using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAYAÇ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            sayac=sayac +1;
            label1.Text = sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = sayac + 2;
            label2.Text = sayac.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = sayac + 3;
            label3.Text = sayac.ToString();
        }
    }
}
