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
    public partial class FGenresTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FGenresTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Genres", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();
            InitializeComponent();

            txtGenreID.DataBindings.Add(new Binding("Text",
                bindingSource, "ID", true));
            txtGenre.DataBindings.Add(new Binding("Text",
                bindingSource, "Genre", true));
        }

        private void FGenresTable_Load(object sender, EventArgs e)
        {

        }
    }
}
