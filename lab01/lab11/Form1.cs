using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy, maxheight;

        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            timer1.Stop();
            x = 0;
            y = numericUpDownHeight.Value;
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                t = 0;
                x = 0;
                y = numericUpDownHeight.Value;
                maxheight = y;
                v0 = numericUpDownSpeed.Value;
                double a = (double)numericUpDownAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = numericUpDownSize.Value;
                m = numericUpDownWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[0].Points.AddXY(x, y);
                timer1.Start();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += numericUpDowndt.Value;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * numericUpDowndt.Value;
            vy = vy - (g + k * vy * v) * numericUpDowndt.Value;
            x = x + vx * numericUpDowndt.Value;
            y = y + vy * numericUpDowndt.Value;
            if (y > maxheight) maxheight = y;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                chart1.Series[0].Points.AddXY(double.NaN, double.NaN);
                dataGridView1.Rows.Add(numericUpDowndt.Value, Math.Round(x, 8), Math.Round(maxheight, 8), Math.Round(v, 8));
            }
        }
    }
}
