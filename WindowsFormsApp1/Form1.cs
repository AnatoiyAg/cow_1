using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = textBox1.Text;
            int n = int.Parse(buf);
            string txt = ConsoleApplication1.Program.CowCounter(n);
            label1.Text = txt;
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
