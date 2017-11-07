using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyFormsLibrary.DataTableForms
{

    public delegate void VoidMethod();

    public partial class BaseTableForm : Form
    {

        private VoidMethod saveDataMethod;

        public event EventHandler<EventArgs> RecordsUpdated;

        private void OnRecordsUpdated(EventArgs e)
        {
            if (RecordsUpdated != null) RecordsUpdated(this, e);
        }

        protected DataSet dataSet;

        protected string tableName;

        protected BindingSource bindingSource =
            new BindingSource();

        protected virtual void VerifyDataSet()
        {
            if (!dataSet.Tables.Contains(tableName))
            {
                throw new Exception(
                    "dataSet не містить таблиці "
                    + tableName);
            }
            //перевірка наявності батьківських таблиць
        }

        protected virtual void SetDataBinding()
        {
        }

        private void UpdateRecords()
        {
            this.Validate();
            bindingSource.EndEdit();
            OnRecordsUpdated(new EventArgs());
        }

        internal BaseTableForm()
        {//protected
            InitializeComponent();
        }

        public BaseTableForm(string tableName,
            DataSet dataSet, VoidMethod saveDataMethod)
        {
            #region Перевірка аргументів на null
            if (String.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentNullException(
                    "tableName");
            }
            if (dataSet == null)
            {
                throw new ArgumentNullException(
                    "dataSet");
            }
            if (saveDataMethod == null)
            {
                throw new ArgumentNullException(
                    "saveDataMethod");
            }
            #endregion

            this.tableName = tableName;
            this.dataSet = dataSet;
            this.saveDataMethod = saveDataMethod;

            VerifyDataSet();

            InitializeComponent();

            this.Text = "Таблиця " + tableName;

            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = tableName;
            bindingNavigator1.BindingSource = bindingSource;

            SetDataBinding();
        }

        private void toolStripButtonUpdateRecords_Click(object sender, EventArgs e)
        {
            UpdateRecords();
        }

        private void toolStripButtonUndoRecord_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            saveDataMethod();
        }

        private void BaseTableForm_Load(object sender, EventArgs e)
        {

        }

    }
}
