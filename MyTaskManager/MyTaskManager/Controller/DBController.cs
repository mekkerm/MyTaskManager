using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Controller
{
    public class DBController
    {
        private string connectionString = "Data Source=MTM.Db;Version=3;New=False;Compress=True;";
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection(connectionString);
        }
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            //sql_cmd = sql_con.CreateCommand();
            //sql_cmd.CommandText = txtQuery;
            //sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        public void execute(string text)
        {
            ExecuteQuery(text);
        }
    }
}
