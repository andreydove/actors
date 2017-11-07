using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Windows.Forms;

namespace StudyRepositoryWF
{
    public partial class RepositoryController
    {
        private DataSet dataSet;

        public DataSet DataSet
        {
            get { return dataSet; }
        }

        private void ShowDataSetMembers()
        {
            lstTables.Items.Clear();
            foreach (DataTable dt in dataSet.Tables)
            {
                lstTables.Items.Add(dt.TableName);
            }
        }

        public void UpdateRecords()
        {
            if (String.IsNullOrEmpty(fileName))
                return;
            form.Validate();
            bindingSource.EndEdit();
        }
        public void UndoRecord() {
            bindingSource.CancelEdit();
        }


        private void ValidateXML(string xmlFileName, string xsdFileName)
        {
            XDocument xDocument = XDocument.Load(xmlFileName);
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("", xsdFileName);
            xDocument.Validate(schemaSet, null);
        }

        public void ChangeTable()
        {
            string tableName = "";
            if (lstTables.SelectedIndex >= 0)
            {
                tableName = lstTables.SelectedItem.ToString();
            }
            bindingSource.DataMember = tableName;
            dataGridView.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
        }

        private void SetControlsEventHandlers() {
            dataGridView.CellClick += new DataGridViewCellEventHandler(
                dataGridView_CellClick);
            dataGridView.CellValueChanged +=
                new DataGridViewCellEventHandler(
                    dataGridView_CellValueChanged);
        }

        private void dataGridView_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.BeginEdit(true);
        }

        private void dataGridView_CellValueChanged(
            object sender, DataGridViewCellEventArgs e)
        {
            areChanges = true;
        }

    }
}
