using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_13_Task_2
{
    internal class DataProcessing // Класс для операций с данными
    {
        // Метод формирования списка таблиц выбранной база данных name
        static public List<string> GetDataBySelect(string query, string name)
        {
            List<string> result = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={name};"))
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                try
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    string tableName = reader.GetTableName(0);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception Ex)
                {
                    result.Add(Ex.Message);
                }
            }
            return result;
        }
        // Метод получения данных из выбранной таблицы (table) базы данных (name)
        public static DataSet GetData_FromTable(string name, string table) 
        {
            DataSet result = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={name};"))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {table};", conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Fill(result);
            }
            return result;
        }
        // Сохранение в базу данных (name) изменённых в DataGridView данных
        public static void SaveDataToDB(DataTable dt, string name, string table)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={name};"))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM {table};", conn);
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(dt);
            }
        }
    }
}
