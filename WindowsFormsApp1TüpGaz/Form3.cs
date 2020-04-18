using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1TüpGaz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tuş4_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Show();
            this.Hide();
        }

        private void tuş6_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Show();
            this.Hide();
        }

        private void tuş5_Click(object sender, EventArgs e)
        {
            Form6 af = new Form6();
            af.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
