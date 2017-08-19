using System;
using System.IO.Ports;

namespace SerialReader
{
    class Program
    {
        static private void printString(string input)
        {
            string[] data = input.Split(',');
            int key;
            double a;
            int b;
            string c;
            try
            {
                key = Convert.ToInt32(data[0]);
                Console.WriteLine(key);

                a = Convert.ToDouble(data[1]) - key;
                Console.WriteLine(a);

                b = Convert.ToInt32(data[2]) - key;
                Console.WriteLine(b);

                c = data[3];
                Console.WriteLine(c);
            }
            catch (Exception)
            {

            }
            Console.WriteLine("--------------------------");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the port: ");
            string portname = Console.ReadLine();
            try
            {
                SerialPort port = new SerialPort(portname, 9600);
                port.Open();
                while (true)
                {
                    printString(port.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR:["+e.Message+"]");
            }
            int c = Console.Read();
        }
    }
}
