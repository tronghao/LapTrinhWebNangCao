using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceSoapClient ws = new ServiceReference1.ServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int so1 = Int32.Parse(txt1.Text);
            int so2 = Int32.Parse(txt2.Text);
            txtKq.Text = ws.cong(so1, so2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int so1 = Int32.Parse(txt1.Text);
            int so2 = Int32.Parse(txt2.Text);
            txtKq.Text = ws.tru(so1, so2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int so1 = Int32.Parse(txt1.Text);
            int so2 = Int32.Parse(txt2.Text);
            txtKq.Text = ws.nhan(so1, so2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int so1 = Int32.Parse(txt1.Text);
            int so2 = Int32.Parse(txt2.Text);
            txtKq.Text = ws.chia(so1, so2).ToString();
        }
    }
}
