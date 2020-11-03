using System;

public class HamTongHop
{
	public HamTongHop()
	{
	}

    public int sum(int[] mangSoNguyen)
    {
        return mangSoNguyen.Sum();
    }

    public double Avg(int[] mangSoNguyen)
    {
        return Queryable.Average(mangSoNguyen.AsQueryable());
    }

    public string inSoLeVaTongCuaChung(int[] mangSoNguyen)
    {
        int tongLe = 0;
        string cacSoLe = "";
        for (int i = 0; i < mangSoNguyen.Length; i++)
        {
            if (mangSoNguyen[i] % 2 != 0)
            {
                tongLe += mangSoNguyen[i];
                cacSoLe += mangSoNguyen[i].ToString() + ", ";
            }
        }
        return "Cac so le la: " + cacSoLe + " Tong le: " + tongLe;
    }

    bool laSoChan(int number)
    {
        if (number % 2 == 0)
            return true;
        else return false;
    }

    bool laSNT(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public string inCacSNT(int[] mangSoNguyen)
    {
        string cacSNT = "Các số nguyên tố: ";
        int soLuong = 0;
        for (int i = 0; i < mangSoNguyen.Length; i++)
        {
            if (laSNT(mangSoNguyen[i]))
            {
                cacSNT += mangSoNguyen[i] + ", ";
                soLuong++;
            }
        }
        if (soLuong != 0)
            cacSNT += "Không có số nguyên tố";
        return cacSNT;
    }

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

    public int BCNN(int a, int b)
    {
        int result = UCLN(a, b);
        return a * b / result;
    }

    public int fibonaci(int s)
    {
        if (s == 0 || s == 1)
            return 1;
        else
            return (fibonaci(s - 2) + fibonaci(s - 1));
    }

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

    public string uocSoVatinhTong(int n)
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

    public string giai_pt_bac_1(float a, float b)
    {
        if (a == 0)
            if (b == 0)
                return "Phương trình vô số nghiệm";
            else
                return "Phương trình vô nghiệm";
        else
            return "x = " + (-b / a);
    }


    public string giai_pt_bac_2(float a, float b, float c)
    {
        if (a == 0)
        {
            return giai_pt_bac_1(b, c);
        }
        else
        {
            double delta = b * b - 4 * a * c;
            String kq = "";
            if (delta < 0)
            {
                kq = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                kq = "x1 = x2 = " + (-b / (2 * a));
            }
            else
            {
                delta = Math.Sqrt(delta);
                //kq = "Phương trình có hai nghiệm: ";
                kq += "x1 = " + ((-b + delta) / (2 * a));
                kq += " và x2 = " + ((-b - delta) / (2 * a));
            }
            return kq;
        }
    }


    public string tangDanGiamDan(int[] arr)
    {

        String result = "";

        result += "Dãy tăng dần: ";
        Array.Sort(arr);
        foreach (int i in arr)
            result += " " + i;

        result += "\tDãy giảm dần: ";
        Array.Reverse(arr);
        foreach (int i in arr)
            result += " " + i;

        return result;
    }

    [WebMethod]
    public string maxMinAndIndex(int[] arr)
    {

        int indexMax, indexMin;

        indexMax = indexItemMaxInArr(arr);
        indexMin = indexItemMinInArr(arr);


        string result = "";
        result += "Max: " + arr[indexMax];
        result += " Index: " + (indexMax + 1);
        result += "\tMin: " + arr[indexMin];
        result += " Index: " + (indexMin + 1);
        return result;
    }

    public int indexItemMaxInArr(int[] arr)
    {
        int index = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            int giaTriIndex = arr[index];
            int giaTriSoSanh = arr[i];
            if (max(giaTriIndex, giaTriSoSanh) == giaTriSoSanh)
                index = i;
        }

        return index;
    }

    public int max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    public int indexItemMinInArr(int[] arr)
    {
        int index = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            int giaTriIndex = arr[index];
            int giaTriSoSanh = arr[i];
            if (min(giaTriIndex, giaTriSoSanh) == giaTriSoSanh)
                index = i;
        }

        return index;
    }

    public int min(int a, int b)
    {
        return (a < b) ? a : b;
    }


    public string inraCacSoChinhPhuongVaTrungBinh(int[] arr)
    {

        String result = "Các số chính phương: ";
        int tong = 0, soLuongSoChinhPhuong = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (laSoChinhPhuong(arr[i]))
            {
                result += " " + arr[i] + ",";
                tong += arr[i];
                soLuongSoChinhPhuong++;
            }
        }

        if (soLuongSoChinhPhuong == 0)
            result += "Không có số chính phương.";
        else
        {
            float trungbinh = (float)tong / soLuongSoChinhPhuong;
            result += " Trung bình: " + trungbinh;
        }

        return result;

    }

    public bool laSoChinhPhuong(int number)
    {
        int sqr = (int)Math.Sqrt(number);
        if (sqr * sqr == number)
        {
            return true;
        }

        return false;
    }

}
