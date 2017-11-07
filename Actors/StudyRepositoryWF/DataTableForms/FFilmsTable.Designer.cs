namespace StudyRepositoryWF.DataTableForms
{
    partial class FFilmsTable
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
            this.lblFilmName = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.lblStudio = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtStudio = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblFilmName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilmName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStudio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReleaseDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStudio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtReleaseDate, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFilmName.Location = new System.Drawing.Point(10, 2);
            this.lblFilmName.Margin = new System.Windows.Forms.Padding(2);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(77, 13);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Назва фільму";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilmName.Location = new System.Drawing.Point(161, 3);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(358, 20);
            this.txtFilmName.TabIndex = 3;
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStudio.Location = new System.Drawing.Point(10, 28);
            this.lblStudio.Margin = new System.Windows.Forms.Padding(2);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(58, 13);
            this.lblStudio.TabIndex = 2;
            this.lblStudio.Text = "Кіностудія";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblReleaseDate.Location = new System.Drawing.Point(10, 54);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(67, 13);
            this.lblReleaseDate.TabIndex = 1;
            this.lblReleaseDate.Text = "Дата релізу";
            // 
            // txtStudio
            // 
            this.txtStudio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudio.Location = new System.Drawing.Point(161, 29);
            this.txtStudio.Name = "txtStudio";
            this.txtStudio.Size = new System.Drawing.Size(358, 20);
            this.txtStudio.TabIndex = 5;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(161, 55);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseDate.TabIndex = 6;
            // 
            // FFilmsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FFilmsTable";
            this.Load += new System.EventHandler(this.FFilmsTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.Label lblStudio;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtStudio;
        private System.Windows.Forms.TextBox txtReleaseDate;
    }
}
