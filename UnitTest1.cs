using System.IO;
using Xunit;
using DBMS.src;

using System.Collections.Generic;

namespace DBMSUnitTests
{
    public class UnitTest1
    {
        private readonly string path = "D:/Databases/";
        private readonly string dbFilesExtension = "dbs";

        [Fact]
        public void SaveAndLoadDatabaseFromFS()
        {
            string databaseName = "testDB";
            var databaseManager = new DBManager();
            Assert.True(databaseManager.CreateDatabase(databaseName));
            Assert.True(databaseManager.SaveCurrentDatabase());
            Assert.True(Directory.Exists(path));
            Assert.True(File.Exists($"{path}{databaseName}.{dbFilesExtension}"));
            Assert.True(databaseManager.LoadDatabase(databaseName));
        }

        [Fact]
        public void TemplateSearch_ShouldCreate()
        {  
            var firstColumn = new Column("IntColumn", Constants.integerTypeName);
            var secondColumn = new Column("CharColumn", Constants.charTypeName);
            var thirdColumn = new Column("StringColumn", Constants.stringTypeName);
           
            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };
            
            var firstRow = new Row { valuesList = { "1", "a", "abc" } };
            var secondRow = new Row { valuesList = { "1", "c", "glhf" } };
            var thirdRow = new Row { valuesList = { "2", "a", "abc" } };
            var fourthRow = new Row { valuesList = { "2", "d", "ggwp" } };

            var basicTable = new Table { name = "basic", rowsList = { firstRow, secondRow, thirdRow, fourthRow }, columnsList = columns };
            var resultTable = new Table { name = string.Empty, rowsList = { firstRow, secondRow }, columnsList = columns };

            var Filter = new List<string[]>();
            Filter.Add("IntColumn=1".Split('='));

            var temp = basicTable.templateSearch(Filter);
            
            Assert.True(temp.Equals(resultTable));            
        }
        
        [Fact]
        public void TemplateSearch_ShouldFailDueToIncorrectFilters()
        {
            var firstColumn = new Column("IntColumn", Constants.integerTypeName);
            var secondColumn = new Column("CharColumn", Constants.charTypeName);
            var thirdColumn = new Column("StringColumn", Constants.stringTypeName);

            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };

            var firstRow = new Row { valuesList = { "1", "a", "abc" } };
            var secondRow = new Row { valuesList = { "1", "c", "glhf" } };
            var thirdRow = new Row { valuesList = { "2", "a", "abc" } };
            var fourthRow = new Row { valuesList = { "2", "d", "ggwp" } };

            var basicTable = new Table { name = "basic", rowsList = { firstRow, secondRow, thirdRow, fourthRow }, columnsList = columns };

            var Filter = new List<string[]>();
            Filter.Add("IntColumn=1".Split('='));
            Filter.Add("IntColumn=2".Split('='));

            var temp = basicTable.templateSearch(Filter);

            Assert.True(temp.Equals(new Table(string.Empty, columns, new List<Row>())));
        }
        
        [Fact]
        public void TemplateSearch_ShouldFailDueToNoRecordsMutchFilters()
        {
            var firstColumn = new Column("IntColumn", Constants.integerTypeName);
            var secondColumn = new Column("CharColumn", Constants.charTypeName);
            var thirdColumn = new Column("StringColumn", Constants.stringTypeName);

            var columns = new List<Column>() { firstColumn, secondColumn, thirdColumn };

            var firstRow = new Row { valuesList = { "1", "a", "abc" } };
            var secondRow = new Row { valuesList = { "1", "c", "glhf" } };
            var thirdRow = new Row { valuesList = { "2", "a", "abc" } };
            var fourthRow = new Row { valuesList = { "2", "d", "ggwp" } };

            var basicTable = new Table { name = "basic", rowsList = { firstRow, secondRow, thirdRow, fourthRow }, columnsList = columns };

            var Filter = new List<string[]>();
            Filter.Add("IntColumn=3".Split('='));

            var temp = basicTable.templateSearch(Filter);

            Assert.True(temp.Equals(new Table(string.Empty, columns, new List<Row>())));
        }
        
        [Fact]
        public void  TestValidator_charInvl_Valid()
        {
            var value = "a:z";
            Assert.True(TypesValidator.IsValidValue(Constants.charIntervalTypeName, value));
        }

        [Fact]
        public void TestValidator_charInvl_Invalid_IncorrectInterval()
        {
            var value = "z:a";
            Assert.False(TypesValidator.IsValidValue(Constants.charIntervalTypeName, value));
        }

        [Fact]
        public void TestValidator_charInvl_Invalid_NotCharInterval()
        {
            var value = "12:a";
            Assert.False(TypesValidator.IsValidValue(Constants.charIntervalTypeName, value));
        }
        
        [Fact]
        public void TestValidator_stringInvl_Valid()
        {
            var value = "a:z;1:1;Z:a";
            Assert.True(TypesValidator.IsValidValue(Constants.stringInvlTypeName, value));
        }
        
        [Fact]
        public void TestValidator_stringInvl_Invalid_IncorrectCharInterval()
        {
            var value = "z:a;1:1;Z:a";
            Assert.False(TypesValidator.IsValidValue(Constants.stringInvlTypeName, value));
        }
        
        [Fact]
        public void TestValidator_stringInvl_Invalid_IncorrectSeparator()
        {
            var value = "z:a;1:1/Z:a";
            Assert.False(TypesValidator.IsValidValue(Constants.stringInvlTypeName, value));
        }
    }
}
