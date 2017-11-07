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
    public partial class FCompetitionTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FCompetitionTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Competition", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();
            InitializeComponent();

            txtCompetitionID.DataBindings.Add(new Binding("Text",
                bindingSource, "ID", true));
            txtCompetition.DataBindings.Add(new Binding("Text",
                bindingSource, "Competition", true));
        }

        private void FCompetitionTable_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelTopCompetition_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
