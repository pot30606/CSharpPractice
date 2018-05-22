using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork04_Transport.models;

namespace HomeWork04_Transport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetNorthToSouth();
            startComboBox.SelectedIndexChanged += StartComboBox_SelectedIndexChanged;
        }

        //當選擇combobox時
        private void StartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toNorthRadioButton.Checked) //北上
            {
                //取得選擇的combobox地點 地點
                var startplace = startComboBox.SelectedItem.ToString();
                //                                   先找到終點等於起點(北上)
                endComboBox.DataSource = tickets.Where((x) => x.Endstation == startplace).Select((x) => x.Startstation).ToList();
            }
            if (toSouthRadioButton.Checked) //南下
            {
                //取得選擇的combobox地點 起點
                var startplace = startComboBox.SelectedItem.ToString();
                endComboBox.DataSource = tickets.Where((x) => x.Startstation == startplace).Select((x) => x.Endstation).ToList();
            }
        }



        private void toSouthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetNorthToSouth();
        }

        private void SetSouthToNorth()
        {
            var list = tickets.Distinct(new Implement());
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            foreach (var i in list)
            {
                start.Add(i.Startstation);
                end.Add(i.Endstation);
            }
            endComboBox.DataSource = start;
            startComboBox.DataSource = end;
        }

        private void toNorthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSouthToNorth();
        }

        private void SetNorthToSouth()
        {
            var list = tickets.Distinct(new Implement());
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            foreach (var i in list)
            {
                start.Add(i.Startstation);
                end.Add(i.Endstation);
            }
            startComboBox.DataSource = start;
            endComboBox.DataSource = end;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = startComboBox.SelectedItem.ToString();
            string end = endComboBox.SelectedItem.ToString();

            TicketPrice result = new TicketPrice();
            if (toSouthRadioButton.Checked)
            {
                result = tickets.Find((x) => x.Startstation == start && x.Endstation == end);
            }
            if (toNorthRadioButton.Checked)
            {
                result = tickets.Find((x) => x.Startstation == end && x.Endstation == start);
            }

            decimal total = (decimal)result.Price;
            if (checkBox1.Checked)
            {
                 total =  total * (decimal)0.9;
            }
            if (checkBox2.Checked)
            {
                total = total * (decimal)0.9;
            }

            label4.Text = ((int)total).ToString();
        }


        private List<TicketPrice> tickets = new List<TicketPrice>()
        {
                new TicketPrice{Startstation = "台北", Endstation = "新竹", Price = 177},
                new TicketPrice{Startstation = "台北", Endstation = "台中", Price = 375},
                new TicketPrice{Startstation = "台北", Endstation = "嘉義", Price = 598},
                new TicketPrice{Startstation = "台北", Endstation = "台南", Price = 738},
                new TicketPrice{Startstation = "台北", Endstation = "高雄", Price = 842},
                new TicketPrice{Startstation = "新竹", Endstation = "台中", Price = 197},
                new TicketPrice{Startstation = "新竹", Endstation = "嘉義", Price = 421},
                new TicketPrice{Startstation = "新竹", Endstation = "台南", Price = 560},
                new TicketPrice{Startstation = "新竹", Endstation = "高雄", Price = 755},
                new TicketPrice{Startstation = "台中", Endstation = "嘉義", Price = 224},
                new TicketPrice{Startstation = "台中", Endstation = "台南", Price = 363},
                new TicketPrice{Startstation = "台中", Endstation = "高雄", Price = 469},
                new TicketPrice{Startstation = "嘉義", Endstation = "台南", Price = 139},
                new TicketPrice{Startstation = "嘉義", Endstation = "高雄", Price = 245},
                new TicketPrice{Startstation = "台南", Endstation = "高雄", Price = 106}
        };
    }
}
