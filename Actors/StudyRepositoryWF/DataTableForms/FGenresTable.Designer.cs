namespace StudyRepositoryWF.DataTableForms
{
    partial class FGenresTable
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
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenreID = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanelTopCompetition.Controls.Add(this.txtGenre, 1, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblGenreID, 0, 0);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblGenre, 0, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.txtGenreID, 1, 0);
            this.tableLayoutPanelTopCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTopCompetition.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTopCompetition.Name = "tableLayoutPanelTopCompetition";
            this.tableLayoutPanelTopCompetition.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelTopCompetition.RowCount = 2;
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTopCompetition.Size = new System.Drawing.Size(405, 51);
            this.tableLayoutPanelTopCompetition.TabIndex = 2;
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenre.Location = new System.Drawing.Point(161, 29);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(233, 20);
            this.txtGenre.TabIndex = 3;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGenreID.Location = new System.Drawing.Point(10, 2);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(2);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(60, 13);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Код жанру";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGenre.Location = new System.Drawing.Point(10, 28);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(74, 13);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Жанр фільму";
            // 
            // txtGenreID
            // 
            this.txtGenreID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenreID.Location = new System.Drawing.Point(161, 3);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(233, 20);
            this.txtGenreID.TabIndex = 2;
            // 
            // FGenresTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(405, 79);
            this.Controls.Add(this.tableLayoutPanelTopCompetition);
            this.Name = "FGenresTable";
            this.Load += new System.EventHandler(this.FGenresTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelTopCompetition, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanelTopCompetition.ResumeLayout(false);
            this.tableLayoutPanelTopCompetition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopCompetition;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenreID;
    }
}
