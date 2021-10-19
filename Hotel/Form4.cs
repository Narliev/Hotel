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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bmake_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Rooms.txt");
            string fname = tfname.Text;
            string lname = tlname.Text;
            string roomlist = troomlist.Text;
            int nights = int.Parse(tnights.Text);
            string date = tdate.Text;
            string hour = thour.Text;
            int price  = int.Parse(tprice.Text);

            string filepath = date + hour + @".txt";
            FileStream fs = File.Create(filepath);
            fs.Close();
            StreamWriter sw = File.AppendText(filepath);
            sw.WriteLine(fname);
            sw.WriteLine(lname);
            sw.WriteLine(roomlist);
            sw.WriteLine(nights);
            sw.WriteLine(price);
            sw.Close();

            string[] line;
            int[,] rooms = new int[lines.Length, 3];
            for (int i = 0; i < lines.Length; i++)
            {
                line = lines[i].Split(' ');
                rooms[i, 0] = int.Parse(line[0]);
                rooms[i, 1] = int.Parse(line[1]);
                rooms[i, 2] = int.Parse(line[2]);
            }
            string[] room = roomlist.Split(' ');
            int[] takenid = new int[room.Length];

            for (int i = 0; i < room.Length; i++)
            {
                takenid[i] = Convert.ToInt32(room[i]);
            }

            StreamWriter sr = new StreamWriter(@"Rooms.txt", false);
            bool flag;
            for (int i = 0; i < rooms.GetLength(0); i++)
            {
                flag = false;
                for (int j = 0; j < takenid.Length; j++)
                {
                    if (flag) break;
                    if (takenid[j] == rooms[i, 0])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    sr.WriteLine(lines[i]);
                }
            }
            sr.Close();
            ldone.Visible = true;
        }

    }
}
