using System;

class bai2{
    static void Main(string[] args){
        Console.Write("Nhập số nguyên từ 0 đến 9: ");
        int so= Convert.ToInt32(Console.ReadLine());

        switch(so){
            case 0:
                Console.Write("Khong");break;
            case 1:
                Console.Write("Mat");break;
            case 2:
                Console.Write("Hai");break;
            case 3:
                Console.Write("Ba");break;
            case 4:
                Console.Write("Ban");break;
            case 5:
                Console.Write("Nam");break;
            case 6:
                Console.Write("Sau");break;
            case 7:
                Console.Write("Bay");break;
            case 8:
                Console.Write("Tam");break;
            case 9:
                Console.Write("Chin");break;
            default:
                Console.Write("So da nhap khong hop le!");
                break;
        }
    }
}