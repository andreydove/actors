namespace StudyFormsLibrary.DataTableForms
{
    partial class EntityTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdCaption = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtFormalName = new System.Windows.Forms.TextBox();
            this.lblFormalNameCaption = new System.Windows.Forms.Label();
            this.lblRegionNameCaption = new System.Windows.Forms.Label();
            this.txtCommonName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionCaption = new System.Windows.Forms.Label();
            this.lblSiteCaption = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblNoteCaption = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdCaption
            // 
            this.lblIdCaption.AutoSize = true;
            this.lblIdCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblIdCaption.Location = new System.Drawing.Point(10, 10);
            this.lblIdCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblIdCaption.Name = "lblIdCaption";
            this.lblIdCaption.Size = new System.Drawing.Size(78, 13);
            this.lblIdCaption.TabIndex = 15;
            this.lblIdCaption.Text = "Ідентифікатор";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(160, 10);
            this.lblId.Margin = new System.Windows.Forms.Padding(2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(108, 18);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "xxxxxxxxxxx";
            // 
            // txtFormalName
            // 
            this.txtFormalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormalName.Location = new System.Drawing.Point(160, 56);
            this.txtFormalName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormalName.Name = "txtFormalName";
            this.txtFormalName.Size = new System.Drawing.Size(407, 20);
            this.txtFormalName.TabIndex = 19;
            // 
            // lblFormalNameCaption
            // 
            this.lblFormalNameCaption.AutoSize = true;
            this.lblFormalNameCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFormalNameCaption.Location = new System.Drawing.Point(10, 56);
            this.lblFormalNameCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblFormalNameCaption.Name = "lblFormalNameCaption";
            this.lblFormalNameCaption.Size = new System.Drawing.Size(89, 13);
            this.lblFormalNameCaption.TabIndex = 21;
            this.lblFormalNameCaption.Text = "Формальне ім\'я";
            // 
            // lblRegionNameCaption
            // 
            this.lblRegionNameCaption.AutoSize = true;
            this.lblRegionNameCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRegionNameCaption.Location = new System.Drawing.Point(10, 32);
            this.lblRegionNameCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblRegionNameCaption.Name = "lblRegionNameCaption";
            this.lblRegionNameCaption.Size = new System.Drawing.Size(59, 13);
            this.lblRegionNameCaption.TabIndex = 22;
            this.lblRegionNameCaption.Text = "Ім\'я особи";
            // 
            // txtCommonName
            // 
            this.txtCommonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommonName.Location = new System.Drawing.Point(160, 32);
            this.txtCommonName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommonName.Name = "txtCommonName";
            this.txtCommonName.Size = new System.Drawing.Size(407, 20);
            this.txtCommonName.TabIndex = 20;
            this.txtCommonName.TextChanged += new System.EventHandler(this.txtCommonName_TextChanged);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.AutoSize = true;
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.lblIdCaption, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.txtFormalName, 1, 3);
            this.tableLayoutPanelTop.Controls.Add(this.lblId, 1, 1);
            this.tableLayoutPanelTop.Controls.Add(this.txtCommonName, 1, 2);
            this.tableLayoutPanelTop.Controls.Add(this.lblFormalNameCaption, 0, 3);
            this.tableLayoutPanelTop.Controls.Add(this.lblRegionNameCaption, 0, 2);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelTop.RowCount = 4;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(577, 78);
            this.tableLayoutPanelTop.TabIndex = 18;
            this.tableLayoutPanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelTop_Paint);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 78);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(577, 146);
            this.pnlMain.TabIndex = 19;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.AutoSize = true;
            this.tableLayoutPanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Controls.Add(this.pnlDescription, 0, 2);
            this.tableLayoutPanelBottom.Controls.Add(this.lblSiteCaption, 0, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.txtSite, 1, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.lblNoteCaption, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.txtNote, 1, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 224);
            this.tableLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tableLayoutPanelBottom.RowCount = 4;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(577, 127);
            this.tableLayoutPanelBottom.TabIndex = 20;
            // 
            // pnlDescription
            // 
            this.tableLayoutPanelBottom.SetColumnSpan(this.pnlDescription, 2);
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Controls.Add(this.lblDescriptionCaption);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(10, 75);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(557, 40);
            this.pnlDescription.TabIndex = 24;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(0, 13);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MinimumSize = new System.Drawing.Size(4, 19);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(557, 27);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescriptionCaption
            // 
            this.lblDescriptionCaption.AutoSize = true;
            this.lblDescriptionCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescriptionCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDescriptionCaption.Location = new System.Drawing.Point(0, 0);
            this.lblDescriptionCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionCaption.Name = "lblDescriptionCaption";
            this.lblDescriptionCaption.Size = new System.Drawing.Size(33, 13);
            this.lblDescriptionCaption.TabIndex = 14;
            this.lblDescriptionCaption.Text = "Опис";
            // 
            // lblSiteCaption
            // 
            this.lblSiteCaption.AutoSize = true;
            this.lblSiteCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSiteCaption.Location = new System.Drawing.Point(10, 51);
            this.lblSiteCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblSiteCaption.Name = "lblSiteCaption";
            this.lblSiteCaption.Size = new System.Drawing.Size(31, 13);
            this.lblSiteCaption.TabIndex = 13;
            this.lblSiteCaption.Text = "Сайт";
            // 
            // txtSite
            // 
            this.txtSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSite.Location = new System.Drawing.Point(160, 51);
            this.txtSite.Margin = new System.Windows.Forms.Padding(2);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(407, 20);
            this.txtSite.TabIndex = 16;
            // 
            // lblNoteCaption
            // 
            this.lblNoteCaption.AutoSize = true;
            this.lblNoteCaption.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNoteCaption.Location = new System.Drawing.Point(10, 2);
            this.lblNoteCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblNoteCaption.Name = "lblNoteCaption";
            this.lblNoteCaption.Size = new System.Drawing.Size(54, 13);
            this.lblNoteCaption.TabIndex = 12;
            this.lblNoteCaption.Text = "Примітка";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(160, 2);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(407, 45);
            this.txtNote.TabIndex = 9;
            // 
            // EntityTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(577, 376);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.MinimumSize = new System.Drawing.Size(18, 381);
            this.Name = "EntityTableForm";
            this.Load += new System.EventHandler(this.EntityTableForm_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelTop, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanelBottom, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblIdCaption;
        protected System.Windows.Forms.Label lblId;
        protected System.Windows.Forms.TextBox txtFormalName;
        protected System.Windows.Forms.Label lblFormalNameCaption;
        protected System.Windows.Forms.Label lblRegionNameCaption;
        protected System.Windows.Forms.TextBox txtCommonName;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Panel pnlDescription;
        protected System.Windows.Forms.TextBox txtDescription;
        protected System.Windows.Forms.Label lblDescriptionCaption;
        protected System.Windows.Forms.Label lblSiteCaption;
        protected System.Windows.Forms.TextBox txtSite;
        protected System.Windows.Forms.Label lblNoteCaption;
        protected System.Windows.Forms.TextBox txtNote;
        protected System.Windows.Forms.Panel pnlMain;
    }
}
