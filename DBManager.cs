using System.Collections.Generic;
using System.Linq;

namespace DBMS.src
{
    public class DBManager
    {
        private Database chosenDatabase;
        private FileSystemManager fsManager;
        private readonly string path = "D:/Databases/";
        public DBManager()
        {
            fsManager = new FileSystemManager();
            fsManager.CreateDirectory(path);
        }

        public bool CreateDatabase(string databaseName)
        {
            if (databaseName.Trim().Equals(""))
            {
                return false;
            }
            chosenDatabase = new Database(databaseName);
            return true;
        }

        public bool AddTable(string newTableName)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddTable(newTableName);
        }

        public bool AddTable(Table newTable)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddTable(newTable);
        }


        public Table? GetTable(int index)
        {
           return chosenDatabase.GetTable(index);
        }

        public bool AddColumn(int tableIndex, string columnName, string customTypeName)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddColumn(tableIndex, columnName, customTypeName);
        }

        public bool AddRow(int tableIndex)
        {
            if (chosenDatabase == null)
            {
                return false;
            }
            return chosenDatabase.AddRowToTable(tableIndex);
        }

        public bool ChangeValue(string newValue, int tableIndex, int columnIndex, int rowIndex)
        {
            return chosenDatabase.ChangeValue(newValue, tableIndex, columnIndex, rowIndex);
        }

        public bool DeleteRow(int tableIndex, int rowIndex)
        {
            return chosenDatabase.DeleteRow(tableIndex, rowIndex);
        }

        public bool DeleteColumn(int tableIndex, int columnIndex)
        {
            return chosenDatabase.DeleteColumn(tableIndex, columnIndex);
        }

        public bool DeleteTable(int tableIndex)
        {
           return chosenDatabase.DeleteTable(tableIndex);
        }

        public bool SaveCurrentDatabase()
        {
            return fsManager.SaveDatabaseOnDrive(path, chosenDatabase);
        }

        public bool LoadDatabase(string databaseName)
        {
            if(databaseName != string.Empty)
            {
                chosenDatabase = fsManager.LoadDatabaseFromDrive(path, databaseName);
                return chosenDatabase != null;
            }

            return false;
        }

        public List<string> GetTablesNameList()
        {
            return chosenDatabase.GetTablesNamesList();
        }

        public Table? TablesIntersection(Table firstTable, Table secondTable)
        {
            if (!Enumerable.SequenceEqual(firstTable.Columns(), secondTable.Columns()))
            {
                return null;
            }
            List<Row> intersectedRows = new List<Row>();
            var firstTableRows = firstTable.Rows();
            var secondTableRows = secondTable.Rows();

            for (int firstTableRowIndex = 0; firstTableRowIndex < firstTableRows.Count; ++firstTableRowIndex)
            {
                var firstRow = firstTableRows[firstTableRowIndex];
                for (int secondTableRowIndex = 0; secondTableRowIndex < secondTableRows.Count; ++secondTableRowIndex)
                {
                    var secondRow = secondTableRows[secondTableRowIndex];
                    if (firstRow.Equals(secondRow))
                    {
                        intersectedRows.Add(firstTableRows[firstTableRowIndex]);
                    }
                }
            }
            var resultTable = new Table($"{firstTable.GetName()}IntersectedWith{secondTable.GetName()}", firstTable.Columns(), intersectedRows);
            return resultTable;
        }

        public Table TemplateSearch(int tableIndex, List<string[]> Filters)
        {
            if(chosenDatabase == null)
            {
                return new Table();
            }

            return chosenDatabase.templateSearch(tableIndex, Filters);
        }
    }
}
