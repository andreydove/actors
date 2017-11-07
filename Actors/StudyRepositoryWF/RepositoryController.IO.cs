using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Schema;
using Actors.Repository;
using System.IO;


namespace StudyRepositoryWF
{
    public partial class RepositoryController
    {
        private EntityRepository repository;

        private string fileName = "";

        BindingSource bindingSource = new BindingSource();
        Form form;
        DataGridView dataGridView;
        BindingNavigator bindingNavigator;
        ListBox lstTables;

        bool areChanges = false;

        public RepositoryController(
            string repositoryDirectory, Form form,
            DataGridView dataGridView,
            BindingNavigator bindingNavigator,
            ListBox lstTables)
        {
            if (repositoryDirectory == null)
            {
                throw new ArgumentNullException(
                    "repositoryDirectory");
            }
            if (dataGridView == null)
            {
                throw new ArgumentNullException(
                    "dataGridView");
            }
            if (bindingNavigator == null)
            {
                throw new ArgumentNullException(
                    "bindingNavigator");
            }
            if (lstTables == null)
            {
                throw new ArgumentNullException(
                    "lstTables");
            }
            repository =
           new ActorsRepository(
           repositoryDirectory);
            this.form = form;
            this.dataGridView = dataGridView;
            this.bindingNavigator = bindingNavigator;
            this.lstTables = lstTables;

            SetControlsEventHandlers();

        }

        private void ShowFileName()
        {
            if (String.IsNullOrEmpty(fileName))
            {
                form.Text = "ActorsRepository";
            }
            else
            {
                form.Text = "ActorsRepository - " + fileName;
            }
        }

        public void SaveFile()
        {
            UpdateRecords();
            dataSet.WriteXml(fileName);//,XmlWriteMode.WriteSchema
            areChanges = false;
        }

        public void PromptToSaveFile()
        {
            if (areChanges)
            {
                if (MessageBox.Show(form, "Збрегти зміни?",
                    "Збереження файлу", MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK)
                    SaveFile();
            }
            areChanges = false;
        }

        public void CreateFile()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створити файл";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "xml файлы (*.xml)|*.xml";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                try
                {
                    dataSet = repository.CreateDataSet();
                    dataSet.WriteXml(fileName);
                    ShowDataSetMembers();
                    bindingSource.DataSource = dataSet;
                    ShowFileName();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        public void SaveXmlSchema()
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Зберегти файл схеми XML";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "Файли схеми xml (*.xsd)|*.xsd";
            dialog.RestoreDirectory = true;
            dialog.FileName = "Actors";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataSet ds = repository.CreateDataSet();
                    ds.WriteXmlSchema(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        public void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Відкрити файл";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "Файли схеми xml (*.xml)|*.xml";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                try
                {
                    ValidateXML(dialog.FileName,
                        repository.Directory + "\\Actors.xsd");
                    PromptToSaveFile();

                    fileName = dialog.FileName;

                    dataSet = repository.CreateDataSet();
                    dataSet.ReadXml(fileName, XmlReadMode.IgnoreSchema);
                    ShowDataSetMembers();
                    bindingSource.DataSource = dataSet;
                    ShowFileName();
                }
                catch (XmlSchemaValidationException ex)
                {
                    MessageBox.Show("Помилка перевірки достовірності: "
                        + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }

        public void SaveFileAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Зберегти файл як";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "Файлы xml (*.xml)|*.xml";
            dialog.RestoreDirectory = true;
            dialog.FileName = Path.GetFileName(fileName);
            if (dialog.ShowDialog()
                == System.Windows.Forms.DialogResult.OK)
            {
                fileName = dialog.FileName;
                SaveFile();
            }

        }

        public void CloseFile()
        {
            PromptToSaveFile();
            bindingSource.DataMember = "";
            lstTables.Items.Clear();
            bindingSource.DataSource = null;
            dataSet.Dispose();
            fileName = "";
            ShowFileName();
        }
    }
}

