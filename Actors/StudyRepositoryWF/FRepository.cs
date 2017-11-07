using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

using StudyFormsLibrary.DataTableForms;
using StudyRepositoryWF.DataTableForms;


namespace StudyRepositoryWF
{
    public partial class FRepository : Form
    {
        RepositoryController controller;
        
        private void SetControlsState()
        {
        }

        public FRepository()
        {
            InitializeComponent();
            controller =
            new RepositoryController(
                @"..\..\..\..\ActorsRepository",
                this, dataGridView1, bindingNavigator1,
                lstTables);
        }

        private void FRepository_Load(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            controller.CreateFile();
            SetControlsState();
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.ChangeTable();
            SetControlsState();
        }
      
        private void mnuFileSaveXmlSchema_Click(object sender, EventArgs e)
        {
            controller.SaveXmlSchema();
        }
           
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            controller.OpenFile();
            SetControlsState();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            controller.SaveFile();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            controller.SaveFileAs();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            controller.PromptToSaveFile();
            this.Close();
        }

        private void FRepository_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.PromptToSaveFile();
        }

        private void mnuRecordsUndo_Click(object sender, EventArgs e)
        {
            controller.UndoRecord();
        }

        private void mnuRecordsUpdate_Click(object sender, EventArgs e)
        {
            controller.UpdateRecords();
        }

        private void mnuViewToolPanelsStandard_Click(object sender, EventArgs e)
        {
            toolStripStandard.Visible =
                mnuViewToolPanelsStandard.Checked;
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            controller.CloseFile();
        }

        private void btnTableForm_Click(object sender, EventArgs e)
        {
            if (lstTables.SelectedIndex < 0)
                return;

            controller.PromptToSaveFile();

            BaseTableForm frm = null;
            string tableName = lstTables.SelectedItem.ToString();
            if (tableName == "GenreOfFilms")
            {
                frm = new FGenreOfFilmsTable(
                    controller.DataSet, controller.SaveFile);
            }
            
            else if (tableName == "Roles")
            {
                frm = new FRolesTable(
                    controller.DataSet, controller.SaveFile);
            }
             else if (tableName == "Actors")
            {
                frm = new FActorsTable(
                    controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Results")
            {
                frm = new FResultsTable(
                    controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Films")
            {
                frm = new FFilmsTable(
                    controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Genres")
            {
                frm = new FGenresTable(
                    controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Country")
            {
                frm = new FCountryTable(
                    controller.DataSet, controller.SaveFile);
            }
                else if (tableName == "Competition")
            {
                frm = new FCompetitionTable(
                    controller.DataSet, controller.SaveFile);
            }
            
            if (frm != null)
                frm.ShowDialog();
            dataGridView1.Refresh();
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }


        }
    }

