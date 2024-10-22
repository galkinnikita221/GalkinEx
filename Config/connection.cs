using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace GalkinEx.Config
{
    public class Connection
    {
        public static readonly string config = "Server=student.permaviat.ru;" + "Trusted_Connection=False;" + "Database=ISP_21_2_2;" + "User=ISP_21_2_2;" + "Port=3306;";
        public static readonly MySqlServerVersion mySqlServerVersion = new MySqlServerVersion(new Version(8,0,11));
    }
}