using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19331613LibraryTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Replacing replacing = new Replacing();
            replacing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identify identify = new Identify();
            identify.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CallNumbers call = new CallNumbers();
            call.Show();
        }
    }
}
