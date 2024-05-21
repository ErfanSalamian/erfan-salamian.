using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erfan.salamian
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x, y, z;
            x = textBox1.Text;
            y = textBox2.Text;
            z = x + ',' + y + ',';
            File.AppendAllText("321.csv", z + "\n");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
