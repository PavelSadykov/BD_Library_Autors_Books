using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Библиотека_База_Данных_ввод_с_формы
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        DataTable dtAutors;
        DataTable dtBooks;
        SQLiteDataAdapter adAutors;
        SQLiteDataAdapter adBooks;
       
        string newFilename;
        string filename;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void выбратьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                MessageBox.Show($"Соединение с базой {filename}");
                try
                {
                    conn = new SQLiteConnection("Data Source=" + filename);
                    conn.Open();
                    
                    }
                catch (SQLiteException ex)

                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}");
                }
            }
              
        }
        

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (adAutors != null && dtAutors != null)
                    adAutors.Update(dtAutors);
                if (adBooks != null && dtBooks != null)
                    adBooks.Update(dtBooks);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения изменений {ex.Message}");
            }


            // метод Update: 1) Проверяет таблицу dtAutors на обнаружение  изменений.
            // 2) Генерирует SQL команды на основе изменений в DataTable, 
            // а ранее созданный cb1  помогает автоматически генерировать эти команды.
            //3)Выполняет сгенерированные команды и применяет изменения

        }

        private void DgAutors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void создатьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQLite Database Files|*.db;*.sqlite;*.db3|All Files|*.*";
            saveFileDialog.Title = "Create a New SQLite Database File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                newFilename = saveFileDialog.FileName;

                try
                {
                    SQLiteConnection.CreateFile(newFilename);
                    conn = new SQLiteConnection("Data Source=" + newFilename);

                    conn.Open();

                    string sqltext = @"create table Autors (id INTEGER PRIMARY KEY,
                            name varchar(20), 
                            description varchar(20));
                          create table Books (id INTEGER PRIMARY KEY,
                            id_autor int, name varchar(20), 
                            description varchar(20));";

                    using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    создатьБДToolStripMenuItem.Enabled = false;

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка создания базы данных: " + ex.Message);
                }
                finally
                {
                    conn.Close();

                    MessageBox.Show(" База данных из 2-х таблиц  успешно создана");
                }
            }
        }

        private void autorsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string sqltextA = "SELECT * from Autors"; //SQL запрос:извлекаем все записи(столбцы+строки) из таблицы в базе

            adAutors = new SQLiteDataAdapter(sqltextA, conn);//создаем новый объект-адаптер
                                                             //котороый инициализируется SQL запросом и conn подключением
                                                             //для  дальнейшего заполнения таблицы результатом запроса. 
                                                             // Результат инициализации присваивается переменной  adAutors ,
                                                             // которая является адаптером данных, настроенным на получение данных
                                                             // из таблицы Autors

            SQLiteCommandBuilder cb1 = new SQLiteCommandBuilder(adAutors);//SQLiteCommandBuilder инициализируется с помощью адаптера
                                                                          // и создает команды обновления/удаления
                                                                          //данных в базе для адаптера.
                                                                          //Результат инициализации присваивается переменной cb1

            dtAutors = new DataTable();//инициализируется новый объект (переменная dtAutor) 
                                       //для хранения данных из  таблицы Autors

            adAutors.Fill(dtAutors);//используя адаптер с результатами запроса
                                    //заполняем таблицу (объект dtAutor) результирующими данными

            DgAutors.DataSource = dtAutors;// привязываем DataGridView (DgAutors)   к таблице DataTable 
                                           // для отображения в табличном формате на форме
            dtAutors.Columns[0].AutoIncrement = true;
            dtAutors.Columns[0].AutoIncrementStep = 1;//шаг
                                                      //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
            dtAutors.Columns[0].AutoIncrementSeed = 1;




        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string sqltextB = "SELECT * from Books";
            dtBooks = new DataTable();//инициализируется новый объект (переменная dtAutor) 
                                      //для хранения данных из  таблицы Autors
            adBooks = new SQLiteDataAdapter(sqltextB, conn);//создаем новый объект-адаптер
                                                            //котороый инициализируется SQL запросом и conn подключением
                                                            //для  дальнейшего заполнения таблицы результатом запроса. 
                                                            // Результат инициализации присваивается переменной  adAutors ,
                                                            // которая является адаптером данных, настроенным на получение данных
                                                            // из таблицы Autors

            SQLiteCommandBuilder cb2 = new SQLiteCommandBuilder(adBooks);//SQLiteCommandBuilder инициализируется с помощью адаптера
                                                                         // и создает команды обновления/удаления
                                                                         //данных в базе для адаптера.
                                                                         //Результат инициализации присваивается переменной cb1



            adBooks.Fill(dtBooks);
            DgBooks.DataSource = dtBooks;
            dtBooks.Columns[0].AutoIncrement = true;
            dtBooks.Columns[0].AutoIncrementStep = 1;//шаг
                                                     //dtAutors.Columns[0].AutoIncrementSeed = IncrementSeed("Books");//начальная точка отсчета
            dtBooks.Columns[0].AutoIncrementSeed = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxAutors.SelectedIndex != -1)//выбран ли запрос 
            {
                string selectedOption = comboBoxAutors.SelectedItem.ToString();
                try
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        string query = string.Empty;
                        switch (selectedOption)
                        {
                            case "Автор1":
                           
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 1";
                                break;

                            case "Автор2":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 2";
                                break;

                            case "Автор3":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 3";
                                break;

                            case "Автор4":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 4";
                                break;
                            case "Автор5":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 5";
                                break;
                            case "Автор6":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 6";
                                break;
                            case "Автор7":
                                query = @"SELECT b.id_autors,b.name, a.name AS Autor_Name
                                FROM Books b 
                                INNER JOIN Autors a ON b.id_autors = a.id
                                WHERE b.id_autors = 7";
                                break;
                        }
                        if (!string.IsNullOrEmpty(query))
                        {
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DgBooks.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет соединения с базой");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Выберите запрос перед отправкой команды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxAutors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAutors.Items.Add("Автор1");
            comboBoxAutors.Items.Add("Автор2");
            comboBoxAutors.Items.Add("Автор3");
            comboBoxAutors.Items.Add("Автор4");
            comboBoxAutors.Items.Add("Автор5");
            comboBoxAutors.Items.Add("Автор6");
            comboBoxAutors.Items.Add("Автор7");
        }
    }
    }


