using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        WebService.ServiceSoapClient ws = new WebService.ServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioPT1.Checked == false && radioPT2.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn phương trình để giải");
            } else if(radioPT1.Checked)
            {
                float a = float.Parse(txtA1.Text);
                float b = float.Parse(txtB1.Text);
                txtKq.Text = ws.giai_pt_bac_1(a, b);
            } else
            {
                float a = float.Parse(txtA2.Text);
                float b = float.Parse(txtB2.Text);
                float c = float.Parse(txtC2.Text);
                txtKq.Text = ws.giai_pt_bac_2(a, b, c);
            }
        }
    }
}
