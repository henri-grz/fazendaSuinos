using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DatabaseConnection : IDisposable
{
    private SqlConnection connection;

    public DatabaseConnection(String connectionString)
    {
        connection = new SqlConnection(connectionString);
    }

    public void Open()
    {
        try
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao conectar-se com o banco de dados.\n" + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    public void Close()
    {
        try
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao fechar a conexão com o banco de dados.\n" + ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
