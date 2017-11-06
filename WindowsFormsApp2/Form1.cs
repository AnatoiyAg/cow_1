using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  MyCow;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            Text = "Hello Cow!";
            this.BackColor = Color.Aquamarine;
            this.Width = 250;
            this.Height = 250;
            this.Size = new Size(350, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string str = MyCow.Program.CowCounter(n);
            label1.Text = str;
        }
    }
}
