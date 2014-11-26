// Disconnected Model

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataSet BANK;   // Локальная копия БД
        DataTable tableDebitors, tableCredits, tablePayments;

        BindingSource bindingSource;
        DataView dataView;

        public Form1()
        {
            InitializeComponent();

            // Создаем объекты таблиц
            CreateDebitorsTable();
            CreateCreditsTable();
            CreatePaymentsTable();

            BANK = new DataSet("BANK");
            //BANK.ReadXml("BANK.xml");
            //BANK.ReadXmlSchema("BANKschema.xsd");
            BANK.Tables.AddRange(new DataTable[] { tableDebitors, tableCredits, tablePayments });
            BANK.ExtendedProperties["info"] = "Developer: Sergey Korolev";

            // Задание взаимосвязей между таблицами.
            CreateRelationships();

            // Назначаем источники данных для всеъх дата грид вью
            dataGridView_Debitors.DataSource = BANK.Tables[0];
            dataGridView_Credits.DataSource = BANK.Tables[1];
            dataGridView_Payments.DataSource = BANK.Tables[2];
        }

        // Таблица Debitors
        private void CreateDebitorsTable()
        {
            // Создаем объект таблица
            tableDebitors = new DataTable("Debitors");

            // Создаем объекты столбцы и задаем их свойства
            DataColumn columnID = new DataColumn("ID", typeof(Guid));
            columnID.ColumnMapping = MappingType.Attribute;
            columnID.Caption = "Ай Ди";
            columnID.ReadOnly = false;
            columnID.AllowDBNull = false;
            columnID.Unique = true;
            columnID.AutoIncrement = false;

            DataColumn columnName = new DataColumn("Name", typeof(string));
            columnName.Caption = "Имя";
            columnName.AllowDBNull = false;

            DataColumn columnNumber = new DataColumn("Number", typeof(int));
            columnNumber.Caption = "Номер";
            columnNumber.AllowDBNull = false;

            DataColumn columnPhoneNumber = new DataColumn("PhoneNumber", typeof(string));
            columnPhoneNumber.Caption = "Телефон";
            columnPhoneNumber.AllowDBNull = true;

            // В таблицу заносим определенные ранее столбцы
            tableDebitors.Columns.AddRange(new DataColumn[] { columnID, columnName, columnNumber, columnPhoneNumber });

            // Заносим данные построчно
            DataRow rowDebitor = tableDebitors.NewRow();
            rowDebitor["ID"] = Guid.NewGuid();
            rowDebitor["Name"] = "Гудок Александр";
            rowDebitor["Number"] = "2345";
            rowDebitor["PhoneNumber"] = "+38 535 45 45";
            tableDebitors.Rows.Add(rowDebitor);

            DataRow row = tableDebitors.NewRow();
            row["ID"] = Guid.NewGuid();
            row["Name"] = "Набоков Алексей Владимирович";
            row["Number"] = 3445;
            row["PhoneNumber"] = "8-903-232-44-32";
            tableDebitors.Rows.Add(row);

            row = tableDebitors.NewRow();
            row["ID"] = Guid.NewGuid();
            row["Name"] = "Гриб Екатерина Сергеевна";
            row["Number"] = 9445;
            row["PhoneNumber"] = "8-(495)-157-2362";
            tableDebitors.Rows.Add(row);

            row = tableDebitors.NewRow();
            row["ID"] = Guid.NewGuid();
            row["Name"] = "Бруталова Инна Марковна";
            row["Number"] = 9435;
            row["PhoneNumber"] = "8-(123)-197-5562";
            tableDebitors.Rows.Add(row);

            dataView = new DataView(tableDebitors, "", String.Empty, DataViewRowState.Added);
            
        }

        // Таблица Credits
        private void CreateCreditsTable()
        {
            // Создаем объект таблица
            tableCredits = new DataTable("Credits");

            #region Создаем объекты столбцы и задаем их свойства
            DataColumn dataColumn = new DataColumn("ID", typeof(Guid));
            dataColumn.Caption = "Кредит ID";
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AllowDBNull = false;
            dataColumn.AutoIncrement = false;
            tableCredits.Columns.Add(dataColumn);

            dataColumn = new DataColumn("DebitorID", typeof(Guid));
            dataColumn.Caption = "Дебитор ID";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tableCredits.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Amount", typeof(int));
            dataColumn.Caption = "Сумма";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tableCredits.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Balance", typeof(int));
            dataColumn.Caption = "Баланс";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tableCredits.Columns.Add(dataColumn);

            dataColumn = new DataColumn("OpeningDate", typeof(DateTime));
            dataColumn.Caption = "Дата";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tableCredits.Columns.Add(dataColumn);
            #endregion

        }

        // Таблица Payments
        private void CreatePaymentsTable()
        {
            // Создаем объект таблица
            tablePayments = new DataTable("Payments");

            #region Создаем объекты столбцы и задаем их свойства
            DataColumn dataColumn = new DataColumn("ID", typeof(Guid));
            dataColumn.Caption = "Платеж ID";
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AllowDBNull = false;
            dataColumn.AutoIncrement = false;
            tablePayments.Columns.Add(dataColumn);

            dataColumn = new DataColumn("CreditID", typeof(Guid));
            dataColumn.Caption = "Кредит ID";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tablePayments.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Amount", typeof(int));
            dataColumn.Caption = "Сумма платежа";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tablePayments.Columns.Add(dataColumn);

            dataColumn = new DataColumn("PaymentDate", typeof(DateTime));
            dataColumn.Caption = "Дата платежа";
            dataColumn.ReadOnly = false;
            dataColumn.AllowDBNull = false;
            tablePayments.Columns.Add(dataColumn);
            #endregion
        }

        // Задание взаимосвязей между таблицами.
        private void CreateRelationships()
        {
            DataRelation dr = new DataRelation("Debitor_Credits", 
                BANK.Tables["Debitors"].Columns["ID"],
                BANK.Tables["Credits"].Columns["DebitorID"]);
            BANK.Relations.Add(dr);

            dr = new DataRelation("Credit_Payments",
                BANK.Tables["Credits"].Columns["ID"],
                BANK.Tables["Payments"].Columns["CreditID"]);
            BANK.Relations.Add(dr);
        }

        // кнопка подсчитать кол-во строк в объекте таблица Debitors
        private void button_RowCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tableDebitors.Rows.Count: " + tableDebitors.Rows.Count.ToString());
        }

        // кнопка добавить определенную строку в дата тейбл Debitors
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow newRow = tableDebitors.NewRow();
            newRow["ID"] = Guid.NewGuid();
            newRow["Name"] = "Сергей Королев";
            newRow["Number"] = "4345";
            newRow["PhoneNumber"] = "+38 535 45 45";
            tableDebitors.Rows.Add(newRow);
        }

        // кнопка показать RowState для всех строк таблицы Debitors
        private void button2_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            foreach (DataRow row in tableDebitors.Rows)
                message += row.RowState + Environment.NewLine;

            MessageBox.Show(message);
        }

        // Метод AcceptChanges -- фиксирование изменений (во всех таблицах). Кнопка Accept changes
        private void button3_Click(object sender, EventArgs e)
        {
           //foreach (DataRow row in tableDebitors.Rows)
           //{
           //    row.AcceptChanges();
           //}
           tableDebitors.AcceptChanges();
           tableCredits.AcceptChanges();
           tablePayments.AcceptChanges();
        }

        // Объект для отслеживания  координат ячейки, над которой помещен курсор
        private Point point = new Point();

        // Событие CellMouseEnter -- наведение мышки на ячейку
        private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Трюк Слежка за курсором
            //if (e.ColumnIndex > -1 && e.RowIndex > -1)
            //    (sender as DataGridView).CurrentCell = ((DataGridView)sender)[e.ColumnIndex, e.RowIndex];

            point.X = e.ColumnIndex;
            point.Y = e.RowIndex;
        }

        // Кнопка Удаление строки
        private void button_Del_Click(object sender, EventArgs e)
        {
            int rowNumberToDelete = int.Parse(numericUpDown_RowNumber.Value.ToString());
            if(rowNumberToDelete < tableDebitors.Rows.Count)
                BANK.Tables["Debitors"].Rows[rowNumberToDelete].Delete();
        }

        // Контекстное меню -> Delete row
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Удаление CurrentRow
            //if(dataGridView_Debitors.CurrentRow.Index < tableDebitors.Rows.Count)
            //    tableDebitors.Rows[dataGridView_Debitors.CurrentRow.Index].Delete();
            if(point.Y > -1 && point.Y < tableDebitors.Rows.Count)
                tableDebitors.Rows[point.Y].Delete();

        }

        // Кнопка подсчет кол-ва строк
        private void countRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tableDebitors.Rows.Count: " + tableDebitors.Rows.Count.ToString());
        }

        // Контекстное меню -- удалить выделенную строку
        private void удалитьВыделеннуюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDebitors.Rows[dataGridView_Debitors.CurrentRow.Index].Delete();
        }

        // Кнопка изменить значение в ячейке с номером из numericUpDown_ColumnNumber во всех строках
        private void button_Edit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableDebitors.Rows.Count; i++ )
            {
                tableDebitors.Rows[i][int.Parse(numericUpDown_ColumnNumber.Value.ToString())] = textBox_NewInfo.Text;
            }
        }

        // Кнопка вывод информации о выделенной ячейке дата грид вью
        private void button_CurrentCell_Click(object sender, EventArgs e)
        {
            int column = dataGridView_Debitors.CurrentCell.ColumnIndex;
            int row = dataGridView_Debitors.CurrentCell.RowIndex;
            string currentValue = tableDebitors.Rows[row][column].ToString();
            MessageBox.Show("Row: " + row.ToString()+ "\nColumn: " + column.ToString() + "\n" + "Value: "+
                dataGridView_Debitors.CurrentCell.Value.ToString());
        }

        // Кнопка Search -- выборка в DataTable с выводом в окне MessageBox
        private void button_Search_Click(object sender, EventArgs e)
        {
            string filterExpression = "Name LIKE '%" + textBox_Search.Text + "%'";
            DataRow[] searchedRows = tableDebitors.Select(filterExpression, "Name DESC");
            string resultToDisplay = String.Empty;
            foreach (DataRow row in searchedRows)
            {
                resultToDisplay += "\n" + row[1] + "  (Тел.: " + row[3] + " )";
            }
            MessageBox.Show(resultToDisplay);
        }

        private void button_Search1_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource(BANK, "Debitors");
            bindingSource.Filter = "Name LIKE '%" + textBox_Search1.Text + "%'";
            bindingSource.Sort = "Name DESC";
            dataGridView_Debitors.DataSource = bindingSource;
        }

        // Кнопка Save DataSet as XML and XSD
        private void button_SaveAsXML_Click(object sender, EventArgs e)
        {
            BANK.WriteXml("BANK.xml");
            BANK.WriteXmlSchema("BANKschema.xsd");
        }

        // Демонстрация работы с объектом DataTableReader
        private void button_ShowAllData_Click(object sender, EventArgs e)
        {
            DataTableReader dtReader = tableDebitors.CreateDataReader();
            if (!dtReader.HasRows)
            {
                MessageBox.Show("Нет строк!");
                return;
            }
            string message = "";
            while(dtReader.Read())
            {
                for (int i = 0; i < dtReader.FieldCount; i++ )
                    message += String.Format(" {0} = {1}", dtReader.GetName(i), dtReader.GetValue(i));
                message += "\n\n";
            }
            MessageBox.Show(message);
        }
    }
}
