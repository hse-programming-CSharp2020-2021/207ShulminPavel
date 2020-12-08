using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int old = 0;
        int last = 1;
        string str = "Член ряда Пелла: ";

        private void button1_Click(object sender, EventArgs e)
        {
            if (old > int.MaxValue - 2 * last)
            {
                MessageBox.Show("Произошло переполнение.");
                old = 0;
                last = 1;
            }
            int newEl = old + 2 * last;
            old = last;
            last = newEl;
            label1.Text = str + newEl.ToString();
        }
    }
}
