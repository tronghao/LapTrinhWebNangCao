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
        int[] number = new int[5];
        ServiceMath.ServiceSoapClient ws = new ServiceMath.ServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        public bool validate()
        {
            if(txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ dữ liệu");
                return false;
            }

            try
            {
                number[0] = Int32.Parse(txt1.Text);
                number[1] = Int32.Parse(txt2.Text);
                number[2] = Int32.Parse(txt3.Text);
                number[3] = Int32.Parse(txt4.Text);
                number[4] = Int32.Parse(txt5.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu");
                return false;
            }
            return true;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                int max = number[0];

                for(int i=1; i<=4; i++)
                {
                    max = ws.max(max, number[i]);
                }

                txtKq.Text = "Số lớn nhất: " + max.ToString();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int min = number[0];

                for (int i = 1; i <= 4; i++)
                {
                    min = ws.min(min, number[i]);
                }

                txtKq.Text = "Số nhỏ nhất: " + min.ToString();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int sum = number[0];
                for (int i = 1; i <= 4; i++)
                {
                    sum = ws.sum(sum, number[i]);
                }
                txtKq.Text = "Tổng các số: " + sum.ToString();
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                double ave = 0;
                int sum = number[0];
                for (int i = 1; i <= 4; i++)
                {
                    sum = ws.sum(sum, number[i]);
                }

                ave = ws.average(sum, 5);
                txtKq.Text = "Trung bình các số: " + ave.ToString();
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                bool[] soLe = new bool[5];

                for (int i = 0; i < 5; i++)
                {
                    soLe[i] = ws.soLe(number[i]);
                }


                txtKq.Text = "Số lẻ:";
                int cacSoLe = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (soLe[i] == true)
                    {
                        txtKq.Text += " " + number[i].ToString();
                        cacSoLe++;
                    }
                }

                if (cacSoLe == 0)
                    txtKq.Text += " Không có số lẻ";
            }
            
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bool[] soChan = new bool[5];

                for (int i = 0; i < 5; i++)
                {
                    soChan[i] = ws.soChan(number[i]);
                }


                txtKq.Text = "Số chẵn:";
                int cacsoChan = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (soChan[i] == true)
                    {
                        txtKq.Text += " " + number[i].ToString();
                        cacsoChan++;
                    }
                }

                if (cacsoChan == 0)
                    txtKq.Text += " Không có số chẵn";
            }
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bool[] soNguyenTo = new bool[5];

                for (int i = 0; i < 5; i++)
                {
                    soNguyenTo[i] = ws.soNguyenTo(number[i]);
                }


                txtKq.Text = "Số nguyên tố:";
                int cacsoNguyenTo = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (soNguyenTo[i] == true)
                    {
                        txtKq.Text += " " + number[i].ToString();
                        cacsoNguyenTo++;
                    }
                }

                if (cacsoNguyenTo == 0)
                    txtKq.Text += " Không có số nguyên tố";
            }
        }
    }
}
