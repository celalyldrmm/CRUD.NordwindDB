﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlcon = new SqlConnection
                    ("Server=DESKTOP-VUJBGC1\\SQLEXPRESS;Trusted_Connection=True;Database=NORTHWND;");
                return sqlcon;
            }
        }

    }
}
