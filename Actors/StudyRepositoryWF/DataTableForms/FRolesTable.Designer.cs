namespace StudyRepositoryWF.DataTableForms
{
    partial class FRolesTable
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
            this.cmoFilmIDRoles = new System.Windows.Forms.ComboBox();
            this.lblActorIDRoles = new System.Windows.Forms.Label();
            this.lblFilmIDRoles = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.cmoActorIDRoles = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanelTopCompetition.Controls.Add(this.cmoFilmIDRoles, 1, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblActorIDRoles, 0, 0);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblFilmIDRoles, 0, 1);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.lblRole, 0, 2);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.txtRole, 1, 2);
            this.tableLayoutPanelTopCompetition.Controls.Add(this.cmoActorIDRoles, 1, 0);
            this.tableLayoutPanelTopCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTopCompetition.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTopCompetition.Name = "tableLayoutPanelTopCompetition";
            this.tableLayoutPanelTopCompetition.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelTopCompetition.RowCount = 3;
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopCompetition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopCompetition.Size = new System.Drawing.Size(420, 76);
            this.tableLayoutPanelTopCompetition.TabIndex = 2;
            // 
            // cmoFilmIDRoles
            // 
            this.cmoFilmIDRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmoFilmIDRoles.FormattingEnabled = true;
            this.cmoFilmIDRoles.Location = new System.Drawing.Point(161, 28);
            this.cmoFilmIDRoles.Name = "cmoFilmIDRoles";
            this.cmoFilmIDRoles.Size = new System.Drawing.Size(248, 21);
            this.cmoFilmIDRoles.TabIndex = 5;
            // 
            // lblActorIDRoles
            // 
            this.lblActorIDRoles.AutoSize = true;
            this.lblActorIDRoles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblActorIDRoles.Location = new System.Drawing.Point(10, 2);
            this.lblActorIDRoles.Margin = new System.Windows.Forms.Padding(2);
            this.lblActorIDRoles.Name = "lblActorIDRoles";
            this.lblActorIDRoles.Size = new System.Drawing.Size(64, 13);
            this.lblActorIDRoles.TabIndex = 0;
            this.lblActorIDRoles.Text = "Код актора";
            // 
            // lblFilmIDRoles
            // 
            this.lblFilmIDRoles.AutoSize = true;
            this.lblFilmIDRoles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFilmIDRoles.Location = new System.Drawing.Point(10, 27);
            this.lblFilmIDRoles.Margin = new System.Windows.Forms.Padding(2);
            this.lblFilmIDRoles.Name = "lblFilmIDRoles";
            this.lblFilmIDRoles.Size = new System.Drawing.Size(64, 13);
            this.lblFilmIDRoles.TabIndex = 1;
            this.lblFilmIDRoles.Text = "Код фільму";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRole.Location = new System.Drawing.Point(10, 52);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(75, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Роль у фільмі";
            // 
            // txtRole
            // 
            this.txtRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRole.Location = new System.Drawing.Point(161, 53);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(248, 20);
            this.txtRole.TabIndex = 3;
            // 
            // cmoActorIDRoles
            // 
            this.cmoActorIDRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmoActorIDRoles.FormattingEnabled = true;
            this.cmoActorIDRoles.Location = new System.Drawing.Point(161, 3);
            this.cmoActorIDRoles.Name = "cmoActorIDRoles";
            this.cmoActorIDRoles.Size = new System.Drawing.Size(248, 21);
            this.cmoActorIDRoles.TabIndex = 4;
            // 
            // FRolesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(420, 104);
            this.Controls.Add(this.tableLayoutPanelTopCompetition);
            this.Name = "FRolesTable";
            this.Load += new System.EventHandler(this.FRolesTable_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelTopCompetition, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanelTopCompetition.ResumeLayout(false);
            this.tableLayoutPanelTopCompetition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopCompetition;
        private System.Windows.Forms.ComboBox cmoFilmIDRoles;
        private System.Windows.Forms.Label lblActorIDRoles;
        private System.Windows.Forms.Label lblFilmIDRoles;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.ComboBox cmoActorIDRoles;
    }
}
