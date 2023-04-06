using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_WF
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Выбор изменить нельзя.\nБудьте внимательны :)");
            Graphics graphics = this.CreateGraphics();
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.BackColor = Color.White;

            label1.Visible = false;
            radioButton17.ForeColor = radioButton1.BackColor;
            radioButton18.ForeColor = radioButton2.BackColor;
            radioButton19.ForeColor = radioButton2.BackColor;
            radioButton20.ForeColor = radioButton2.BackColor;

            progressBar1.Value = 0;
            radioButton33.Checked = true;
            foreach (RadioButton radioButton in this.Controls.OfType<RadioButton>())
            {
                radioButton.Enabled = false;
                radioButton.TabStop = false;
            }
            button1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            radioButton17.ForeColor = Color.Black;
            radioButton18.ForeColor = Color.Black;
            radioButton19.ForeColor = Color.Black;
            radioButton20.ForeColor = Color.Black;

            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.AliceBlue;
            label2.ForeColor = Color.FromArgb(255, 0, 0);

            label2.Text = "00:06";
            timer.Tick -= timer1_Tick;
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutes = int.Parse(label2.Text.Substring(0, 2));
            int seconds = int.Parse(label2.Text.Substring(3, 2));

            int remainingTime = minutes * 60 + seconds;
            remainingTime--;
            label2.Text = string.Format("{0:00}:{1:00}", remainingTime / 60, remainingTime % 60);

            if (remainingTime == 0)
            {
                timer.Stop();
                radioButton17.Enabled = false;
                radioButton18.Enabled = false;
                radioButton19.Enabled = false;
                radioButton20.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Время вышло :(", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if ((radioButton3.Checked && radioButton == radioButton3) || (radioButton6.Checked && radioButton == radioButton6) || (radioButton12.Checked && radioButton == radioButton12) || (radioButton30.Checked && radioButton == radioButton30)
                || (radioButton28.Checked && radioButton == radioButton28) || (radioButton24.Checked && radioButton == radioButton24) || (radioButton13.Checked && radioButton == radioButton13) || (radioButton19.Checked && radioButton == radioButton19))
                progressBar1.Value += 10;

            if (radioButton != null && radioButton.Checked)
            {
                int tagValue = Convert.ToInt32(radioButton.Tag);
                //GroupBox groupBox = null;

                if (tagValue == 1)
                {
                    groupBox1.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 2)
                {
                    groupBox2.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 3)
                {
                    groupBox3.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 5)
                {
                    groupBox8.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 6)
                {
                    groupBox7.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 7)
                {
                    groupBox6.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 9)
                {
                    groupBox9.Enabled = false;
                    button1.Focus();
                    return;
                }
                else if (tagValue == 10)
                {
                    groupBox10.Enabled = false;
                    button1.Focus();
                    return;
                }

                //if (tagValue == 1 && (radioButton3.Checked || radioButton6.Checked || radioButton12.Checked || radioButton30.Checked || radioButton28.Checked || radioButton24.Checked || radioButton13.Checked || radioButton19.Checked))
                //{
                //    progressBar1.Value += 10;
                //}
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }
    }
}