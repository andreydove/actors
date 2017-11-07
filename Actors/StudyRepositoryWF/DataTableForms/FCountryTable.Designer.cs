namespace StudyRepositoryWF.DataTableForms
{
    partial class FCountryTable
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
            this.tableLayoutPanelTopCountry = new System.Windows.Forms.TableLayoutPanel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountryID = new System.Windows.Forms.Label();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanelTopCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTopCountry
            // 
            this.tableLayoutPanelTopCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelTopCountry.ColumnCount = 2;
            this.tableLayoutPanelTopCountry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelTopCountry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTopCountry.Controls.Add(this.txtCountry, 1, 1);
            this.tableLayoutPanelTopCountry.Controls.Add(this.lblCountryID, 0, 0);
            this.tableLayoutPanelTopCountry.Controls.Add(this.lblCompetition, 0, 1);
            this.tableLayoutPanelTopCountry.Controls.Add(this.txtCountryID, 1, 0);
            this.tableLayoutPanelTopCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTopCountry.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTopCountry.Name = "tableLayoutPanelTopCountry";
            this.tableLayoutPanelTopCountry.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelTopCountry.RowCount = 2;
            this.tableLayoutPanelTopCountry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCountry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCountry.Size = new System.Drawing.Size(363, 51);
            this.tableLayoutPanelTopCountry.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Location = new System.Drawing.Point(161, 29);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(191, 20);
            this.txtCountry.TabIndex = 3;
            // 
            // lblCountryID
            // 
            this.lblCountryID.AutoSize = true;
            this.lblCountryID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountryID.Location = new System.Drawing.Point(10, 2);
            this.lblCountryID.Margin = new System.Windows.Forms.Padding(2);
            this.lblCountryID.Name = "lblCountryID";
            this.lblCountryID.Size = new System.Drawing.Size(62, 13);
            this.lblCountryID.TabIndex = 0;
            this.lblCountryID.Text = "Код країни";
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompetition.Location = new System.Drawing.Point(10, 28);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(41, 13);
            this.lblCompetition.TabIndex = 1;
            this.lblCompetition.Text = "Країна";
            // 
            // txtCountryID
            // 
            this.txtCountryID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountryID.Location = new System.Drawing.Point(161, 3);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(191, 20);
            this.txtCountryID.TabIndex = 2;
            // 
            // FCountryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(363, 77);
            this.Controls.Add(this.tableLayoutPanelTopCountry);
            this.Name = "FCountryTable";
            this.Load += new System.EventHandler(this.FCountryTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelTopCountry, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanelTopCountry.ResumeLayout(false);
            this.tableLayoutPanelTopCountry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountryID;
        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.TextBox txtCountryID;
    }
}
