using Health.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();

            handler.Start();

            Console.ReadLine();

            handler.Stop();
        }
    }
}
