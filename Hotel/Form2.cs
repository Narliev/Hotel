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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"E:\Koce\CV;;Projects;;Ideas\Projects\C# Forms\Hotel\Rooms.txt");
            info.Text = text;
        }

    }
}
