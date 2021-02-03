using System;

namespace Singleton
{
    class Program
    {
        static TableServers host1 = new TableServers();
        static TableServers host2 = new TableServers();
        static TableServers host3 = TableServers.GetInstance();
        static TableServers host4 = TableServers.GetInstance();

        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {
                //Host1Gen();
                //Host2Gen();
                Host3Gen();
                Host4Gen();
            }

        }


        private static void Host1Gen()
        {
            Console.WriteLine("server:"+host1.GetNextServer());
        }
        private static void Host2Gen()
        {
            Console.WriteLine("server:" + host2.GetNextServer());
        }
        private static void Host3Gen()
        {
            Console.WriteLine("server:" + host3.GetNextServer());
        }
        private static void Host4Gen()
        {
            Console.WriteLine("server:" + host4.GetNextServer());
        }
    }
}
