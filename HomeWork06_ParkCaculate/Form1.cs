using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork06_ParkCaculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = dateTimePicker1.Value;
            end = dateTimePicker2.Value;

            int Price = 0;
            var n =  end-start;
            var min = n.TotalMinutes;
            if (n.TotalHours <= 2) //小於兩小時
            {
                Price = (int)min / 30;
                Price = Price * 30;
            }
            else if (n.TotalHours <= 4)
            {
                Price = (int)min / 30;
                Price = Price * 40;
            }
            else
            {
                Price = (int)min / 30;
                Price = Price * 60;
            }

            lb_price.Text = Price.ToString();
        }
    }
}
