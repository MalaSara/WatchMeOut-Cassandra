using System;
using Cassandra;


namespace WatchMeOutLibrary
{
    public static class SessionManager
    {
        public static ISession session;

        public static ISession GetSession()
        {
            if (session == null)
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("localhost").Build();
                session = cluster.Connect("a");
            }
            return session;
        }
    }
}
