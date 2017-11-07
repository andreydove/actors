namespace StudyRepositoryWF
{
    partial class FRepository
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRepository));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveXSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordsUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolPanels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolPanelsStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripPanelTop = new System.Windows.Forms.ToolStripPanel();
            this.toolStripStandard = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPanelLeft = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanelRight = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanelBottom = new System.Windows.Forms.ToolStripPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.btnTableForm = new System.Windows.Forms.Button();
            this.lblTables = new System.Windows.Forms.Label();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStripPanelTop.SuspendLayout();
            this.toolStripStandard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecords,
            this.mnuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileClose,
            this.mnuFileOpen,
            this.mnuFileSeparator1,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileSaveXSchema,
            this.mnuFileSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "&Файл";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(186, 22);
            this.mnuFileNew.Text = "&Створити...";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(186, 22);
            this.mnuFileClose.Text = "За&крити";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(186, 22);
            this.mnuFileOpen.Text = "&Відкрити...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Name = "mnuFileSeparator1";
            this.mnuFileSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(186, 22);
            this.mnuFileSave.Text = "&Зберегти";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileSaveAs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(186, 22);
            this.mnuFileSaveAs.Text = "Зберегти &як...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuFileSaveXSchema
            // 
            this.mnuFileSaveXSchema.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileSaveXSchema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileSaveXSchema.Name = "mnuFileSaveXSchema";
            this.mnuFileSaveXSchema.Size = new System.Drawing.Size(186, 22);
            this.mnuFileSaveXSchema.Text = "З&берегти схему XML";
            this.mnuFileSaveXSchema.Click += new System.EventHandler(this.mnuFileSaveXmlSchema_Click);
            // 
            // mnuFileSeparator2
            // 
            this.mnuFileSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileSeparator2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuFileSeparator2.Name = "mnuFileSeparator2";
            this.mnuFileSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.BackColor = System.Drawing.SystemColors.Control;
            this.mnuFileExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(186, 22);
            this.mnuFileExit.Text = "Ви&хід";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuRecords
            // 
            this.mnuRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecordsUndo,
            this.mnuRecordsUpdate});
            this.mnuRecords.Name = "mnuRecords";
            this.mnuRecords.Size = new System.Drawing.Size(59, 20);
            this.mnuRecords.Text = "&Записи";
            // 
            // mnuRecordsUndo
            // 
            this.mnuRecordsUndo.Name = "mnuRecordsUndo";
            this.mnuRecordsUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuRecordsUndo.Size = new System.Drawing.Size(222, 22);
            this.mnuRecordsUndo.Text = "Відмінити введення";
            this.mnuRecordsUndo.Click += new System.EventHandler(this.mnuRecordsUndo_Click);
            // 
            // mnuRecordsUpdate
            // 
            this.mnuRecordsUpdate.Name = "mnuRecordsUpdate";
            this.mnuRecordsUpdate.Size = new System.Drawing.Size(222, 22);
            this.mnuRecordsUpdate.Text = "Поновити";
            this.mnuRecordsUpdate.Click += new System.EventHandler(this.mnuRecordsUpdate_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolPanels});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(57, 20);
            this.mnuView.Text = "Вигляд";
            // 
            // mnuViewToolPanels
            // 
            this.mnuViewToolPanels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolPanelsStandard});
            this.mnuViewToolPanels.Name = "mnuViewToolPanels";
            this.mnuViewToolPanels.Size = new System.Drawing.Size(185, 22);
            this.mnuViewToolPanels.Text = "Панелі інструментів";
            // 
            // mnuViewToolPanelsStandard
            // 
            this.mnuViewToolPanelsStandard.Checked = true;
            this.mnuViewToolPanelsStandard.CheckOnClick = true;
            this.mnuViewToolPanelsStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolPanelsStandard.Name = "mnuViewToolPanelsStandard";
            this.mnuViewToolPanelsStandard.Size = new System.Drawing.Size(137, 22);
            this.mnuViewToolPanelsStandard.Text = "Стандартна";
            this.mnuViewToolPanelsStandard.Click += new System.EventHandler(this.mnuViewToolPanelsStandard_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripPanelTop
            // 
            this.toolStripPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripPanelTop.Controls.Add(this.toolStripStandard);
            this.toolStripPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanelTop.Location = new System.Drawing.Point(0, 24);
            this.toolStripPanelTop.Name = "toolStripPanelTop";
            this.toolStripPanelTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanelTop.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanelTop.Size = new System.Drawing.Size(539, 25);
            // 
            // toolStripStandard
            // 
            this.toolStripStandard.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1});
            this.toolStripStandard.Location = new System.Drawing.Point(13, 0);
            this.toolStripStandard.Name = "toolStripStandard";
            this.toolStripStandard.Size = new System.Drawing.Size(87, 25);
            this.toolStripStandard.TabIndex = 0;
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "toolStripButton1";
            this.toolStripButtonNew.ToolTipText = "Створити файл";
            this.toolStripButtonNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "toolStripButton2";
            this.toolStripButtonOpen.ToolTipText = "Відкрити файл";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton3";
            this.toolStripButtonSave.ToolTipText = "Зберегти файл";
            this.toolStripButtonSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPanelLeft
            // 
            this.toolStripPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripPanelLeft.Location = new System.Drawing.Point(0, 49);
            this.toolStripPanelLeft.Name = "toolStripPanelLeft";
            this.toolStripPanelLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanelLeft.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanelLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // toolStripPanelRight
            // 
            this.toolStripPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripPanelRight.Location = new System.Drawing.Point(539, 49);
            this.toolStripPanelRight.Name = "toolStripPanelRight";
            this.toolStripPanelRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanelRight.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanelRight.Size = new System.Drawing.Size(0, 345);
            // 
            // toolStripPanelBottom
            // 
            this.toolStripPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripPanelBottom.Location = new System.Drawing.Point(0, 394);
            this.toolStripPanelBottom.Name = "toolStripPanelBottom";
            this.toolStripPanelBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanelBottom.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanelBottom.Size = new System.Drawing.Size(539, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel2.Controls.Add(this.btnTableForm);
            this.splitContainer1.Panel2.Controls.Add(this.lblTables);
            this.splitContainer1.Panel2.Controls.Add(this.lstTables);
            this.splitContainer1.Size = new System.Drawing.Size(539, 345);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonUpdate,
            this.toolStripButtonUndo});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 320);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(353, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "Поновити записи";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.mnuRecordsUndo_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Відмінити введення";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.mnuRecordsUndo_Click);
            // 
            // btnTableForm
            // 
            this.btnTableForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTableForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTableForm.Location = new System.Drawing.Point(95, 5);
            this.btnTableForm.Name = "btnTableForm";
            this.btnTableForm.Size = new System.Drawing.Size(75, 23);
            this.btnTableForm.TabIndex = 2;
            this.btnTableForm.Text = "Форма";
            this.btnTableForm.UseVisualStyleBackColor = false;
            this.btnTableForm.Click += new System.EventHandler(this.btnTableForm_Click);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTables.Location = new System.Drawing.Point(24, 10);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(46, 13);
            this.lblTables.TabIndex = 1;
            this.lblTables.Text = "Таблиці";
            // 
            // lstTables
            // 
            this.lstTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTables.BackColor = System.Drawing.Color.White;
            this.lstTables.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(11, 31);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(159, 290);
            this.lstTables.TabIndex = 0;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            this.lstTables.DoubleClick += new System.EventHandler(this.btnTableForm_Click);
            // 
            // FRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 416);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripPanelBottom);
            this.Controls.Add(this.toolStripPanelRight);
            this.Controls.Add(this.toolStripPanelLeft);
            this.Controls.Add(this.toolStripPanelTop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRepository";
            this.Text = "StudyRepository";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRepository_FormClosing);
            this.Load += new System.EventHandler(this.FRepository_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripPanelTop.ResumeLayout(false);
            this.toolStripPanelTop.PerformLayout();
            this.toolStripStandard.ResumeLayout(false);
            this.toolStripStandard.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripPanel toolStripPanelTop;
        private System.Windows.Forms.ToolStrip toolStripStandard;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripPanel toolStripPanelLeft;
        private System.Windows.Forms.ToolStripPanel toolStripPanelRight;
        private System.Windows.Forms.ToolStripPanel toolStripPanelBottom;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveXSchema;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.ToolStripMenuItem mnuRecords;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordsUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordsUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewToolPanels;
        private System.Windows.Forms.ToolStripMenuItem mnuViewToolPanelsStandard;
        private System.Windows.Forms.Button btnTableForm;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator1;
    }
}

