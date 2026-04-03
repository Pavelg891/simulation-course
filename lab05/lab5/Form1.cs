using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private string[] Answers =
        {
            "Да",
            "Определённо да",
            "Без сомнений",
            "Можешь быть уверен",
            "Скорее всего",
            "Нет",
            "Маловероятно",
            "Не думаю",
            "Определённо нет",
            "Очень сомнительно",
            "Спроси позже",
            "Сейчас нельзя сказать",
            "Ответ неясен",
            "Сконцентрируйся и спроси снова"
        };
        double[] probabilities;
        bool YesNo(double p)
        {
            double value = rnd.NextDouble();
            if (value < p)
                return true;
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            probabilities = new double[Answers.Length];
            for (int i = 0; i < Answers.Length; i++) probabilities[i] = 1.0 / Answers.Length;
        }

        int Magic8Ball()
        {
            double A = rnd.NextDouble();
            for (int k = 0; k < Answers.Length; k++)
            {
                A = A - probabilities[k];
                if (A <= 0) return k;
            }
            return -1;
        }
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            double p = 0.7;
            if (YesNo(p)) labelYesNo.Text = "Да";
            else labelYesNo.Text = "Нет";
        }

        private void buttonMagic8Ball_Click(object sender, EventArgs e)
        {
            int k = Magic8Ball();
            if (k != -1) labelMagic8Ball.Text = Answers[k];
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            int N = 10000;

            int[] statistics = new int[Answers.Length];

            for (int i = 0; i < statistics.Length; i++)
                statistics[i] = 0;

            for (int n = 0; n < N; n++)
            {
                int k = Magic8Ball();
                if (k != -1)
                    statistics[k]++;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"N = {N}");
            sb.AppendLine();
            for (int i = 0; i < Answers.Length; i++)
            {
                double freq = (double)statistics[i] / N;
                sb.AppendLine($"{Answers[i]}: {freq:F4}");
            }
            labelStats.Text = sb.ToString();
        }
    }

}
