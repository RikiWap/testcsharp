using System;

class bai3
{
    static void tram(int x)
    {
        switch (x)
        {
            case 1:
                Console.Write("Mot Tram"); break;
            case 2:
                Console.Write("Hai Tram"); break;
            case 3:
                Console.Write("Ba Tram"); break;
            case 4:
                Console.Write("Ban Tram"); break;
            case 5:
                Console.Write("Nam Tram"); break;
            case 6:
                Console.Write("Sau Tram"); break;
            case 7:
                Console.Write("Bay Tram"); break;
            case 8:
                Console.Write("Tam Tram"); break;
            case 9:
                Console.Write("Chin Tram"); break;
        }
    }

    static void chuc(int x)
    {
        switch (x)
        {
            case 1:
                Console.Write("Muoi"); break;
            case 2:
                Console.Write("Hai Muoi"); break;
            case 3:
                Console.Write("Ba Muoi"); break;
            case 4:
                Console.Write("Bon Muoi"); break;
            case 5:
                Console.Write("Nam Muoi"); break;
            case 6:
                Console.Write("Sau Muoi"); break;
            case 7:
                Console.Write("Bay Muoi"); break;
            case 8:
                Console.Write("Tam Muoi"); break;
            case 9:
                Console.Write("Chin Muoi"); break;
        }
    }

    static void donVi(int x)
    {
        switch (x)
        {
            case 1:
                Console.Write("Mot"); break;
            case 2:
                Console.Write("Hai"); break;
            case 3:
                Console.Write("Ba"); break;
            case 4:
                Console.Write("Bon"); break;
            case 5:
                Console.Write("Nam"); break;
            case 6:
                Console.Write("Sau"); break;
            case 7:
                Console.Write("Bay"); break;
            case 8:
                Console.Write("Tam"); break;
            case 9:
                Console.Write("Chin"); break;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so tu 0 -> 999.999.999: ");
        int n = Convert.ToInt32(Console.ReadLine());
        //tach so:
        int tTrieu = n / 100000000;
        int cTrieu = (n / 10000000) % 10;
        int trieu = (n / 1000000) % 10;
        int tng = (n / 100000) % 10;
        int cng = (n / 10000) % 10;
        int ng = (n / 1000) % 10;
        int t = (n / 100) % 10;
        int c = (n / 10) % 10;
        int dv = n % 10;

        //doc so:
        //hang trieu:
        tram(tTrieu); Console.Write(" ");
        chuc(cTrieu); Console.Write(" ");
        donVi(trieu); Console.Write(" ");
            if( tTrieu >=1 || cTrieu>=1||trieu>=1)
                Console.Write("Trieu ");
            //hang nghin:
            tram(tng); Console.Write(" ");
        chuc(cng); Console.Write(" ");
        donVi(ng); Console.Write(" ");
            if (tng >= 1 || cng >= 1 || ng >= 1)
                Console.Write("Nghin ");
            //
        tram(t); Console.Write(" ");
        chuc(c); Console.Write(" ");
        donVi(dv);
            if (n==0)
                Console.Write("Khong");

        }
}