namespace StudyRepositoryWF.DataTableForms
{
    partial class FResultsTable
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
            this.cmoCompetitionID = new System.Windows.Forms.ComboBox();
            this.lblCompetitionID = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblNomination = new System.Windows.Forms.Label();
            this.cmoResult = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblActorIDResults = new System.Windows.Forms.Label();
            this.txtNomination = new System.Windows.Forms.TextBox();
            this.cmoActorIDResults = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Controls.Add(this.cmoCompetitionID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCompetitionID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNomination, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmoResult, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblActorIDResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNomination, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmoActorIDResults, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 135);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmoCompetitionID
            // 
            this.cmoCompetitionID.FormattingEnabled = true;
            this.cmoCompetitionID.Location = new System.Drawing.Point(161, 3);
            this.cmoCompetitionID.Name = "cmoCompetitionID";
            this.cmoCompetitionID.Size = new System.Drawing.Size(121, 21);
            this.cmoCompetitionID.TabIndex = 8;
            // 
            // lblCompetitionID
            // 
            this.lblCompetitionID.AutoSize = true;
            this.lblCompetitionID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompetitionID.Location = new System.Drawing.Point(10, 2);
            this.lblCompetitionID.Margin = new System.Windows.Forms.Padding(2);
            this.lblCompetitionID.Name = "lblCompetitionID";
            this.lblCompetitionID.Size = new System.Drawing.Size(75, 13);
            this.lblCompetitionID.TabIndex = 0;
            this.lblCompetitionID.Text = "Код конкурсу";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblResult.Location = new System.Drawing.Point(10, 108);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Результат";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblYear.Location = new System.Drawing.Point(10, 82);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(22, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Рік";
            // 
            // lblNomination
            // 
            this.lblNomination.AutoSize = true;
            this.lblNomination.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNomination.Location = new System.Drawing.Point(10, 56);
            this.lblNomination.Margin = new System.Windows.Forms.Padding(2);
            this.lblNomination.Name = "lblNomination";
            this.lblNomination.Size = new System.Drawing.Size(57, 13);
            this.lblNomination.TabIndex = 1;
            this.lblNomination.Text = "Номінація";
            // 
            // cmoResult
            // 
            this.cmoResult.FormattingEnabled = true;
            this.cmoResult.Items.AddRange(new object[] {
            "Перемога",
            "Номінація"});
            this.cmoResult.Location = new System.Drawing.Point(161, 109);
            this.cmoResult.Name = "cmoResult";
            this.cmoResult.Size = new System.Drawing.Size(121, 21);
            this.cmoResult.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.Location = new System.Drawing.Point(161, 83);
            this.txtYear.MaximumSize = new System.Drawing.Size(120, 20);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(120, 20);
            this.txtYear.TabIndex = 6;
            // 
            // lblActorIDResults
            // 
            this.lblActorIDResults.AutoSize = true;
            this.lblActorIDResults.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblActorIDResults.Location = new System.Drawing.Point(10, 29);
            this.lblActorIDResults.Margin = new System.Windows.Forms.Padding(2);
            this.lblActorIDResults.Name = "lblActorIDResults";
            this.lblActorIDResults.Size = new System.Drawing.Size(64, 13);
            this.lblActorIDResults.TabIndex = 1;
            this.lblActorIDResults.Text = "Код актора";
            // 
            // txtNomination
            // 
            this.txtNomination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomination.Location = new System.Drawing.Point(161, 57);
            this.txtNomination.Name = "txtNomination";
            this.txtNomination.Size = new System.Drawing.Size(358, 20);
            this.txtNomination.TabIndex = 5;
            // 
            // cmoActorIDResults
            // 
            this.cmoActorIDResults.FormattingEnabled = true;
            this.cmoActorIDResults.Location = new System.Drawing.Point(161, 30);
            this.cmoActorIDResults.Name = "cmoActorIDResults";
            this.cmoActorIDResults.Size = new System.Drawing.Size(121, 21);
            this.cmoActorIDResults.TabIndex = 9;
            // 
            // FResultsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FResultsTable";
            this.Load += new System.EventHandler(this.FResultsTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmoCompetitionID;
        private System.Windows.Forms.Label lblCompetitionID;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblNomination;
        private System.Windows.Forms.ComboBox cmoResult;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblActorIDResults;
        private System.Windows.Forms.TextBox txtNomination;
        private System.Windows.Forms.ComboBox cmoActorIDResults;
    }
}
