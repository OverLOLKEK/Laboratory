using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory.db
{
    public  class DBInstance
    { 
    static LabEntities connection;
    static object objectLock = new object();
    public static LabEntities Get()
    {
        lock (objectLock)
        {
            if (connection == null)
                connection = new LabEntities();
            return connection;
        }
    }
    }
}
