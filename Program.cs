class Program
{
    static void Main(string[] args)
    {
       int so;
       string chu="";
       Console.WriteLine("Moi nhap so:");
       so = int.Parse(Console.ReadLine());
       if(so<0 || so>999)
       {
            Console.WriteLine("out of ability");
       }
       if(so>0 && so<10)
       {
            switch(so)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine(chuyenSOThanhChuHangDonvi(so));
                    break;
            }
       }
       if(so>=10 && so<20)
       {
            switch(so)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                default:
                    so=so%10;
                    Console.WriteLine(chuyenSOThanhChuHangDonvi(so)+"teen");
                    break;
            }
       }
       if(so>=20 && so<100)
       {
            Console.WriteLine(chuyenSoThanhChuHangChuc(so/10)+" "+chuyenSOThanhChuHangDonvi(so%10));
       }
       if(so>=100 && so<1000)
       {
            int donVi=so%10;
            so/=10;
            int chuc=so%10;
            so/=10;
            Console.WriteLine(chuyenSoThanhChuHangTram(so)+" and "+chuyenSoThanhChuHangChuc(chuc)+" "+chuyenSOThanhChuHangDonvi(donVi));
       }
    }
    static string chuyenSOThanhChuHangDonvi(int a)
    {
        switch(a)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
        }
        return "";
    }
    static string chuyenSoThanhChuHangChuc(int a)
    {
        switch(a)
        {
            case 2:
                return "Twenty";
            case 3:
                return "Thirty";
            case 5:
                return "Fifty";
        }
        return chuyenSOThanhChuHangDonvi(a)+"ty";
    }
    static string chuyenSoThanhChuHangTram(int a)
    {
        return chuyenSOThanhChuHangDonvi(a) + " hundred";
    }
}