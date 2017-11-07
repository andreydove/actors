using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudyFormsLibrary.DataTableForms
{

    public partial class EntityTableForm
        : StudyFormsLibrary.DataTableForms.BaseTableForm
    {

        protected bool BindColumn(string columnName,
            Control control, TableLayoutPanel tblPanel, int index
            )
        {
            if (dataSet.Tables[tableName].Columns
                    .Contains(columnName))
            {
                control.DataBindings.Add(new Binding("Text",
                    bindingSource, columnName, true));
                return true;
            }
            else
            {
                tblPanel.RowStyles[index].SizeType =
                SizeType.Absolute;
                tblPanel.RowStyles[index].Height = 0;
                return false;
            }
        }

        protected override void SetDataBinding()
        {

            InitializeComponent();

            lblId.Text = "";
           BindColumn("Id", lblId, tableLayoutPanelTop, 1);
            BindColumn("CommonName", txtCommonName,
                tableLayoutPanelTop, 2);
            BindColumn("FormalName", txtFormalName,
                tableLayoutPanelTop, 3);

            BindColumn("Note", txtNote, tableLayoutPanelBottom, 0);
            BindColumn("Site", txtSite, tableLayoutPanelBottom, 1);
            if (!BindColumn("Description", txtDescription,
                    tableLayoutPanelTop, 2))
            {
                pnlDescription.Visible = false;
            }
        }

        internal EntityTableForm()
        {
            InitializeComponent();
        }

        public EntityTableForm(string tableName,
            DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName,
            dataSet, saveDataMethod)
        {
        }

        private void EntityTableForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCommonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
