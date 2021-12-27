using DBMS.src;
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

namespace DBMS
{
    public partial class Form1 : Form
    {
        DBManager databaseManager = new DBManager();
        string currentFilePath = "";
        string cellOldValue = "";
        string cellNewValue = "";
        public Form1()
        {
            InitializeComponent();
            comboBoxColumnsTypes.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddColumn(tablesControl.SelectedIndex, textBoxAddColumn.Text, comboBoxColumnsTypes.Text))
            {
                int tableIndex = tablesControl.SelectedIndex;
                if (tableIndex != -1)
                {
                    ShowTable(databaseManager.GetTable(tableIndex));
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns.Count == 0) return;
            try
            {
                databaseManager.DeleteColumn(tablesControl.SelectedIndex, dataGridView.CurrentCell.ColumnIndex);
            }
            catch { }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void butCreateDatabase_Click(object sender, EventArgs e)
        {
            if (currentFilePath != String.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Save changings?", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    databaseManager.SaveCurrentDatabase();
                }
            }
            if (databaseManager.CreateDatabase(textBoxCreateDatabase.Text))
            {
                currentFilePath = "";
                tablesControl.TabPages.Clear();
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
            }
        }

        private void butLoadDatabase_Click(object sender, EventArgs e)
        {
            if (currentFilePath != String.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Save changings?", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    databaseManager.SaveCurrentDatabase();
                }
            }
            var databaseName = textBoxLoadDatabase.Text;
            if (!databaseManager.LoadDatabase(databaseName))
            {
                return;
            }
            currentFilePath = databaseName;
            tablesControl.TabPages.Clear();
            List<string> tablesNames = databaseManager.GetTablesNameList();
            foreach (string tableName in tablesNames)
            {
                tablesControl.TabPages.Add(tableName);
            }
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(selectedTableIndex));
            }
        }

        private void ShowTable(Table table)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                foreach (Column column in table.Columns())
                {
                    DataGridViewColumn dataGridColumn;
                    dataGridColumn = new DataGridViewTextBoxColumn();
                    dataGridColumn.Name = column.GetName();
                    dataGridColumn.HeaderText = column.GetName();
                    dataGridView.Columns.Add(dataGridColumn);
                }

                foreach (Row row in table.Rows())
                {
                    DataGridViewRow dataGridRow = new DataGridViewRow();
                    for (int i = 0; i < row.GetValuesList().Count; ++i)
                    {
                        DataGridViewCell cell;
                        var stringCellValue = row.GetValuesList()[i];
                        cell = new DataGridViewTextBoxCell();
                        cell.Value = stringCellValue;
                        dataGridRow.Cells.Add(cell);
                    }
                    try
                    {
                        dataGridView.Rows.Add(dataGridRow);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void butCreateTable_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddTable(textBoxCreateTable.Text))
            {
                tablesControl.TabPages.Add(textBoxCreateTable.Text);
            }
        }

        private void butDeleteTable_Click(object sender, EventArgs e)
        {
            if (tablesControl.TabCount == 0)
            {
                return;
            }
            try
            {
                databaseManager.DeleteTable(tablesControl.SelectedIndex);
                tablesControl.TabPages.RemoveAt(tablesControl.SelectedIndex);
            }
            catch { }
            if (tablesControl.TabCount == 0)
            {
                return;
            }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
               ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void butDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                return;
            }
            try
            {
                databaseManager.DeleteRow(tablesControl.SelectedIndex, dataGridView.CurrentCell.RowIndex);
            }
            catch { }

            int tableIndex = tablesControl.SelectedIndex;
            if (tableIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
            }
        }

        private void butAddRow_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddRow(tablesControl.SelectedIndex))
            {
                int tableIndex = tablesControl.SelectedIndex;
                if (tableIndex != -1)
                {
                    ShowTable(databaseManager.GetTable(tableIndex));
                }
            }
        }

        private bool validateFilter(string filter)
        {
            var nameValue = filter.Split('=');

            return (nameValue.Length == 2);
        }

        private void butTemplateSearch_Click(object sender, EventArgs e) 
        {
            int tableIndex = tablesControl.SelectedIndex;
            string templateSearch = textBoxTemplateSearch.Text;

            if(templateSearch == string.Empty)
            {
                ShowTable(databaseManager.GetTable(tableIndex));
                return;
            }

            var filters = templateSearch.Split(';');

            if(filters.Length != 0)
            {
                List<string[]> Filters = new List<string[]>(); 

                foreach(string filter in filters)
                {
                    if (!validateFilter(filter))
                    {
                        return;
                    }

                    var nameValue = filter.Split('=');
                    Filters.Add(nameValue);
                }

                ShowTable(databaseManager.TemplateSearch(tableIndex, Filters));
            }

            return;
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex == -1)
            {
                return;
            }
            var table = databaseManager.GetTable(selectedTableIndex);
            var currentCellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            cellOldValue = currentCellValue == null ? String.Empty : currentCellValue.ToString();
            return;
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellValue == null)
            {
                return;
            }
            cellNewValue = cellValue.ToString();
            if (!databaseManager.ChangeValue(cellNewValue, tablesControl.SelectedIndex, e.ColumnIndex, e.RowIndex))
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellOldValue;
                return;
            }
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex == -1)
            {
                return;
            }
            var table = databaseManager.GetTable(selectedTableIndex);
            ShowTable(databaseManager.GetTable(selectedTableIndex));
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butSaveDatabase_Click(object sender, EventArgs e)
        {
            databaseManager.SaveCurrentDatabase();
        }

        private void tablesControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tablesIndex = tablesControl.SelectedIndex;
            if (tablesIndex != -1)
            {
                ShowTable(databaseManager.GetTable(tablesIndex));
            }
        }

        private void dataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedTableIndex = tablesControl.SelectedIndex;
            if (selectedTableIndex == -1)
            {
                return;
            }
            var table = databaseManager.GetTable(selectedTableIndex);
            return;
        }

        private void openDatabaseDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialogChooseFilePath_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialogSaveDatabase_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBoxCreateTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddColumn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoadDatabase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
