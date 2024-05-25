using System;

namespace NumberReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] units = {"", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin"};
            string[] tens = {"", "muoi", "hai muoi\, "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi"};

            Console.Write("Nhap vao mot so nguyen co toi da hai chu so: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 99)
            {
                Console.WriteLine("So ma ban nhap vao khong hop le vui long thu lai");
                return;
            }

            Console.WriteLine("Cach doc cua so " + number + " la: " + ReadNumber(number, units, tens));
        }

        static string ReadNumber(int number, string[] units, string[] tens)
        {
            if (number == 0)
                return "khong";
            if (number <= 9)
                return units[number];
            if (number <= 19)
                return tens[number];
            int unitDigit = number % 10;
            int tenDigit = number / 10;
            return tens[tenDigit] + " " + units[unitDigit];
        }
    }
}
}