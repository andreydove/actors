namespace StudyRepositoryWF.DataTableForms
{
    partial class FActorsTable
    {
        /// <summary>
        ///Требуется переменная конструктора.
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmoCountry = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Size = new System.Drawing.Size(557, 64);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Size = new System.Drawing.Size(577, 109);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblBirthDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaritalStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaritalStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAge, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCountry, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAge, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmoCountry, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBirthDate.Location = new System.Drawing.Point(10, 2);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(98, 13);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Дата народження";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMaritalStatus.Location = new System.Drawing.Point(10, 28);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(80, 13);
            this.lblMaritalStatus.TabIndex = 1;
            this.lblMaritalStatus.Text = "Сімейний стан";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2014, 6, 24, 0, 0, 0, 0);
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaritalStatus.Location = new System.Drawing.Point(161, 29);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(405, 20);
            this.txtMaritalStatus.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAge.Location = new System.Drawing.Point(10, 81);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(22, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Вік";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountry.Location = new System.Drawing.Point(10, 54);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(41, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Країна";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(161, 82);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 8;
            // 
            // cmoCountry
            // 
            this.cmoCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmoCountry.FormattingEnabled = true;
            this.cmoCountry.Location = new System.Drawing.Point(161, 55);
            this.cmoCountry.Name = "cmoCountry";
            this.cmoCountry.Size = new System.Drawing.Size(405, 21);
            this.cmoCountry.TabIndex = 7;
            // 
            // FActorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(577, 376);
            this.Name = "FActorsTable";
            this.Load += new System.EventHandler(this.FActorsTable_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmoCountry;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMaritalStatus;
    }
}
