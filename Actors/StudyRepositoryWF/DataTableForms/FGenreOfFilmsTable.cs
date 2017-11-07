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
    public partial class FGenreOfFilmsTable : StudyFormsLibrary.DataTableForms.BaseTableForm
    {
        public FGenreOfFilmsTable(DataSet dataSet,
            VoidMethod saveDataMethod)
            : base("GenreOfFilms", dataSet, saveDataMethod)
        {
            #region Перевірка наявності джерел даних в наборі
            if (!dataSet.Tables.Contains("GenreOfFilms"))
            {
                throw new Exception("dataSet не містить таблиці" + "GenreOfFilms");
            }
            if (!dataSet.Tables.Contains("Films"))
            {
                throw new Exception("dataSet не містить таблиці" + "Films");
            }
            if (!dataSet.Tables.Contains("Films"))
            {
                throw new Exception("dataSet не містить таблиці" + "Genres");
            }


            #endregion
            InitializeComponent();
            SetDataBinding();
        }

        protected override void SetDataBinding()
        {
            base.SetDataBinding();
            InitializeComponent();

            bindingSource.DataMember = "GenreOfFilms";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;

            DataGridViewComboBoxColumn comboBoxColumn = dataGridView1
                .Columns["GenreID"]
                as DataGridViewComboBoxColumn;
            if (comboBoxColumn == null)
            {
                throw new Exception("Тип стовпця не " + "DataGridViewComboBoxColumn");
            }
            comboBoxColumn.ValueMember = "ID";
            comboBoxColumn.DisplayMember = "Genre";
            comboBoxColumn.DataSource = dataSet.Tables["Genres"];
            comboBoxColumn.DataPropertyName = "GenreID";

            comboBoxColumn =
                (DataGridViewComboBoxColumn)dataGridView1
                .Columns["FilmID"];
            comboBoxColumn.ValueMember = "ID";
            comboBoxColumn.DisplayMember = "FilmName";
            comboBoxColumn.DataSource = dataSet.Tables["Films"];
            comboBoxColumn.DataPropertyName = "FilmID";
        }

        private void FGenreOfFilms_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
