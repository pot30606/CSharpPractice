using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork05_Luwei
{
    public partial class Form1 : Form
    {
        private static List<LuWei> dishes = new List<LuWei>();
        public Form1()
        {
            InitializeComponent();
            CreateDishes();
            SetNumericUpDown();
        }

        private void SetNumericUpDown()
        {
            numericUpDown1.Minimum = 0;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Minimum = 0;
            numericUpDown4.Minimum = 0;
        }

        private static List<LuWei> CreateDishes()
        {
            dishes = new List<LuWei>()
            {
                new LuWei{Name="高麗菜1份",Price=30 },
                new LuWei{Name="豆干2片",Price=15 },
                new LuWei{Name="海帶2片",Price=15 },
                new LuWei{Name="肉片1份",Price=40 }
            };
            return dishes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caculate();
        }

        private void Caculate()
        {
            decimal Total=0;
            Total += numericUpDown1.Value * (decimal)30;
            Total += numericUpDown2.Value * (decimal)15;
            Total += numericUpDown3.Value * (decimal)15;
            Total += numericUpDown4.Value * (decimal)40;
            lb_Total.Text = Total.ToString();
            DisplayChange(Total);
        }

        private void DisplayChange(decimal Total)
        {
            int n = (int)Total / 1000;
            Total = Total - n*1000;
            thousands.Text = n.ToString();

            n = (int)Total / 500;
            Total = Total - n * 500;
            fivehundred.Text = n.ToString();

            n = (int)Total / 100;
            Total = Total - n * 100;
            onehundred.Text = n.ToString();

            n = (int)Total / 50;
            Total = Total - n * 50;
            fifty.Text = n.ToString();

            n = (int)Total / 10;
            Total = Total - n * 10;
            ten.Text = n.ToString();

            n = (int)Total / 5;
            Total = Total - n * 5;
            five.Text = n.ToString();

            n = (int)Total / 1;
            Total = Total - n;
            one.Text = n.ToString();
        }
    }
}
