using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Mvc2.Models
{
    public class AddStudent
    {
        SqlConnection _connection = new SqlConnection("data source=.;database=StudentDb;user id=sa;password=abc");


        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public bool AddUser(string studentName, int age)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                var query = string.Format("insert into Tblstudent(sname,age)values(@sname,@age);");
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@sname", studentName);
                command.Parameters.AddWithValue("@age", age);
                return (Convert.ToBoolean(command.ExecuteNonQuery()));
            }
            catch 
            {
                throw;
            }
        }
    }
}