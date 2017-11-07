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
    public partial class FActorsTable : StudyFormsLibrary.DataTableForms.EntityTableForm
    {
        public FActorsTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Actors", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();

            InitializeComponent();

            txtMaritalStatus.DataBindings.Add(new Binding("Text",
                bindingSource, "MaritalStatus", true));
            txtAge.DataBindings.Add(new Binding("Text",
                bindingSource, "Age", true));
            dateTimePicker1.DataBindings.Add(new Binding("Value",
                bindingSource, "BirthDate", true));

            cmoCountry.DataSource =
               (bindingSource.DataSource as DataSet)
               .Tables["Country"];
            cmoCountry.ValueMember = "ID";
            cmoCountry.DisplayMember = "Country";
            cmoCountry.DataBindings.Add("SelectedValue",
                bindingSource, "CountryID", true,
                DataSourceUpdateMode.OnPropertyChanged);


        }


        private void FActorsTable_Load(object sender, EventArgs e)
        {

        }
    }
}
