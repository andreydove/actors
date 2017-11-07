using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

using Actors.Model;

namespace Actors.Repository
{

    public abstract partial class EntityRepository
    {

        protected abstract void FillCollections(DataSet ds);

        public abstract void FillDataSet(DataSet ds);

        public void LoadXmlToDataSet(string fileName,
            ref DataSet ds,
            XmlReadMode readMode = XmlReadMode.IgnoreSchema)
        {
            string ext = Path.GetExtension(fileName);
            if (ext == ".xsd")
            {
                ds.ReadXmlSchema(fileName);
            }
            else if (ext == ".xml")
            {
                ds.ReadXml(fileName, readMode);
                FillCollections(ds);
            }
        }

        public void LoadXml(string fileName,
            XmlReadMode readMode = XmlReadMode.IgnoreSchema)
        //XmlWriteMode.WriteSchema
        {
            DataSet ds = CreateDataSet();
            LoadXmlToDataSet(fileName, ref ds);
        }

        public void SaveXml(string fileName,
            XmlWriteMode writeMode = XmlWriteMode.IgnoreSchema)
        //XmlWriteMode.WriteSchema
        {
            DataSet ds = CreateDataSet();

            string ext = Path.GetExtension(fileName);
            if (ext == ".xsd")
            {
                ds.WriteXmlSchema(fileName);
            }
            else if (ext == ".xml")
            {
                FillDataSet(ds);
                ds.WriteXml(fileName, writeMode);
            }

        }

        protected void CheckArgumentDataSet(DataSet ds)
        {
            if (ds == null)
            {
                throw new ArgumentNullException(
                    "Відсутній (null) аргумент типу DataSet");
            }
        }

        protected void FillEntityMembers(DataRow dr, Entity entity)
        {
            entity.Note = dr["Note"].ToString();
            IdentifiedEntity identifiedEntity = entity as IdentifiedEntity;
            if (identifiedEntity != null)
            {
                identifiedEntity.Id = Int32.Parse(dr["ID"].ToString()); 
            }
            NamedEntity namedEntity = entity as NamedEntity;
            if (namedEntity != null)
            {
                namedEntity.CommonName = dr["CommonName"].ToString();
                if (dr.Table.Columns.Contains("FormalName"))
                    namedEntity.EnglishName = dr["FormalName"].ToString();
            }
            DescribedEntity describedEntity = entity as DescribedEntity;
            if (describedEntity != null)
            {
                describedEntity.Description = dr["Description"].ToString();
                describedEntity.Site = dr["Site"].ToString();
            }
        }

        protected void FillEntityColumns(DataRow dr, Entity entity)
        {
            dr["Note"] = entity.Note;
            NamedEntity namedEntity = entity as NamedEntity;
            if (namedEntity != null)
            {
                dr["CommonName"] = namedEntity.CommonName;
                if (dr.Table.Columns.Contains("FormalName"))
                    dr["FormalName"] = namedEntity.EnglishName;
            }
            DescribedEntity describedEntity = entity as DescribedEntity;
            if (describedEntity != null)
            {
                dr["Description"] = describedEntity.Description;
                dr["Site"] = describedEntity.Site;
            }
        }

    }
}
