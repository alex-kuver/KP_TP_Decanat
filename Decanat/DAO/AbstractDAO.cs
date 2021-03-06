﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using NLog;

namespace Decanat.DAO
{
    public class AbstractDAO
    {
        private const string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Decanat-20201123082459.mdf;Initial Catalog=aspnet-Decanat-20201123082459;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

        public static Logger loger = LogManager.GetCurrentClassLogger();

        protected SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public void Disconnect()
        {
            Connection.Close();
        }
    }
}