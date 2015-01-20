using Health.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber("Kenya", "BizTalk.Client");

            subscriber.StartEvents((CheckEvent ev) => 
            {
                Console.WriteLine("Created: {0}", ev.Created);
                Console.WriteLine("Id: {0}", ev.Id);
                Console.WriteLine("Message: {0}", ev.Message);
                Console.WriteLine("Node: {0}", ev.Node);
                Console.WriteLine("Notes: {0}", ev.Notes);
                Console.WriteLine("Source: {0}", ev.Source);
                Console.WriteLine("Status: {0}", ev.Status);

                Console.WriteLine();
            });

            Console.ReadLine();

            subscriber.StopEvents();
        }
    }
}
