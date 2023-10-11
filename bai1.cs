using System;

class bai1 {
    static void Main(string[] args) {
        Console.Write("Nhap chieu cao tam giac: ");
        int chieuCao = int.Parse(Console.ReadLine());

        for (int i = 1; i <= chieuCao; i++) {
            for (int j = 1; j <= chieuCao - i; j++) {
                Console.Write(" ");
            }
            for (int j = 1; j <=i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}