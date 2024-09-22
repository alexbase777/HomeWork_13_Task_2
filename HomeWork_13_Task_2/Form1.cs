using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_13_Task_2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        string _path = string.Empty; // Путь к файлу
        string _name = string.Empty; // Имя загруженной БД
        string _table = string.Empty; // Имя выбранной из загруженной БД таблицы
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectBD_Click(object sender, EventArgs e)
        {
            openFileDialog_Connect.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog_Connect.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog_Connect.FileName; // В поле класса _path записывается имя БД
                _name = Path.GetFileName(_path);
                tBNameDB.Text = _name;
                MessageBox.Show($"База данных {_name} загружена!");
                string query = "SELECT name FROM sqlite_master WHERE type='table';"; // sql-запрос на формирование списка таблиц
                string tables = string.Empty;
                List<string> _lstTables = DataProcessing.GetDataBySelect(query, _name);
                int counter = 0;
                int _number = 0;
                foreach (string table_name in _lstTables)
                {
                    if (!table_name.Contains("sqlite_"))
                    {
                        tables += table_name + "\r\n";
                    }
                    else
                    {
                        _number = counter;
                    }
                    counter++;
                }
                _lstTables.RemoveAt(_number);                
                lstBoxTables.DataSource = _lstTables;
                MessageBox.Show($"База данных {_name} содержит таблицы:\r\n{tables}");
            }
        }
        // Метод вывода в DataGridView данных из выбранной таблицы выбранной базы данных
        private void lstBoxTables_MouseClick(object sender, MouseEventArgs e)
        {   
            _table = lstBoxTables.SelectedValue.ToString();
            dgvTable.DataSource = DataProcessing.GetData_FromTable(_name, _table).Tables[0];
            dgvTable.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!dgvTable.DataSource.Equals(null))
            {
                dt = (DataTable)dgvTable.DataSource;
                DataProcessing.SaveDataToDB(dt, _name, _table);
            }
            MessageBox.Show("Данные успешно сохранены");
        }
        // Метод удаления выделенных в DataGridView строк
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvTable.SelectedRows)
                dgvTable.Rows.Remove(row);            
        }
    }
}
