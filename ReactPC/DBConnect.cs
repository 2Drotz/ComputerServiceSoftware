using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ReactPC
{
    class DBConnect
    {
        SqlConnection SqlConnect = new SqlConnection(@"Data Source=DESKTOP-P4MMNAF\SQLMANDRIN;Initial Catalog=BDKServise;Integrated Security=True"); //экземпляр класса sqlconnection

        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        SqlCommand command = new SqlCommand();

        public DataTable getTable(string qury)
        {
            SqlConnect = getConnection();
            command = new SqlCommand(qury, SqlConnect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            return dtable;
        }
        /// <summary>
        /// //////////////////////////////
        /// </summary>
        public void openConnection()
        {
            if (SqlConnect.State == System.Data.ConnectionState.Closed)
            {
                SqlConnect.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnect.State == System.Data.ConnectionState.Open)
            {
                SqlConnect.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return SqlConnect;
        }
    }
}
