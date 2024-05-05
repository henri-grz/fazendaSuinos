using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public class DatabaseConnection : IDisposable
{
    private SqlConnection connection;

    public DatabaseConnection(String connectionString)
    {
        connection = new SqlConnection(connectionString);
    }

    public void Open()
    {
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
    }

    public void Close()
    {
        if (connection.State != System.Data.ConnectionState.Closed)
        {
            connection.Close();
        }
    }

    public SqlCommand CreateCommand(string query)
    {
        SqlCommand command = new SqlCommand(query, connection);

        return command;
    }

    public void Dispose()
    {
        if (connection != null)
        {
            connection.Dispose();
            connection = null;
        }
    }
}
