using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Mvc2.Models
{
    public class ShowStudentDetails
    {
        SqlConnection _connection = new SqlConnection("data source=.;database=StudentDb;user id=sa;password=abc");

        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public SqlDataReader ShowDetails()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                var query = string.Format("select * from Tblstudent;");
                var command = new SqlCommand(query, _connection);
                return (command.ExecuteReader());
            }
            catch
            {
                throw;
            }
        }
    }
}