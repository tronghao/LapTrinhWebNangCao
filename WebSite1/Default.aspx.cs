using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    int[] number = new int[5];
    ServiceMath.ServiceSoapClient ws = new ServiceMath.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool validate()
    {
        if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "")
        {
            Response.Write("<script> alert('Bạn cần nhập đầy đủ dữ liệu') </script>");
            return false;
        }

        try
        {
            number[0] = Int32.Parse(txt1.Text);
            number[1] = Int32.Parse(txt2.Text);
            number[2] = Int32.Parse(txt3.Text);
            number[3] = Int32.Parse(txt4.Text);
            number[4] = Int32.Parse(txt5.Text);
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('Lỗi nhập liệu') </script>");
            return false;
        }
        return true;
    }

    protected void btnMax_Click(object sender, EventArgs e)
    {
        if (validate())
        {
            int max = number[0];

            for (int i = 1; i <= 4; i++)
            {
                max = ws.max(max, number[i]);
            }

            txtKq.Text = "Số lớn nhất: " + max.ToString();
        }
    }

    protected void btnMin_Click(object sender, EventArgs e)
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

    protected void btnSum_Click(object sender, EventArgs e)
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

    protected void btnAve_Click(object sender, EventArgs e)
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

    protected void btnSoLe_Click(object sender, EventArgs e)
    {
        if (validate())
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

    protected void btnSoChan_Click(object sender, EventArgs e)
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

    protected void btnSNT_Click(object sender, EventArgs e)
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