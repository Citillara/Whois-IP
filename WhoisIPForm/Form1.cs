using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhoisIPForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> intList;

        private void button1_Click(object sender, EventArgs e)
        {
            intList = new List<int>(5);
            intList.Add(0);
            intList.Add(0);
            intList.Add(0);
            intList.Add(0);
            intList.Add(0);

            string data;
            data = WhoisIP.Query(textBoxIP.Text, "whois.ripe.net");
            data = data.Replace("\n", "\r\n");
            textBoxRIPE.Text = data;
            TryFind(data);
            data = WhoisIP.Query(textBoxIP.Text, "whois.arin.net");
            data = data.Replace("\n", "\r\n");
            textBoxARIN.Text = data;
            TryFind(data);
            data = WhoisIP.Query(textBoxIP.Text, "whois.apnic.net");
            data = data.Replace("\n", "\r\n");
            textBoxAPNIC.Text = data;
            TryFind(data);
            data = WhoisIP.Query(textBoxIP.Text, "whois.lacnic.net");
            data = data.Replace("\n", "\r\n");
            textBoxLACNIC.Text = data;
            TryFind(data);
            data = WhoisIP.Query(textBoxIP.Text, "whois.afrinic.net");
            data = data.Replace("\n", "\r\n");
            textBoxAfriNIC.Text = data;

            int indexMax
                        = !intList.Any() ? -1 :
                        intList
                        .Select((value, index) => new { Value = value, Index = index })
                        .Aggregate((a, b) => (a.Value > b.Value) ? a : b)
                        .Index;
            switch (indexMax)
            {
                case 0: 
                    textBoxRIPE.BackColor = Color.LightYellow;
                    textBoxARIN.BackColor = Color.White;
                    textBoxAPNIC.BackColor = Color.White;
                    textBoxLACNIC.BackColor = Color.White;
                    textBoxAfriNIC.BackColor = Color.White;
                    break;
                case 1:
                    textBoxRIPE.BackColor = Color.White;
                    textBoxARIN.BackColor = Color.LightYellow;
                    textBoxAPNIC.BackColor = Color.White;
                    textBoxLACNIC.BackColor = Color.White;
                    textBoxAfriNIC.BackColor = Color.White;
                    break;
                case 2:
                    textBoxRIPE.BackColor = Color.White;
                    textBoxARIN.BackColor = Color.White;
                    textBoxAPNIC.BackColor = Color.LightYellow;
                    textBoxLACNIC.BackColor = Color.White;
                    textBoxAfriNIC.BackColor = Color.White;
                    break;
                case 3:
                    textBoxRIPE.BackColor = Color.White;
                    textBoxARIN.BackColor = Color.White;
                    textBoxAPNIC.BackColor = Color.White;
                    textBoxLACNIC.BackColor = Color.LightYellow;
                    textBoxAfriNIC.BackColor = Color.White;
                    break;
                case 4:
                    textBoxRIPE.BackColor = Color.White;
                    textBoxARIN.BackColor = Color.White;
                    textBoxAPNIC.BackColor = Color.White;
                    textBoxLACNIC.BackColor = Color.White;
                    textBoxAfriNIC.BackColor = Color.LightYellow;
                    break;
                default:
                    textBoxRIPE.BackColor = Color.White;
                    textBoxARIN.BackColor = Color.White;
                    textBoxAPNIC.BackColor = Color.White;
                    textBoxLACNIC.BackColor = Color.White;
                    textBoxAfriNIC.BackColor = Color.White;
                    break;
            }
            
        }


        private void TryFind(string text)
        {
            if (text.Contains("RIPE"))
            {
                intList[0]++;
            }
            else if (text.Contains("ARIN"))
            {
                intList[1]++;
            }
            else if (text.Contains("APNIC"))
            {
                intList[2]++;
            }
            else if (text.Contains("LACNIC"))
            {
                intList[3]++;
            }
            else if (text.Contains("AFRINIC"))
            {
                intList[4]++;
            }
        }
    }
}
