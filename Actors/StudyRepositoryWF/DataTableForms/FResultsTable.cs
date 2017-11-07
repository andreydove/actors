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
    public partial class FResultsTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FResultsTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Results", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();

            InitializeComponent();

            txtNomination.DataBindings.Add(new Binding("Text",
                bindingSource, "Nomination", true));
            txtYear.DataBindings.Add(new Binding("Text",
                bindingSource, "Year", true));

            cmoCompetitionID.DataSource =
               (bindingSource.DataSource as DataSet)
               .Tables["Competition"];
            cmoCompetitionID.ValueMember = "ID";
            cmoCompetitionID.DisplayMember = "Competition";
            cmoCompetitionID.DataBindings.Add("SelectedValue",
                bindingSource, "CompetitionID", true,
                DataSourceUpdateMode.OnPropertyChanged);

            cmoActorIDResults.DataSource =
               (bindingSource.DataSource as DataSet)
               .Tables["Actors"];
            cmoActorIDResults.ValueMember = "ID";
            cmoActorIDResults.DisplayMember = "CommonName";
            cmoActorIDResults.DataBindings.Add("SelectedValue",
                bindingSource, "ActorID", true,
                DataSourceUpdateMode.OnPropertyChanged);

            cmoResult.DataBindings.Add("Text",
                bindingSource, "Result", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FResultsTable_Load(object sender, EventArgs e)
        {

        }
    }
}
