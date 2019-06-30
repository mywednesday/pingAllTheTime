using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        uint iStartip = 0;
        uint iEndIp = 0;
        int timeout = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            if (!ipCheck(ipStartTextBox.Text.Trim()))
            {
                MessageBox.Show("Start ip format error!");
                return;
            }
            if (!ipCheck(ipEndTextBox.Text.Trim()))
            {
                MessageBox.Show("End ip format error!");
                return;
            }
            if (!int.TryParse(timeoutTextBox.Text.Trim(), out timeout))
            {
                MessageBox.Show("Timeout setting error!");
                return;
            }
            
            outputTextBox.Text = "";
            
            
            iStartip = ipTint(ipStartTextBox.Text.Trim());
            iEndIp = ipTint(ipEndTextBox.Text.Trim());
            if (iEndIp < iStartip)
            {
                MessageBox.Show("Error: Start ip > End ip");
                return;
            }

            ThreadStart threadStart = new ThreadStart(pingAllIps);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
        }

        private async void pingAllIps()
        {            
            this.BeginInvoke(new Action(() =>
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = (int)(iEndIp - iStartip + 1);
                progressBar.Value = 0;
            }));
            Ping ping = new Ping();
            for (uint ip = iStartip; ip <= iEndIp; ip++)
            {
                string ipStr = intTip(ip);
                this.BeginInvoke(new Action(() =>
                {
                    outputTextBox.Text += ("ping       " + ipStr);
                }));

                PingReply reply = await ping.SendPingAsync(ipStr, timeout);



                this.BeginInvoke(new Action(() =>
                {
                    outputTextBox.Text += ("       " + reply.Status.ToString() + "\r\n");
                    progressBar.Value += 1;
                }));
                
            }

            this.BeginInvoke(new Action(() =>
            {
                outputTextBox.Text += "完成";
            }));
        }


        public static uint ipTint(string ipStr)
        {
            string[] ip = ipStr.Split('.');
            uint ipcode = 0xFFFFFF00 | byte.Parse(ip[3]);
            ipcode = ipcode & 0xFFFF00FF | (uint.Parse(ip[2]) << 0x8);
            ipcode = ipcode & 0xFF00FFFF | (uint.Parse(ip[1]) << 0xF);
            ipcode = ipcode & 0x00FFFFFF | (uint.Parse(ip[0]) << 0x18);
            return ipcode;
        }

        public static string intTip(uint ipcode)
        {
            byte a = (byte)((ipcode & 0xFF000000) >> 0x18);
            byte b = (byte)((ipcode & 0x00FF0000) >> 0xF);
            byte c = (byte)((ipcode & 0x0000FF00) >> 0x8);
            byte d = (byte)(ipcode & 0x000000FF);
            string ipStr = string.Format("{0}.{1}.{2}.{3}", a, b, c, d);
            return ipStr;
        }

        private void timeoutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ipCheck(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }            
    }
}
