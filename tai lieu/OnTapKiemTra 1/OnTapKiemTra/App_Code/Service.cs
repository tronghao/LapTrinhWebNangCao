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
    public int timMax(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        int max;
        max = mangSoNguyen[0];
        for(int i = 0; i < 5; i++)
        {
            if (max < mangSoNguyen[i]) max = mangSoNguyen[i];
        }
        return max;
    }

    [WebMethod]
    public int timMin(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        int min;
        min = mangSoNguyen[0];
        for (int i = 0; i < 5; i++)
        {
            if (min > mangSoNguyen[i]) min = mangSoNguyen[i];
        }
        return min;
    }

    [WebMethod]
    public int timSum(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        return mangSoNguyen.Sum();
    }

    [WebMethod]
    public double timAvg(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        return Queryable.Average(mangSoNguyen.AsQueryable());
    }


    [WebMethod]
    public string inSoLe(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        int tongLe = 0;
        string cacSoLe = "";
        for(int i = 0; i < 5; i++)
        {
            if(mangSoNguyen[i] % 2 != 0)
            {
                tongLe += mangSoNguyen[i];
                cacSoLe += mangSoNguyen[i].ToString() + ", ";
            }
        }
        return "Cac so le la: " + cacSoLe + " Tong le: " + tongLe;
    }



    // Hàm kiểm tra SNT    
    [WebMethod]
    bool kiemTraSNT(int a)
    {
        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    // In ra các số nguyên tố trong 5 số nguyên bất kỳ
    [WebMethod]
    public string inCacSNT(int num1, int num2, int num3, int num4, int num5)
    {
        int[] mangSoNguyen = { num1, num2, num3, num4, num5 };
        string cacSNT = "";
        for (int i = 0; i < 5; i++ )
        {
            if (kiemTraSNT(mangSoNguyen[i]))
            {
                cacSNT += mangSoNguyen[i] + ", ";
            }
        }
        return cacSNT;
    }


    // ước chung lớn nhất
    [WebMethod]
    public int UCLN(int a, int b)
    {
        //Nếu A hoặc B = 0 thì UCLN = A+ B
        if (a == 0 || b == 0)
            return a + b;

        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }

        return a; // or return b; a = b
    }

    //int UCLN(int A, int B)
    //{
    //    if (B == 0)
    //        return A;
    //    return UCLN(B, A % B);
    //}


    // Bội chung nhỏ nhất
    [WebMethod]
    public int BCNN(int a, int b)
    {
        int result = UCLN(a, b);
        return a * b / result;
    }


    // Hàm Fibonaci
    [WebMethod]
    public int fibonaci(int s)
    {
        if (s == 0 || s == 1)
            return 1;
        else
            return (fibonaci(s - 2) + fibonaci(s - 1));
    }



    // In ra tất cả các số lẻ nhỏ hơn n nhưng lớn hơn 0,  và các số chẵn lớn hơn nó nhưng nhỏ hơn 100
    [WebMethod]
    public string inLeNho_ChanNho(int n)
    {
        int[] arr = new int[n]; 
        string cacSoLe = "";
        string cacSoChan = "";
        for(int i = 1; i < n; i++)
        {
            if(i % 2 != 0)
            {
                cacSoLe += i + ", ";
            }
        }
        for (int j = n + 1; j < 100; j++)
        {
            if (j % 2 == 0)
            {
                cacSoChan += j + ", ";
            }
        }
        return "Cac so le nho hon n: " + cacSoLe + ", Cac so chan lon hon N va nho hon 100: " + cacSoChan;
    }


    // In ra các số nguyên tố từ 1 đến n và tổng của chúng
    [WebMethod]
    public string inSNT_tinhTong(int n)
    {
        string cacSNT = "";
        int tongSNT = 0;
        for (int i = 1; i <= n; i++)
        {
            if(kiemTraSNT(i))
            {
                tongSNT += i;
                cacSNT += i + ", ";
            }
        }
        return "Cac SNT tu 1 toi " + n + " la: " + cacSNT + "  Tong cua chung la: " + tongSNT;  
    }

   

    //Chuyển đổi thành số nhị phân
    private bool IsNumeric(string number)
    {
        bool result = false;
        try
        {
            int temp = int.Parse(number);
            result = true;
        }
        catch (Exception ex)
        {
            
        }
        return result;
    }

    [WebMethod]
    public string chuyenDoiNhiPhan(string data)
    {
        string error = string.Empty;
        string result = string.Empty;
        int rem = 0;
        try
        {
                int num = int.Parse(data);
                while (num > 0)
                {
                    rem = num % 2;
                    num = num / 2;
                    result = rem.ToString() + result;
                }
        }
        catch (Exception ex)
        {
           
        }
        return result;
    }


    // Hàm kiểm tra số hoàn hảo
    [WebMethod]
    public bool kiemTraSoHoanHao(int a)
    {
        int sum = 0;
        for (int i = 1; i <= a / 2; i++)
        { 
            if (a % i == 0)
                sum += i; 
        }
        if (sum == a) return true; 
        return false; 
    }



    // In ra tất cả các ước số của n và tổng của chúng
    [WebMethod]
    public string uocSo_tinhTong(int n)
    {
        int tongUocSo = 0;
        string cacUocSo = "";
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                tongUocSo += i;
                cacUocSo += i + ", ";
            }
        }
        return "Cac uoc so cua " + n + " la: " + cacUocSo + " Tong la: " + tongUocSo;
    }

    // In ra các ước số là số lẻ và tổng của chúng
    [WebMethod]
    public string uocSoLe_tinhTongLe(int n)
    {
        int tongUocSoLe = 0;
        string cacUocSoLe = "";
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0 && i % 2 != 0)
            {
                tongUocSoLe += i;
                cacUocSoLe += i + ", ";
            }
        }
        return "Cac uoc so le: " + cacUocSoLe + " Tong cac uoc so le: " + tongUocSoLe;
    }


    // In ra các ước số là số chẳn và tích của chúng
    [WebMethod]
    public string uocSoChan_tinhTichChan(int n)
    {
        int tichUocSoChan = 1;
        string cacUocSoChan = "";
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0 && i % 2 == 0)
            {
                tichUocSoChan *= i;
                cacUocSoChan += i + ", ";
            }
        }
        return "Cac uoc so le: " + cacUocSoChan + " Tong cac uoc so le: " + tichUocSoChan;
    }


    // Hàm kiểm tra năm nhuận
    [WebMethod]
    public bool kiemTraNamNhuan(int nam)
    {
        // Nếu số năm chia hết cho 400,
        // đó là 1 năm nhuận
        if (nam % 400 == 0)
            return true;

        // Nếu số năm chia hết cho 4 và không chia hết cho 100,
        // đó không là 1 năm nhuận
        if (nam % 4 == 0 && nam % 100 != 0)
            return true;

        // trường hợp còn lại 
        // không phải năm nhuận
        return false;

        /* hoặc sử dụng hàm có sản của c# */
        // DateTime.IsLeapYear(nam);
    } 
  




    /* CÁC CÔNG THỨC TÍNH CÁC HÌNH...
        - HÌNH CHỮ NHẬT (a, b lần lượt là chiều dài và chiều rộng)
          Chu vi = (a + b)*2
          Dien tich = a * b   
     
        - HÌNH VUÔNG (a, b lần lượt là chiều dài và chiều rộng)
          Chu vi = a * 4
          Dien tich = a * a
        
        - HÌNH TAM GIÁC ()
          Tam Giac Thường 
            Dien tich = Căn(p*(p - a)*(p - b)*(p - c)). Trong đó p = 1/2 * (a + b + c)
          Vuông = 1/2 * a * b
          Cân = 1/2 * a * ha (ha: là chiều cao)
          Đều = a bình nhân căn 3 chia 4 =))
     
        - HÌNH TRÒN (d, r lần lượt là đường kính và bán kính)
          Chu vi = d * 3.14
          Dien tich = r * r * 3.14
     
        - HÌNH BÌNH HÀNH 
          Chu vi = (a + b) * 2  // (a, b: là 2 cạnh kề)
          Dien tich = a * h     // a: đáy, h: chiều cao
     */

}