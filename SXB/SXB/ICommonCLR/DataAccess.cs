﻿using SQLite.Net;
using SXB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SXB.ICommonCLR
{

    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            // create the table(s)
            dbConn.CreateTable<Employee>();
        }
        public List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");
        }
        public int SaveEmployee(Employee aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }
        public int DeleteEmployee(Employee aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }
        public int EditEmployee(Employee aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
