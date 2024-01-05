using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool TextFile)
        {
            if (database)
            {
                //TODO: Set up the SQL Connector Properly
                SqlConnector sql = new SqlConnector();
                connections.Add(sql);
            }
            if(TextFile)
            {
                //TODO: Create the Text Connection
                TextConnector text = new TextConnector();
                connections.Add(text);
            }
        }
    }
}
