using System;
using System.IO;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Rooms.txt");
            string roomlist = troomlist.Text;
            string date = tdate.Text;
            string hour = thour.Text;

            string filepath = date + hour + @".txt";
            File.Delete(filepath);

            string[] room = roomlist.Split(' ');
            int[] takenid = new int[room.Length];

            for (int i = 0; i < room.Length; i++)
            {
                takenid[i] = Convert.ToInt32(room[i]);
            }

            string add;
            StreamWriter sr = new StreamWriter(@"Rooms.txt", true);
            for (int i = 0; i < takenid.Length; i++)
            {
                if (takenid[i]%10==1 || takenid[i]%10==6)
                {
                    add = takenid[i] + " " + 4 + " " + 100;
                    sr.WriteLine(add);
                }
                else if(takenid[i] % 10 == 2 || takenid[i] % 10 == 5)
                {
                    add = takenid[i] + " " + 3 + " " + 65;
                    sr.WriteLine(add);
                }
                else
                {
                    add = takenid[i] + " " + 2 + " " + 40;
                    sr.WriteLine(add);
                }
            }
            
            sr.Close();
            ldone.Visible = true;
        }
    }
}
