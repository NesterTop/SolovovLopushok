using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SolovovLopushok
{
    public class DataBase : IDisposable
    {
        private string _connectionString = @"Data Source=DESKTOP-A9MP2FF\SQLEXPRESS;Initial Catalog=193_Solovov;Integrated Security=True";
        private SqlConnection _connection;

        public bool IsConnected { get; private set; }

        public DataBase()
        {
            _connection = new SqlConnection(_connectionString);
            OpenConnection();
        }

        private void OpenConnection()
        {
            _connection.Open();
            IsConnected = true;
        }

        private void CloseConnection()
        {
            _connection.Close();
            IsConnected = false;
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(sql, _connection);
            table.Load(command.ExecuteReader());

            return table;
        }

        public bool ExecuteNonQuery(string sql)
        {
            bool result;
            
            try
            {
                SqlCommand command = new SqlCommand(sql, _connection);
                command.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
