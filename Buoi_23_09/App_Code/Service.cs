using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    
    [WebMethod]
    public string giai_pt_bac_1(float a, float b)
    {
        if (a == 0)
            if (b == 0)
                return "Phương trình vô số nghiệm";
            else
                return "Phương trình vô nghiệm";
        else
            return "Phương trình có nghiệm x = " + (-b / a);
    }

    [WebMethod]
    public string giai_pt_bac_2(float a, float b, float c)
    {
        if(a == 0)
        {
            return giai_pt_bac_1(b, c);
        } else
        {
            double delta = b * b - 4 * a * c;
            String kq = "";
            if (delta < 0)
            {
                kq = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                kq = "Phương trình có nghiệm kép x1 = x2 = " + (-b / (2 * a));
            }
            else
            {
                delta = Math.Sqrt(delta);
                kq = "Phương trình có hai nghiệm: ";
                kq += "x1 = " + ((-b + delta) / (2 * a));
                kq += " và x2 = " + ((-b - delta) / (2 * a));
            }
            return kq;
        }
    }
}