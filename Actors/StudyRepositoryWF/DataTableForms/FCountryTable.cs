using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using StudyFormsLibrary.DataTableForms;

namespace StudyRepositoryWF.DataTableForms
{
    public partial class FCountryTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FCountryTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Country", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();

            InitializeComponent();

            txtCountryID.DataBindings.Add(new Binding("Text",
                bindingSource, "ID", true));
            txtCountry.DataBindings.Add(new Binding("Text",
                bindingSource, "Country", true));
        }

        private void FCountryTable_Load(object sender, EventArgs e)
        {

        }
    }
}
