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
    public int max(int a, int b)
    {
        if (a > b)
            return a;
        else return b;
    }

    [WebMethod]
    public int min(int a, int b)
    {
        if (a < b)
            return a;
        else return b;
    }

    [WebMethod]
    public int sum(int a, int b)
    {
        return a + b;
    }

    [WebMethod]
    public double average(int sum, int number)
    {
        return (double)sum / number;
    }

    [WebMethod]
    public bool soLe(int a)
    {
        if (a % 2 == 0)
            return false;
        else return true;
    }

    [WebMethod]
    public bool soChan(int a)
    {
        if (a % 2 == 0)
            return true;
        else return false;
    }

    [WebMethod]
    public bool soNguyenTo(int a)
    {
        if (a < 2)
            return false;
        for(int i=2; i<a; i++)
        {
            if (a % i == 0)
                return false;
        }

        return true;
    }
    
}