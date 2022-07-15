using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonitoringAndEvaluationApp.Models;
using SQLite;

namespace MonitoringAndEvaluationApp
{
    public class SQLiteHelper
    {
        public SQLiteHelper() { }

        public static bool Insert<T>(ref T data, string dbPath)
        {
            using (var conn = new SQLiteConnection(dbPath, true))
            {
                conn.CreateTable<T>();

                if (conn.Insert(data) != 0)
                    return true;
            }
            return false;
        }
    }
}
