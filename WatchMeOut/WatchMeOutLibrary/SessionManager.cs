﻿using System;
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
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                session = cluster.Connect("videoklub");
            }
            return session;
        }
    }
}
