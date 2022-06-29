using System;

namespace modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            string fullName = "Иванов Иван Иванович";
            int age = 22;
            string email = "ivanov3242@gmail.com";
            float balProg = 57.5f;
            float balMat = 23.2f;
            float balFiz = 45.1f;
            Console.WriteLine($"ФИО: {fullName}\nВозраст: {age}\nEmail: {email}\nБаллы по программированию: {balProg}\nБаллы по математике: {balMat}\nБаллы по физике: {balFiz}");
            Console.ReadKey();

            //задание 2
            float sumBal = balProg + balMat + balFiz;
            float sredBal = sumBal / 3;
            Console.WriteLine($"Сумма баллов: {sumBal}");
            Console.ReadKey();
            Console.WriteLine($"Среднее арифметическое баллов: {sredBal}");
            Console.ReadKey();
        }
    }
}
