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
        private static DBController _INSTANCE;
        

        public static DBController Instance{ get {
                if (_INSTANCE == null)
                {
                    _INSTANCE = new DBController();
                }
                return _INSTANCE;
            }
        }

        private DBController() { }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public List<Model.Task> GetSavedTasks()
        {
            List<Model.Task> list = new List<Model.Task>();
            using (var conn = GetConnection())
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = new Query.SelectAllTasks().GetQuery();
                var reader = command.ExecuteReader();
                list = GetTasks(reader);
            }

            return list;
        }

        /// <summary>
        /// Inserts the given task into the Tasks table
        /// </summary>
        /// <param name="task"></param>
        /// <returns>returns true if the insert operation finsihed successfully</returns>
        public bool AddNewTask(Model.Task task)
        {
            bool result = false;
            Query.Query query = new Query.InsertNewTask(task);
            using (var conn = GetConnection())
            {
                result = ExecuteNonQuery(conn, query);
            }

            return result;
        }


        public bool AddNewTaskTime(Model.TaskTime taskTime)
        {
            bool result = false;
            Query.Query query = new Query.InsertNewTaskTime(taskTime);
            using (var conn = GetConnection())
            {
                result = ExecuteNonQuery(conn, query);
            }

            return result;
        }

        private List<Model.Task> GetTasks(SQLiteDataReader reader)
        {
            List<Model.Task> list = new List<Model.Task>();
            while (reader.Read())
            {
                var task = new Model.Task();
                task.ID = reader[0].ToString();
                task.Title = reader[1].ToString();
                task.Description = reader[2].ToString();
                task.CreationDate = DateTime.Parse(reader[3].ToString());
                list.Add(task);
            }
            return list;
        }


        private bool ExecuteNonQuery(SQLiteConnection conn, Query.Query query)
        {
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = query.GetQuery();
            int affectedRows = command.ExecuteNonQuery();
            conn.Close();
            return affectedRows > 0;
        }

        
    }
}
