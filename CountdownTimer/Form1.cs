using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            timeLeft.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
        }
        private int gio;
        private int phut;
        private int giay;
        SoundPlayer player = new SoundPlayer(Properties.Resources.beep_061);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                numAlert.Visible = true;
            else
                numAlert.Visible = false;
        }

        private void btBatdau_Click(object sender, EventArgs e)
        {
            if (numAlert.Visible == true && numAlert.Value == 0)
            {
                MessageBox.Show("Em chưa nhập thời gian chờ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (numPhut.Value < 1)
            {
                MessageBox.Show("Em chưa chọn thời gian!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gio = (int)numGio.Value;
                phut = (int)numPhut.Value;

                timer2.Start();
                btBatdau.Enabled = false;
                btHuy.Enabled = true;
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private string formatHour(int s)
        {
            string t = s.ToString();
            return s < 10 ? "0" + t : t;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gio > 0 || phut > 0 || giay > 0)
            {
                if (phut == 0 && gio > 0)
                {
                    phut = 59; gio = gio - 1;
                }
                if (giay == 0 && phut > 0)
                {
                    giay = 60; phut = phut - 1;
                }
                giay = giay - 1;
            }
            numGio.Value = gio;
            numPhut.Value = phut;
            timeLeft.Text = string.Format("{0}:{1}:{2}", formatHour(gio), formatHour(phut), formatHour(giay));

            if (checkBox1.Checked)
            {
                if (phut == numAlert.Value && giay == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        player.Play();
                        Thread.Sleep(1000);
                    }
                    string msg = string.Format("Còn lại {0} phút hết giờ.", phut);
                    MessageBox.Show(msg, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (gio == 0 && phut == 0 && giay == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }
                timer2.Stop();
                player.Stop();
                btBatdau.Enabled = true;
                btHuy.Enabled = false;
            }
        }

        private void numAlert_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
