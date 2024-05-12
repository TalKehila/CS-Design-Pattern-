using System;
using System.Threading;

namespace StartegyPattern
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            tempValidtion alert = new Alert();
            tempValidtion ok = new OK();
            tempValidtion water = new Water();


            Random temp = new Random();
            temp.Next(10, 100);
            while (true)
            {

               Thread.Sleep(1000);


            }



        }
    }
}
