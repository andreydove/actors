namespace StudyRepositoryWF.DataTableForms
{
    partial class FCompetitionTable
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
            this.tableLayoutPanelTopCompetition = new System.Windows.Forms.TableLayoutPanel();
            this.txtCompetition = new System.Windows.Forms.TextBox();
            this.lblCompetitionID = new System.Windows.Forms.Label();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.txtCompetitionID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanelTopCompetition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTopCompetition
            // 
            this.tableLayoutPanelTopCompetition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelTopCompetition.ColumnCount = 2;
            this.tableLayoutPanelTopCompetition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelTopCompetition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTopCompetition.Controls.Add(this.txtCompetition, 1, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblCompetitionID, 0, 0);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblCompetition, 0, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.txtCompetitionID, 1, 0);
            this.tableLayoutPanelTopCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTopCompetition.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTopCompetition.Name = "tableLayoutPanelTopCompetition";
            this.tableLayoutPanelTopCompetition.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelTopCompetition.RowCount = 2;
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCompetition.Size = new System.Drawing.Size(461, 51);
            this.tableLayoutPanelTopCompetition.TabIndex = 1;
            this.tableLayoutPanelTopCompetition.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTopCompetition_Paint);
            // 
            // txtCompetition
            // 
            this.txtCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompetition.Location = new System.Drawing.Point(161, 29);
            this.txtCompetition.Name = "txtCompetition";
            this.txtCompetition.Size = new System.Drawing.Size(289, 20);
            this.txtCompetition.TabIndex = 3;
            // 
            // lblCompetitionID
            // 
            this.lblCompetitionID.AutoSize = true;
            this.lblCompetitionID.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetitionID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompetitionID.Location = new System.Drawing.Point(10, 2);
            this.lblCompetitionID.Margin = new System.Windows.Forms.Padding(2);
            this.lblCompetitionID.Name = "lblCompetitionID";
            this.lblCompetitionID.Size = new System.Drawing.Size(75, 13);
            this.lblCompetitionID.TabIndex = 0;
            this.lblCompetitionID.Text = "Код конкурсу";
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetition.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompetition.Location = new System.Drawing.Point(10, 28);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(88, 13);
            this.lblCompetition.TabIndex = 1;
            this.lblCompetition.Text = "Назва конкурсу";
            // 
            // txtCompetitionID
            // 
            this.txtCompetitionID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompetitionID.Location = new System.Drawing.Point(161, 3);
            this.txtCompetitionID.Name = "txtCompetitionID";
            this.txtCompetitionID.Size = new System.Drawing.Size(289, 20);
            this.txtCompetitionID.TabIndex = 2;
            // 
            // FCompetitionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(461, 82);
            this.Controls.Add(this.tableLayoutPanelTopCompetition);
            this.Name = "FCompetitionTable";
            this.Load += new System.EventHandler(this.FCompetitionTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelTopCompetition, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanelTopCompetition.ResumeLayout(false);
            this.tableLayoutPanelTopCompetition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopCompetition;
        private System.Windows.Forms.TextBox txtCompetition;
        private System.Windows.Forms.Label lblCompetitionID;
        private System.Windows.Forms.Label lblCompetition;
        private System.Windows.Forms.TextBox txtCompetitionID;
    }
}
