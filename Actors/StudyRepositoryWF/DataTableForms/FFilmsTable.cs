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
    public partial class FFilmsTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FFilmsTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Films", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();

            InitializeComponent();

            txtFilmName.DataBindings.Add(new Binding("Text",
                bindingSource, "FilmName", true));
            txtStudio.DataBindings.Add(new Binding("Text",
                bindingSource, "Studio", true));
            txtReleaseDate.DataBindings.Add(new Binding("Text",
                bindingSource, "ReleaseDate", true));
        }

        private void FFilmsTable_Load(object sender, EventArgs e)
        {

        }
    }
}
