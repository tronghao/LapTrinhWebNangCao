using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSVJava
{
    public partial class Form1 : Form
    {
        ServiceReference1.webserviceClient ws = new ServiceReference1.webserviceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text= ws.tong(5, 7).ToString();
        }
    }
}
