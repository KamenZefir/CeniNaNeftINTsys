using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeniNaNeftINTsys
{
    public partial class Form1 : Form
    {
        int Neft = 0;
        int Stocks = 0;
        int[,] Choice = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer2.Interval = 250;
            timer1.Enabled = true;

            Random rnd = new Random();
            int Neft = rnd.Next(3);
            int Stocks = rnd.Next(1, 3);

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Choice[i, j] = -1;

            }
            timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Neft = rnd.Next(3);
            Stocks = rnd.Next(3);

            switch (Neft)
            {
                case 0:
                label3.ForeColor = Color.Red;
                label3.Text = "Падает";
                    break;

                case 1:
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Стабильно";
                    break;

                case 2:
                    label3.ForeColor = Color.Green;
                    label3.Text = "Растёт";
                    break;
            }

            switch (Stocks)
            {
                case 0:
                    label4.ForeColor = Color.Red;
                    label4.Text = "Падает";
                    break;

                case 1:
                    label4.ForeColor = Color.Blue;
                    label4.Text = "Стабильно";
                    break;

                case 2:
                    label4.ForeColor = Color.Green;
                    label4.Text = "Растёт";
                    break;
            }
        

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Choice[Neft, Stocks] == -1)
            {
                timer1.Enabled = false;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                label5.Text = "Я не знаю что делать\nВыберите действие";
            }

            if (Choice[Neft, Stocks] == 1)
            {
                label5.Text = "Рекомендуем продавать";
            }

            if (Choice[Neft, Stocks] == 2)
            {
                label5.Text = "Рекомендуем держать";
            }

            if (Choice[Neft, Stocks] == 3)
            {
                label5.Text = "Рекомендуем покупать";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Choice[Neft, Stocks] = 1;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choice[Neft, Stocks] = 2;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Choice[Neft, Stocks] = 3;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            timer1.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
