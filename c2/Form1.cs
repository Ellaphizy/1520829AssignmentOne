using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace c2
{
    public partial class Form1 : Form
    {
        private int lift_status;
        public bool btn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lift_status = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (lift_status == 0)
            {
                lift_status = 1;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("The lift is up");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Top < 300)
            {
                if (btn == true)
                {
                    if (panel2.Width <= 11)
                    {
                        //timer1.Stop();   if you want to click for it to open
                        btn = false;
                    }
                    else
                    {
                        timer2.Stop();
                        panel2.Width = panel2.Width - 1;
                        panel3.Width = panel3.Width - 1;
                        panel3.Left = panel3.Left + 1;

                    }

                }
                else
                {
                    if (panel2.Width >= 138)
                    {
                        timer1.Stop();
                        btn = true;
                    }

                    else
                    {
                        //timer2.Stop();
                        panel2.Width = panel2.Width + 1;
                        panel3.Width = panel3.Width + 1;
                        panel3.Left = panel3.Left - 1;

                        //if ((panel2.Width >= 138) && (panel3.Width <= 150))
                        //{
                        //    timer2.Start();
                        //    Listbox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " Lift Went up");
                        //    timer3.Stop();


                        //}
                    }


                }


            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (PictureBox.Top > 0)
            {

                PictureBox.Top = PictureBox.Top - 5;
                ProgressBar.Top = ProgressBar.Top - 7;

            }
            else if (PictureBox.Top < 300)
            {
                //timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel4.Width <= 11)
                    {
                        //timer1.Stop();   if you want to click for it to open
                        btn = false;
                    }
                    else
                    {
                        timer2.Stop();
                        panel4.Width = panel4.Width - 1;
                        panel5.Width = panel5.Width - 1;
                        panel5.Left = panel5.Left + 1;

                    }
                    //Thread.Sleep(100);

                }
                else
                {
                    if (panel4.Width >= 138)
                    {
                        timer3.Stop();
                        btn = true;
                    }

                    else
                    {

                        panel4.Width = panel4.Width + 1;
                        panel5.Width = panel5.Width + 1;
                        panel5.Left = panel5.Left - 1;

                    }

                }

            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (PictureBox.Top < 290)
            {

                PictureBox.Top = PictureBox.Top + 6;
                ProgressBar2.Top = ProgressBar2.Top + 8;

            }
            else if ((PictureBox.Top > 0))
            {
                timer6.Start();
                //timer1.Stop();
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (lift_status == 1)
            {
                lift_status = 0;
                timer5.Start();
            }
            else
            {
                timer5.Stop();
                MessageBox.Show("The lift is down already");
            }


        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel4.Width <= 11)
                    {
                        //timer1.Stop();   if you want to click for it to open
                        btn = false;
                    }
                    else
                    {
                        timer4.Stop();
                        panel4.Width = panel4.Width - 1;
                        panel5.Width = panel5.Width - 1;
                        panel5.Left = panel5.Left + 1;

                    }


                }
                else
                {
                    //Thread.Sleep(100);

                    if (panel4.Width >= 138)
                    {
                        timer4.Stop();
                        btn = true;
                    }

                    else
                    {
                        //timer2.Stop();

                        panel4.Width = panel4.Width + 1;
                        panel5.Width = panel5.Width + 1;
                        panel5.Left = panel5.Left - 1;

                        if ((panel4.Width >= 138) && (panel5.Width <= 150))
                        {
                            timer4.Start();
                            Listbox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " Lift Went down");
                            timer5.Stop();

                        }
                    }

                }

            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel2.Width <= 11)
                    {
                        //timer1.Stop();   if you want to click for it to open
                        btn = false;
                    }
                    else
                    {
                        timer4.Stop();
                        panel2.Width = panel2.Width - 1;
                        panel3.Width = panel3.Width - 1;
                        panel3.Left = panel3.Left + 1;

                    }

                }
                else
                {
                    //Thread.Sleep(100);

                    if (panel2.Width >= 138)
                    {
                        timer6.Stop();
                        btn = true;
                    }

                    else
                    {

                        panel2.Width = panel2.Width + 1;
                        panel3.Width = panel3.Width + 1;
                        panel3.Left = panel3.Left - 1;

                    }

                }

            }


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            if (panel2.Top < 300)
            {
                if ((panel2.Width >= 138) && (panel3.Width <= 150))
                {
                    timer2.Start();
                    Listbox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " Lift Went up");
                    timer3.Stop();


                }

            }

        }
    }
}
