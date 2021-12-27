
namespace DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCreateDatabase = new System.Windows.Forms.Button();
            this.textBoxCreateDatabase = new System.Windows.Forms.TextBox();
            this.butLoadDatabase = new System.Windows.Forms.Button();
            this.butSaveDatabase = new System.Windows.Forms.Button();
            this.butCreateTable = new System.Windows.Forms.Button();
            this.textBoxCreateTable = new System.Windows.Forms.TextBox();
            this.butDeleteTable = new System.Windows.Forms.Button();
            this.butAddColumn = new System.Windows.Forms.Button();
            this.textBoxAddColumn = new System.Windows.Forms.TextBox();
            this.butDeleteColumn = new System.Windows.Forms.Button();
            this.comboBoxColumnsTypes = new System.Windows.Forms.ComboBox();
            this.butAddRow = new System.Windows.Forms.Button();
            this.butDeleteRow = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tablesControl = new System.Windows.Forms.TabControl();
            this.openDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogChooseFilePath = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSaveDatabase = new System.Windows.Forms.SaveFileDialog();
            this.textBoxLoadDatabase = new System.Windows.Forms.TextBox();
            this.textBoxTemplateSearch = new System.Windows.Forms.TextBox();
            this.butTemplateSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // butCreateDatabase
            // 
            this.butCreateDatabase.Location = new System.Drawing.Point(14, 38);
            this.butCreateDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCreateDatabase.Name = "butCreateDatabase";
            this.butCreateDatabase.Size = new System.Drawing.Size(139, 28);
            this.butCreateDatabase.TabIndex = 0;
            this.butCreateDatabase.Text = "Create database";
            this.butCreateDatabase.UseVisualStyleBackColor = true;
            this.butCreateDatabase.Click += new System.EventHandler(this.butCreateDatabase_Click);
            // 
            // textBoxCreateDatabase
            // 
            this.textBoxCreateDatabase.Location = new System.Drawing.Point(14, 11);
            this.textBoxCreateDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateDatabase.Name = "textBoxCreateDatabase";
            this.textBoxCreateDatabase.PlaceholderText = "Create Databae Name";
            this.textBoxCreateDatabase.Size = new System.Drawing.Size(139, 23);
            this.textBoxCreateDatabase.TabIndex = 1;
            this.textBoxCreateDatabase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butLoadDatabase
            // 
            this.butLoadDatabase.Location = new System.Drawing.Point(14, 97);
            this.butLoadDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butLoadDatabase.Name = "butLoadDatabase";
            this.butLoadDatabase.Size = new System.Drawing.Size(139, 28);
            this.butLoadDatabase.TabIndex = 2;
            this.butLoadDatabase.Text = "Load database";
            this.butLoadDatabase.UseVisualStyleBackColor = true;
            this.butLoadDatabase.Click += new System.EventHandler(this.butLoadDatabase_Click);
            // 
            // butSaveDatabase
            // 
            this.butSaveDatabase.Location = new System.Drawing.Point(14, 129);
            this.butSaveDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSaveDatabase.Name = "butSaveDatabase";
            this.butSaveDatabase.Size = new System.Drawing.Size(139, 28);
            this.butSaveDatabase.TabIndex = 3;
            this.butSaveDatabase.Text = "Save database";
            this.butSaveDatabase.UseVisualStyleBackColor = true;
            this.butSaveDatabase.Click += new System.EventHandler(this.butSaveDatabase_Click);
            // 
            // butCreateTable
            // 
            this.butCreateTable.Location = new System.Drawing.Point(192, 65);
            this.butCreateTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCreateTable.Name = "butCreateTable";
            this.butCreateTable.Size = new System.Drawing.Size(136, 28);
            this.butCreateTable.TabIndex = 4;
            this.butCreateTable.Text = "Create Table";
            this.butCreateTable.UseVisualStyleBackColor = true;
            this.butCreateTable.Click += new System.EventHandler(this.butCreateTable_Click);
            // 
            // textBoxCreateTable
            // 
            this.textBoxCreateTable.Location = new System.Drawing.Point(192, 38);
            this.textBoxCreateTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateTable.Name = "textBoxCreateTable";
            this.textBoxCreateTable.PlaceholderText = "Create Table Name";
            this.textBoxCreateTable.Size = new System.Drawing.Size(136, 23);
            this.textBoxCreateTable.TabIndex = 5;
            this.textBoxCreateTable.TextChanged += new System.EventHandler(this.textBoxCreateTable_TextChanged);
            // 
            // butDeleteTable
            // 
            this.butDeleteTable.Location = new System.Drawing.Point(192, 97);
            this.butDeleteTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeleteTable.Name = "butDeleteTable";
            this.butDeleteTable.Size = new System.Drawing.Size(136, 28);
            this.butDeleteTable.TabIndex = 6;
            this.butDeleteTable.Text = "Delete Table";
            this.butDeleteTable.UseVisualStyleBackColor = true;
            this.butDeleteTable.Click += new System.EventHandler(this.butDeleteTable_Click);
            // 
            // butAddColumn
            // 
            this.butAddColumn.Location = new System.Drawing.Point(362, 75);
            this.butAddColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAddColumn.Name = "butAddColumn";
            this.butAddColumn.Size = new System.Drawing.Size(135, 28);
            this.butAddColumn.TabIndex = 8;
            this.butAddColumn.Text = "Add Column";
            this.butAddColumn.UseVisualStyleBackColor = true;
            this.butAddColumn.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxAddColumn
            // 
            this.textBoxAddColumn.Location = new System.Drawing.Point(362, 48);
            this.textBoxAddColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddColumn.Name = "textBoxAddColumn";
            this.textBoxAddColumn.PlaceholderText = "Add Column Name";
            this.textBoxAddColumn.Size = new System.Drawing.Size(135, 23);
            this.textBoxAddColumn.TabIndex = 9;
            this.textBoxAddColumn.TextChanged += new System.EventHandler(this.textBoxAddColumn_TextChanged);
            // 
            // butDeleteColumn
            // 
            this.butDeleteColumn.Location = new System.Drawing.Point(362, 107);
            this.butDeleteColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeleteColumn.Name = "butDeleteColumn";
            this.butDeleteColumn.Size = new System.Drawing.Size(135, 28);
            this.butDeleteColumn.TabIndex = 10;
            this.butDeleteColumn.Text = "Delete column";
            this.butDeleteColumn.UseVisualStyleBackColor = true;
            this.butDeleteColumn.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBoxColumnsTypes
            // 
            this.comboBoxColumnsTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnsTypes.FormattingEnabled = true;
            this.comboBoxColumnsTypes.Items.AddRange(new object[] {
            "Integer",
            "String",
            "Char",
            "Real",
            "CharInvl",
            "StringInvl"});
            this.comboBoxColumnsTypes.Location = new System.Drawing.Point(362, 21);
            this.comboBoxColumnsTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxColumnsTypes.Name = "comboBoxColumnsTypes";
            this.comboBoxColumnsTypes.Size = new System.Drawing.Size(135, 23);
            this.comboBoxColumnsTypes.TabIndex = 12;
            // 
            // butAddRow
            // 
            this.butAddRow.Location = new System.Drawing.Point(543, 44);
            this.butAddRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAddRow.Name = "butAddRow";
            this.butAddRow.Size = new System.Drawing.Size(136, 28);
            this.butAddRow.TabIndex = 13;
            this.butAddRow.Text = "Add row";
            this.butAddRow.UseVisualStyleBackColor = true;
            this.butAddRow.Click += new System.EventHandler(this.butAddRow_Click);
            // 
            // butDeleteRow
            // 
            this.butDeleteRow.Location = new System.Drawing.Point(543, 76);
            this.butDeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDeleteRow.Name = "butDeleteRow";
            this.butDeleteRow.Size = new System.Drawing.Size(136, 28);
            this.butDeleteRow.TabIndex = 14;
            this.butDeleteRow.Text = "Delete row";
            this.butDeleteRow.UseVisualStyleBackColor = true;
            this.butDeleteRow.Click += new System.EventHandler(this.butDeleteRow_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 194);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1154, 438);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellLeave);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // tablesControl
            // 
            this.tablesControl.Location = new System.Drawing.Point(14, 161);
            this.tablesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablesControl.Name = "tablesControl";
            this.tablesControl.SelectedIndex = 0;
            this.tablesControl.Size = new System.Drawing.Size(1154, 29);
            this.tablesControl.TabIndex = 19;
            this.tablesControl.SelectedIndexChanged += new System.EventHandler(this.tablesControl_SelectedIndexChanged);
            // 
            // openDatabaseDialog
            // 
            this.openDatabaseDialog.FileName = "openFileDialog1";
            this.openDatabaseDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDatabaseDialog_FileOk);
            // 
            // openFileDialogChooseFilePath
            // 
            this.openFileDialogChooseFilePath.FileName = "openFileDialog1";
            this.openFileDialogChooseFilePath.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogChooseFilePath_FileOk);
            // 
            // saveFileDialogSaveDatabase
            // 
            this.saveFileDialogSaveDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogSaveDatabase_FileOk);
            // 
            // textBoxLoadDatabase
            // 
            this.textBoxLoadDatabase.Location = new System.Drawing.Point(14, 70);
            this.textBoxLoadDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoadDatabase.Name = "textBoxLoadDatabase";
            this.textBoxLoadDatabase.PlaceholderText = "Load Database Name";
            this.textBoxLoadDatabase.Size = new System.Drawing.Size(139, 23);
            this.textBoxLoadDatabase.TabIndex = 20;
            this.textBoxLoadDatabase.TextChanged += new System.EventHandler(this.textBoxLoadDatabase_TextChanged);
            // 
            // textBoxTemplateSearch
            // 
            this.textBoxTemplateSearch.Location = new System.Drawing.Point(859, 65);
            this.textBoxTemplateSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTemplateSearch.Name = "textBoxTemplateSearch";
            this.textBoxTemplateSearch.PlaceholderText = "ColumnName1=\'Value1\'; ColumnName2=\'Value2\' ...";
            this.textBoxTemplateSearch.Size = new System.Drawing.Size(301, 23);
            this.textBoxTemplateSearch.TabIndex = 16;
            // 
            // butTemplateSearch
            // 
            this.butTemplateSearch.Location = new System.Drawing.Point(718, 65);
            this.butTemplateSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butTemplateSearch.Name = "butTemplateSearch";
            this.butTemplateSearch.Size = new System.Drawing.Size(135, 23);
            this.butTemplateSearch.TabIndex = 15;
            this.butTemplateSearch.Text = "Template Search";
            this.butTemplateSearch.UseVisualStyleBackColor = true;
            this.butTemplateSearch.Click += new System.EventHandler(this.butTemplateSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 562);
            this.Controls.Add(this.textBoxLoadDatabase);
            this.Controls.Add(this.tablesControl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxTemplateSearch);
            this.Controls.Add(this.butTemplateSearch);
            this.Controls.Add(this.butDeleteRow);
            this.Controls.Add(this.butAddRow);
            this.Controls.Add(this.comboBoxColumnsTypes);
            this.Controls.Add(this.butDeleteColumn);
            this.Controls.Add(this.textBoxAddColumn);
            this.Controls.Add(this.butAddColumn);
            this.Controls.Add(this.butDeleteTable);
            this.Controls.Add(this.textBoxCreateTable);
            this.Controls.Add(this.butCreateTable);
            this.Controls.Add(this.butSaveDatabase);
            this.Controls.Add(this.butLoadDatabase);
            this.Controls.Add(this.textBoxCreateDatabase);
            this.Controls.Add(this.butCreateDatabase);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCreateDatabase;
        private System.Windows.Forms.TextBox textBoxCreateDatabase;
        private System.Windows.Forms.Button butLoadDatabase;
        private System.Windows.Forms.Button butSaveDatabase;
        private System.Windows.Forms.Button butCreateTable;
        private System.Windows.Forms.TextBox textBoxCreateTable;
        private System.Windows.Forms.Button butDeleteTable;
        private System.Windows.Forms.Button butAddColumn;
        private System.Windows.Forms.TextBox textBoxAddColumn;
        private System.Windows.Forms.Button butDeleteColumn;
        private System.Windows.Forms.ComboBox comboBoxColumnsTypes;
        private System.Windows.Forms.Button butAddRow;
        private System.Windows.Forms.Button butDeleteRow;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tablesControl;
        private System.Windows.Forms.OpenFileDialog openDatabaseDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogChooseFilePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveDatabase;
        private System.Windows.Forms.TextBox textBoxLoadDatabase;
        private System.Windows.Forms.TextBox textBoxTemplateSearch;
        private System.Windows.Forms.Button butTemplateSearch;
    }
}

