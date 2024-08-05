using System;


namespace ChuyenDoiTienTe
{
    class Program
    {
        static void Main(string[]args)
        {
            float VND;
            float USD;
            
            Console.Write("Nhap vao so tien USD ban muon doi: ");
            USD = float.Parse(Console.ReadLine());
            VND = USD*23000;
            Console.WriteLine("Doi ra duoc {0} Viet Nam Dong", VND);
        
        }
    }
}