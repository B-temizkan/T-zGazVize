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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tuş3_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Show();
            this.Hide();
        }

        private void tuş2_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3();
            af.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
