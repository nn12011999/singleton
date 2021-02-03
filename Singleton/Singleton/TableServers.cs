using System.Collections.Generic;

namespace Singleton
{
    public class TableServers
    {
        private static TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        public TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Bob");
        }

        public static TableServers GetInstance()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];

            nextServer += 1;

            if (nextServer >=servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
