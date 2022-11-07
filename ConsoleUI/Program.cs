using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";

            firstName = "\"teSting 10254@890)^";
            string filePath = @"C:\Temp\test\secure.tct";

            string lastName = "";
            string middleName = "";

            middleName = "John";
            lastName = "Doe";

            string fullName = $"{middleName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(fullName);

            int age = 0;
            age = 15;
            age = 20;
            age = -23;

            uint pay = 8;

            double averagePointPerMatch = 34.4; // precise only to some precision point 
            decimal averageBill = 58.45M; // much more precise but expensive when storing data. Used only when related to money.

            Console.WriteLine($"pay = {pay},\nAverage Bill = {averageBill},\nAverage point per match = {averagePointPerMatch}");

            bool isAlive = true;
            bool continueGame = false;

            int почта = 620457;
            string zipCode = "005847";

            Console.WriteLine($"{почта.ToString()}, {zipCode}");

            Console.ReadLine();
        }
    }
}
