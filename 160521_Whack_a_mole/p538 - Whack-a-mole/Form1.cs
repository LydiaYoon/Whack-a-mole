using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p538___Whack_a_mole
{
    public partial class Form1 : Form
    {
        Mole mole;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            mole = new Mole(random, new Mole.PopUp(MoleCallBack));
            timer1.Interval = random.Next(500, 750);
            timer1.Start();

            display.Interval = 100;
            display.Start();

            timer3.Interval = 1000;
            timer3.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ToggleMole();
        }
        private void ToggleMole() // 타이머 설정 시간이 경과하면 두더지를 숨기거나 나오게 함
        {
            if (mole.Hidden == true)
                mole.Show();
            else
                mole.HideAgain();
            timer1.Interval = random.Next(500,750);
            timer1.Start();
        }
        private void MoleCallBack(int moleNumber, bool show)
        {
            Label label;

            if (moleNumber < 0)
            {
                timer1.Stop();
                return;
            }
            switch (moleNumber) // 버튼에 따른 색과 텍스트를 변경
            {
                case 0: label = label0; break;
                case 1: label = label1; break;
                case 2: label = label2; break;
                case 3: label = label3; break;
                case 4: label = label4; break;
                case 5: label = label5; break;
                case 6: label = label6; break;
                default: label = label7; break;
            }
            if (show == true)
            {
                label.Image = p538___Whack_a_mole.Properties.Resources.up;
            }
            else if (mole.getHit() == true)
            {
                label.Image = p538___Whack_a_mole.Properties.Resources.click;
            }
            else
            {
                label.Image = p538___Whack_a_mole.Properties.Resources.empty;
            }
            timer1.Interval = random.Next(500, 750);
            timer1.Start();
        }

        private void display_Tick(object sender, EventArgs e)
        {
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        if (i == mole.getHole())
                            break;
                        else
                            label0.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 1:
                        if (i == mole.getHole())
                            break;
                        else
                            label1.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 2:
                        if (i == mole.getHole())
                            break;
                        else
                            label2.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 3:
                        if (i == mole.getHole())
                            break;
                        else
                            label3.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 4:
                        if (i == mole.getHole())
                            break;
                        else
                            label4.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 5:
                        if (i == mole.getHole())
                            break;
                        else
                            label5.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    case 6:
                        if (i == mole.getHole())
                            break;
                        else
                            label6.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;
                    default:
                        if (7 == mole.getHole())
                            break;
                        else
                            label7.Image = p538___Whack_a_mole.Properties.Resources.empty;
                        break;

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 0 && progressBar1.Value < 100)
                progressBar1.Value = progressBar1.Value + 5;
            else if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("You scored " + mole.getScore(), "Game over");
                Application.Exit();
            }
        }

        private void label0_Click(object sender, EventArgs e)
        {
            mole.Smacked(0);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mole.Smacked(1);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mole.Smacked(2);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mole.Smacked(3);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mole.Smacked(4);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            mole.Smacked(5);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            mole.Smacked(6);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mole.Smacked(7);
            score.Text = "" + mole.getScore();
            miss.Text = "" + mole.getMiss();
        }
    }
}