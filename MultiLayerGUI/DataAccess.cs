using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerGUI
{
    class DataAccess
    {
        private string connectString;
        public DataAccess(string connectionString)
        {
            connectString = connectionString;
        }

        public bool accessToCust()
        {
            string queryString = "SELECT * FROM [dbo].[Customers]";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool accessToOrders()
        {
            string queryString = "SELECT * FROM [dbo].[Orders]";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool accessToEmp()
        {
            string queryString = "SELECT * FROM [dbo].[Employees]";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool accessLogin()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public int numOfCust()
        {
            string queryString = "SELECT COUNT(CustomerID) FROM [dbo].[Customers]";
            int numOfCustVar = 0;
            
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        numOfCustVar = (int)reader[0];
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return numOfCustVar;
        }

        public List<string> listOfCust()
        {
            string queryString = "SELECT ContactName FROM [dbo].[Customers]";
            List<string> listOfCustVar = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string lastNameOnly = reader[0].ToString().Split(' ').Last();
                        listOfCustVar.Add(lastNameOnly);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return listOfCustVar;
        }
        public int numOfOrders()
        {
            string queryString = "SELECT COUNT(OrderID) FROM [dbo].[Orders]";
            int numOfOrdersVar = 0;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        numOfOrdersVar = (int)reader[0];
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return numOfOrdersVar;
        }

        public List<string> listOfOrders()
        {
            string queryString = "SELECT ShipName FROM [dbo].[Orders]";
            List<string> listOfOrdersVar = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string shipName = reader[0].ToString();
                        listOfOrdersVar.Add(shipName);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return listOfOrdersVar;
        }
        public int numOfEmp()
        {
            string queryString = "SELECT COUNT(EmployeeID) FROM [dbo].[Employees]";
            int numOfEmpVar = 0;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        numOfEmpVar = (int)reader[0];
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return numOfEmpVar;
        }

        public List<string> listOfEmp()
        {
            string queryString = "SELECT LastName FROM [dbo].[Employees]";
            List<string> listOfEmpVar = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string lastNameOnly = reader[0].ToString();
                        listOfEmpVar.Add(lastNameOnly);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return listOfEmpVar;
        }
    }
}
