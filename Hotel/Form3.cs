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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bmake_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Rooms.txt");
            string fname = tfname.Text;
            string lname = tlname.Text;
            int people = int.Parse(tpeople.Text);
            int nights = int.Parse(tnights.Text);
            string date = tdate.Text;
            string hour = thour.Text;
            int price = 0;

            string filepath = date + hour + @".txt";
            FileStream fs = File.Create(filepath);
            fs.Close();
            StreamWriter sw = File.AppendText(filepath);
            sw.WriteLine(fname);
            sw.WriteLine(lname);


            string[,] rooms = new string[lines.Length,3];
            string[] line;
            for (int i = 0; i < lines.Length; i++)
            {
                line = lines[i].Split(' ');
                rooms[i,0] = line[0];
                rooms[i,1] = line[1];
                rooms[i,2] = line[2];
            }

            int freespace = 0;
            for (int i = 0; i < rooms.GetLength(0); i++)
            {
                freespace += int.Parse(rooms[i, 1]);
            }

            string roomlist = "";

            string[] takenid = new string[lines.Length];
            int counter = 0;

            while(people > 0)
            {
                if(people > freespace)
                {
                    ldone.Text = "Not enought room!";
                    ldone.Visible = true;
                    break;
                }
                else if(people > 4)
                {
                    bool found = false;
                    while(!found)
                    {
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if(int.Parse(rooms[i,1])==4)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 4;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 3)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 3;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 2)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 2;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                    }
                }
                else if(people == 4)
                {
                    bool found = false;
                    while (!found)
                    {
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 4)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 4;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 3)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 3;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 2)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 2;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                    }
                }
                else if (people == 3)
                {
                    bool found = false;
                    while (!found)
                    {
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 3)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 3;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 4)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 4;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 2)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 2;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                    }
                }
                else if(people < 3)
                {
                    bool found = false;
                    while (!found)
                    {
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 2)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 2;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 3)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 3;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                        for (int i = 0; i < rooms.GetLength(0); i++)
                        {
                            if (found) break;
                            if (int.Parse(rooms[i, 1]) == 4)
                            {
                                found = true;
                                roomlist += rooms[i, 0] + " ";
                                rooms[i, 1] = "0";
                                price += nights * int.Parse(rooms[i, 2]);
                                people -= 4;
                                takenid[counter] = rooms[i, 0];
                                counter++;
                            }
                        }
                    }
                }
            }

            sw.WriteLine(roomlist);
            StreamWriter sr = new StreamWriter(@"Rooms.txt", false);
            bool flag;
            for (int i = 0; i < rooms.GetLength(0); i++)
            {
                flag = false;
                for (int j = 0; j < counter; j++)
                {
                    if (flag) break;
                    if (takenid[j]==rooms[i,0])
                    {
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    sr.WriteLine(lines[i]);
                }
            }

            sw.WriteLine(nights);
            sw.WriteLine(price);

            sw.Close();
            sr.Close();
            ldone.Visible = true;
        }
    }
}
