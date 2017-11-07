using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

//using StudyCountry.Model;

namespace Actors.Repository
{
    partial class EntityRepository
    {

        public abstract DataSet CreateDataSet();

        public void AddIdColumn(DataTable dt,
                string columnIDName = "ID",
                bool autoIncrement = true)
        {
            DataColumn dc = new DataColumn(
                columnIDName, typeof(int));
            dc.AutoIncrement = autoIncrement;
            dc.AutoIncrementSeed = 1;
            //dc.AllowDBNull = false;
            //dc.Unique = true;
            dt.Columns.Add(dc);

            dt.PrimaryKey = new DataColumn[] {
                dt.Columns[columnIDName] };
        }
        //public void AddColumnID(DataTable dt, string columnIDName, bool autoIncrement = true)
        //{
        //    DataColumn dc = new DataColumn(columnIDName, typeof(int));
        //    dc.AutoIncrement = autoIncrement;
        //    dc.AutoIncrementSeed = 1;
        //    dc.AllowDBNull = false;
        //    dc.Unique = true;
        //    dt.Columns.Add(dc);
        //}

        public void AddNameColumns(DataTable dt,
                bool withEnglishName = false,
                bool EnglishNameRequired = false)
        {
            DataColumn dc;
            dc = new DataColumn("CommonName",
                typeof(string));
            dc.AllowDBNull = false;
            dc.Unique = true;
            dt.Columns.Add(dc);

            if (withEnglishName)
            {
                dc = new DataColumn("FormalName",
                    typeof(string));
                dc.AllowDBNull = EnglishNameRequired;
                dc.Unique = EnglishNameRequired;
                dt.Columns.Add(dc);
            }
        }

        public void AddDescribColumns(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("Description", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("Site", typeof(string));
            dt.Columns.Add(dc);
        }

        public void AddNoteColumn(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("Note", typeof(string));
            dt.Columns.Add(dc);
        }

    }
}
