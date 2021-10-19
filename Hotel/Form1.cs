using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bfree_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void bmake_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void bmanual_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
    }
}
