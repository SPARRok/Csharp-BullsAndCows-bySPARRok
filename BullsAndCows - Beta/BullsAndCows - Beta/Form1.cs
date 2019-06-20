using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows___Beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Desig Page One
            #region
            panel1.BackColor = Color.FromArgb(90, Color.Black);
            pictureBox1.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox3.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox8.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox2.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox5.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox6.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox7.BackColor = Color.FromArgb(0, Color.Black);
            label1.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox4.BackColor = Color.FromArgb(0, Color.Black);
            pictureBox9.BackColor = Color.FromArgb(0, Color.Black);
            label2.BackColor = Color.FromArgb(0, Color.Black);
            label3.BackColor = Color.FromArgb(0, Color.Black);
            label4.BackColor = Color.FromArgb(0, Color.Black);
            Bull1.BackColor = Color.FromArgb(0, Color.Black);
            Bull2.BackColor = Color.FromArgb(0, Color.Black);
            Bull3.BackColor = Color.FromArgb(0, Color.Black);
            Bull4.BackColor = Color.FromArgb(0, Color.Black);
            Cow1.BackColor = Color.FromArgb(0, Color.Black);
            Cow2.BackColor = Color.FromArgb(0, Color.Black);
            Cow3.BackColor = Color.FromArgb(0, Color.Black);
            Cow4.BackColor = Color.FromArgb(0, Color.Black);
            btnOk.BackColor = Color.FromArgb(0, Color.Black);
            lblPoint.BackColor = Color.FromArgb(0, Color.Black);
            label5.BackColor = Color.FromArgb(0, Color.Black);
            label6.BackColor = Color.FromArgb(0, Color.Black);
            btnExit.BackColor = Color.FromArgb(0, Color.Black);
            #endregion
        }


        //Deklarace
        #region
        public int num1, num2, num3, num4;
        public int bull, cow, point;
        string[] data;
        string blabla;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Yellow;
        }


        //Kdyz se vypne aplikace
        #region
        private void Form1_Leave(object sender, EventArgs e)
        {
            //inicializace
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;

            data = new string[]
            {
                num1.ToString(),
                num2.ToString(),
                num3.ToString(),
                num4.ToString(),

            };
            System.IO.File.WriteAllLines("data.txt", data);

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            //Schovat Kravy a Byky
            #region
            Bull1.Hide();
            Bull2.Hide();
            Bull3.Hide();
            Bull4.Hide();
            Cow1.Hide();
            Cow2.Hide();
            Cow3.Hide();
            Cow4.Hide();

            point = 0;
            lblPoint.Text = point.ToString();
            #endregion

            //Generovani
            #region
            //Prvni kroky
            #region
            Random rnd = new Random();
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            #endregion

            //Generovani
            #region
            num1 = rnd.Next(0, 9);
            num2 = rnd.Next(0, 9);
            while (num2 == num1)
            {
                num2 = rnd.Next(0, 9);
            }

            num3 = rnd.Next(0, 9);
            while (num3 == num2 || num3 == num1)
            {
                num3 = rnd.Next(0, 9);
            }

            num4 = rnd.Next(0, 9);
            while (num4 == num3 || num4 == num2 || num4 == num1)
            {
                num4 = rnd.Next(0, 9);
            }

            #endregion

            //Uchovani
            #region
            data = new string[]
            {
                num1.ToString(),
                num2.ToString(),
                num3.ToString(),
                num4.ToString(),

            };
            System.IO.File.WriteAllLines("data.txt", data);

            #endregion
            #endregion
        }

        int i;

        #endregion

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //Schovat Kravy a Byky
            #region
            Bull1.Hide();
            Bull2.Hide();
            Bull3.Hide();
            Bull4.Hide();
            Cow1.Hide();
            Cow2.Hide();
            Cow3.Hide();
            Cow4.Hide();
            #endregion

            //Prijmani dat
            #region
            data = System.IO.File.ReadAllLines("data.txt");
            num1 = Convert.ToInt32(data[0]);
            num2 = Convert.ToInt32(data[1]);
            num3 = Convert.ToInt32(data[2]);
            num4 = Convert.ToInt32(data[3]);



            #endregion

            //Nulovani hodnot
            #region
            bull = 0;
            cow = 0;
            #endregion

            //rozdeleni cisel na cifry
            #region
            int i = Convert.ToInt32(textBox1.Text);

            int a = i / 1000;
            int b = (i - (a * 1000)) / 100;
            int c = ((i - ((a * 1000) + (b * 100)))/10);
            int d = (i - ((a * 1000) + (b * 100) + (c * 10)));
            #endregion

            //Hlavni kod
            #region
            if (a == b || a == c || a == d)
            {
                MessageBox.Show("Zadej různá čísla");
            }
            else
            {
                if (b == a || b == c || b == d)
                {
                    MessageBox.Show("Zadej různá čísla");
                }
                else
                {
                    if (c == d || c == b || c == a)
                    {
                        MessageBox.Show("Zadej různá čísla");
                    }
                    else
                    {
                        //Dalsi
                        #region
                        //Bulls
                        #region
                        if (a == num2 || a == num3 || a == num4)
                        {
                            bull++;
                        }
                        if (b == num1 || b == num3 || b == num4)
                        {
                            bull++;
                        }
                        if (c == num1 || c == num2 || c == num4)
                        {
                            bull++;
                        }
                        if (d == num1 || d == num2 || d == num3)
                        {
                            bull++;
                        }
                        #endregion

                        //Cow
                        #region
                        if (a == num1)
                        {
                            cow++;
                        }
                        if (b == num2)
                        {
                            cow++;
                        }
                        if (c == num3)
                        {
                            cow++;
                        }
                        if (d == num4)
                        {
                            cow++;
                        }
                        #endregion
                        #endregion
                    }
                }
            }
            #endregion

            //Ukaz vysledku
            #region

            //bull
            #region
            if(bull == 1)
            {
                Bull1.Show();
            }
            if (bull == 2)
            {
                Bull1.Show();
                Bull2.Show();
            }
            if (bull == 3)
            {
                Bull1.Show();
                Bull2.Show();
                Bull3.Show();
            }
            if (bull == 4)
            {
                Bull1.Show();
                Bull2.Show();
                Bull3.Show();
                Bull4.Show();
            }
            #endregion

            //cow
            #region
            if (cow == 1)
            {
                Cow1.Show();
            }
            if (cow == 2)
            {
                Cow1.Show();
                Cow2.Show();
            }
            if (cow == 3)
            {
                Cow1.Show();
                Cow2.Show();
                Cow3.Show();
            }
            if (cow == 4)
            {
                Cow1.Show();
                Cow2.Show();
                Cow3.Show();
                Cow4.Show();

                if(point == 1)
                {
                    blabla = "You are lucky! XD";
                }
                else if(point <= 10)
                {
                    blabla = "Very very good! Nice game! xD";
                }
                else if(point >10 && point <= 20 )
                {
                    blabla = "Not bad!";
                }
                else if(point >20)
                {
                    blabla = "May be better.";
                }

                MessageBox.Show("You won! You had " + point.ToString() + " attempts! " +blabla);
            }
            #endregion
            #endregion

            //Points
            #region
            point++;
            lblPoint.Text = point.ToString();
            #endregion
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Prvni kroky
            #region
            Random rnd = new Random();
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            point = 0;
            lblPoint.Text = point.ToString();
            #endregion

            //Generovani
            #region
            num1 = rnd.Next(0, 9);
            num2 = rnd.Next(0, 9);
            while (num2 == num1)
            {
                num2 = rnd.Next(0, 9);
            }

            num3 = rnd.Next(0, 9);
            while (num3 == num2 || num3 == num1)
            {
                num3 = rnd.Next(0, 9);
            }

            num4 = rnd.Next(0, 9);
            while (num4 == num3 || num4 == num2 || num4 == num1)
            {
                num4 = rnd.Next(0, 9);
            }

            #endregion

            //Uchovani
            #region
            data = new string[]
            {
                num1.ToString(),
                num2.ToString(),
                num3.ToString(),
                num4.ToString(),

            };
            System.IO.File.WriteAllLines("data.txt", data);

            #endregion



        }
    }
}
