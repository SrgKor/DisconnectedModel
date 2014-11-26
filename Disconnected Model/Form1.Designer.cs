namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Debitors = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingElseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделеннуюСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_RowCount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Credits = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Payments = new System.Windows.Forms.DataGridView();
            this.button_Del = new System.Windows.Forms.Button();
            this.numericUpDown_RowNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_NewInfo = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.numericUpDown_ColumnNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_CurrentCell = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_Search1 = new System.Windows.Forms.Button();
            this.textBox_Search1 = new System.Windows.Forms.TextBox();
            this.button_SaveAsXML = new System.Windows.Forms.Button();
            this.button_ShowAllData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debitors)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credits)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnNumber)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Debitors);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debitors";
            // 
            // dataGridView_Debitors
            // 
            this.dataGridView_Debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Debitors.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_Debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Debitors.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Debitors.Name = "dataGridView_Debitors";
            this.dataGridView_Debitors.Size = new System.Drawing.Size(604, 104);
            this.dataGridView_Debitors.TabIndex = 0;
            this.dataGridView_Debitors.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.somethingElseToolStripMenuItem,
            this.удалитьВыделеннуюСтрокуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 70);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.deleteRowToolStripMenuItem.Text = "Удалить данную строку";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // somethingElseToolStripMenuItem
            // 
            this.somethingElseToolStripMenuItem.Name = "somethingElseToolStripMenuItem";
            this.somethingElseToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.somethingElseToolStripMenuItem.Text = "Count rows";
            this.somethingElseToolStripMenuItem.Click += new System.EventHandler(this.countRowsToolStripMenuItem_Click);
            // 
            // удалитьВыделеннуюСтрокуToolStripMenuItem
            // 
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Name = "удалитьВыделеннуюСтрокуToolStripMenuItem";
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Text = "Удалить выделенную строку";
            this.удалитьВыделеннуюСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделеннуюСтрокуToolStripMenuItem_Click);
            // 
            // button_RowCount
            // 
            this.button_RowCount.Location = new System.Drawing.Point(12, 5);
            this.button_RowCount.Name = "button_RowCount";
            this.button_RowCount.Size = new System.Drawing.Size(75, 23);
            this.button_RowCount.TabIndex = 1;
            this.button_RowCount.Text = "Count Rows";
            this.button_RowCount.UseVisualStyleBackColor = true;
            this.button_RowCount.Click += new System.EventHandler(this.button_RowCount_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rows types";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Accept changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Credits);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credits";
            // 
            // dataGridView_Credits
            // 
            this.dataGridView_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Credits.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Credits.Name = "dataGridView_Credits";
            this.dataGridView_Credits.Size = new System.Drawing.Size(604, 119);
            this.dataGridView_Credits.TabIndex = 6;
            this.dataGridView_Credits.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Payments);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // dataGridView_Payments
            // 
            this.dataGridView_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Payments.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Payments.Name = "dataGridView_Payments";
            this.dataGridView_Payments.Size = new System.Drawing.Size(604, 81);
            this.dataGridView_Payments.TabIndex = 0;
            this.dataGridView_Payments.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(57, 10);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(33, 23);
            this.button_Del.TabIndex = 7;
            this.button_Del.Text = "del";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // numericUpDown_RowNumber
            // 
            this.numericUpDown_RowNumber.Location = new System.Drawing.Point(6, 12);
            this.numericUpDown_RowNumber.Name = "numericUpDown_RowNumber";
            this.numericUpDown_RowNumber.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_RowNumber.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown_RowNumber);
            this.groupBox4.Controls.Add(this.button_Del);
            this.groupBox4.Location = new System.Drawing.Point(326, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 38);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete row";
            // 
            // textBox_NewInfo
            // 
            this.textBox_NewInfo.Location = new System.Drawing.Point(6, 19);
            this.textBox_NewInfo.Name = "textBox_NewInfo";
            this.textBox_NewInfo.Size = new System.Drawing.Size(137, 20);
            this.textBox_NewInfo.TabIndex = 10;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(200, 17);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(43, 23);
            this.button_Edit.TabIndex = 11;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // numericUpDown_ColumnNumber
            // 
            this.numericUpDown_ColumnNumber.Location = new System.Drawing.Point(150, 18);
            this.numericUpDown_ColumnNumber.Name = "numericUpDown_ColumnNumber";
            this.numericUpDown_ColumnNumber.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_ColumnNumber.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_NewInfo);
            this.groupBox5.Controls.Add(this.numericUpDown_ColumnNumber);
            this.groupBox5.Controls.Add(this.button_Edit);
            this.groupBox5.Location = new System.Drawing.Point(12, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 45);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Редактирование столбца";
            // 
            // button_CurrentCell
            // 
            this.button_CurrentCell.Location = new System.Drawing.Point(429, 8);
            this.button_CurrentCell.Name = "button_CurrentCell";
            this.button_CurrentCell.Size = new System.Drawing.Size(75, 23);
            this.button_CurrentCell.TabIndex = 14;
            this.button_CurrentCell.Text = "Current cell";
            this.button_CurrentCell.UseVisualStyleBackColor = true;
            this.button_CurrentCell.Click += new System.EventHandler(this.button_CurrentCell_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Search);
            this.groupBox6.Controls.Add(this.textBox_Search);
            this.groupBox6.Location = new System.Drawing.Point(271, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 45);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поиск в DataTable Debitors по имени";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(191, 18);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(52, 23);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(6, 20);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(179, 20);
            this.textBox_Search.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_Search1);
            this.groupBox7.Controls.Add(this.textBox_Search1);
            this.groupBox7.Location = new System.Drawing.Point(679, 43);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 45);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск в DataTable Debitors по имени";
            // 
            // button_Search1
            // 
            this.button_Search1.Location = new System.Drawing.Point(191, 18);
            this.button_Search1.Name = "button_Search1";
            this.button_Search1.Size = new System.Drawing.Size(52, 23);
            this.button_Search1.TabIndex = 1;
            this.button_Search1.Text = "Search";
            this.button_Search1.UseVisualStyleBackColor = true;
            this.button_Search1.Click += new System.EventHandler(this.button_Search1_Click);
            // 
            // textBox_Search1
            // 
            this.textBox_Search1.Location = new System.Drawing.Point(6, 20);
            this.textBox_Search1.Name = "textBox_Search1";
            this.textBox_Search1.Size = new System.Drawing.Size(179, 20);
            this.textBox_Search1.TabIndex = 0;
            // 
            // button_SaveAsXML
            // 
            this.button_SaveAsXML.Location = new System.Drawing.Point(679, 119);
            this.button_SaveAsXML.Name = "button_SaveAsXML";
            this.button_SaveAsXML.Size = new System.Drawing.Size(126, 35);
            this.button_SaveAsXML.TabIndex = 2;
            this.button_SaveAsXML.Text = "Save DataSet as XML, XSD\r\n";
            this.button_SaveAsXML.UseVisualStyleBackColor = true;
            this.button_SaveAsXML.Click += new System.EventHandler(this.button_SaveAsXML_Click);
            // 
            // button_ShowAllData
            // 
            this.button_ShowAllData.Location = new System.Drawing.Point(679, 167);
            this.button_ShowAllData.Name = "button_ShowAllData";
            this.button_ShowAllData.Size = new System.Drawing.Size(126, 35);
            this.button_ShowAllData.TabIndex = 17;
            this.button_ShowAllData.Text = "Show all data DataTableReader";
            this.button_ShowAllData.UseVisualStyleBackColor = true;
            this.button_ShowAllData.Click += new System.EventHandler(this.button_ShowAllData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 488);
            this.Controls.Add(this.button_ShowAllData);
            this.Controls.Add(this.button_SaveAsXML);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_CurrentCell);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_RowCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Debitors)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Credits)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnNumber)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Debitors;
        private System.Windows.Forms.Button button_RowCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Credits;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Payments;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.NumericUpDown numericUpDown_RowNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingElseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделеннуюСтрокуToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_NewInfo;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.NumericUpDown numericUpDown_ColumnNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_CurrentCell;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_Search1;
        private System.Windows.Forms.TextBox textBox_Search1;
        private System.Windows.Forms.Button button_SaveAsXML;
        private System.Windows.Forms.Button button_ShowAllData;
    }
}

