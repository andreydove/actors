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
    public partial class FRolesTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FRolesTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("Roles", dataSet, saveDataMethod)
        {
        }


        protected override void SetDataBinding()
        {

            base.SetDataBinding();
            InitializeComponent();

            txtRole.DataBindings.Add(new Binding("Text",
                bindingSource, "Role", true));

            cmoActorIDRoles.DataSource =
               (bindingSource.DataSource as DataSet)
               .Tables["Actors"];
            cmoActorIDRoles.ValueMember = "ID";
            cmoActorIDRoles.DisplayMember = "CommonName";
            cmoActorIDRoles.DataBindings.Add("SelectedValue",
                bindingSource, "ActorID", true,
                DataSourceUpdateMode.OnPropertyChanged);

            cmoFilmIDRoles.DataSource =
               (bindingSource.DataSource as DataSet)
               .Tables["Films"];
            cmoFilmIDRoles.ValueMember = "ID";
            cmoFilmIDRoles.DisplayMember = "FilmName";
            cmoFilmIDRoles.DataBindings.Add("SelectedValue",
                bindingSource, "FilmID", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FRolesTable_Load(object sender, EventArgs e)
        {

        }
    }
}
