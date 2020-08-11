using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
   
    public partial class Form1 : Form
    {
        int n1 = 0, n2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = 1;

        }
    }
}
