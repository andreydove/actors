using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Actors.Repository
{
    public partial class ActorsRepository
    {
        public override DataSet CreateDataSet()
        {
            DataSet ds = new DataSet("ActorsRepository");

            ds.Tables.Add(CreateActorsTable());
            ds.Tables.Add(CreateCompetitionTable());
            ds.Tables.Add(CreateCountryTable());
            ds.Tables.Add(CreateFilmsTable());
            ds.Tables.Add(CreateResultsTable());
            ds.Tables.Add(CreateRolesTable());
            ds.Tables.Add(CreateGenresTable());
            ds.Tables.Add(CreateGenreOfFilmsTable());

            CreateRelations(ds);

            return ds;
        }

        public DataTable CreateActorsTable()
        {
            DataTable dt = new DataTable("Actors");

            AddIdColumn(dt);
            AddNameColumns(dt, true);

            DataColumn dc;

            dc = new DataColumn("CountryID", typeof(int));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dc = new DataColumn("BirthDate", typeof(DateTime));
            //dc.AllowDBNull = false;
            //dc.Unique = true;
            dt.Columns.Add(dc);

            dc = new DataColumn("Age", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("MaritalStatus", typeof(string));
            dt.Columns.Add(dc);

            AddDescribColumns(dt);
            AddNoteColumn(dt);

            return dt;

        }

        public DataTable CreateCompetitionTable()
        {
            DataTable dt = new DataTable("Competition");
            AddIdColumn(dt);

            DataColumn dc;

            dc = new DataColumn("Competition", typeof(string));
            dt.Columns.Add(dc);

            return dt;
        }

        public DataTable CreateCountryTable()
        {
            DataTable dt = new DataTable("Country");

            AddIdColumn(dt);
  

            DataColumn dc;

            dc = new DataColumn("Country", typeof(string));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);


            return dt;
        }

        public DataTable CreateFilmsTable()
        {
            DataTable dt = new DataTable("Films");

            AddIdColumn(dt);
   

            DataColumn dc;

            dc = new DataColumn("FilmName", typeof(string));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dc = new DataColumn("ReleaseDate", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Studio", typeof(string));
            dt.Columns.Add(dc);

            return dt;
        }

        public DataTable CreateResultsTable()
        {
            DataTable dt = new DataTable("Results");


            DataColumn dc;
            dc = new DataColumn("ActorID", typeof(int));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dc = new DataColumn("CompetitionID", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Nomination", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Year", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Result", typeof(string));
            dt.Columns.Add(dc);

            return dt;
        }
        public DataTable CreateRolesTable()
        {
            DataTable dt = new DataTable("Roles");

            DataColumn dc;

            dc = new DataColumn("ActorID", typeof(int));
           // dc.AllowDBNull = false;
            dt.Columns.Add(dc);


            dc = new DataColumn("FilmID", typeof(int));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dc = new DataColumn("Role", typeof(string));
            dc.Unique = true;
            dt.Columns.Add(dc);

            return dt;
        }


        public DataTable CreateGenresTable()
        {
            DataTable dt = new DataTable("Genres");

            AddIdColumn(dt);
  

            DataColumn dc;

            dc = new DataColumn("Genre", typeof(string));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            return dt;
        }

        public DataTable CreateGenreOfFilmsTable()
        {
            DataTable dt =
                 new DataTable("GenreOfFilms");


            DataColumn dc;

            dc = new DataColumn("GenreID",
               typeof(int));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dc = new DataColumn("FilmID",
              typeof(int));
            //dc.AllowDBNull = false;
            dt.Columns.Add(dc);

            dt.PrimaryKey = new DataColumn[] 
       {
           dt.Columns["GenreID"],
           dt.Columns["FilmID"]
       };


            return dt;

        }
        //public void AddEntityColumns(DataTable dt, string columnIDName)
        //{
        //    DataColumn dc = new DataColumn(columnIDName, typeof(int));
        //    dc.AllowDBNull = false;
        //    dc.Unique = true;
        //    dt.Columns.Add(dc);

        //}

        private void CreateRelations(DataSet ds)
        {
            DataRelation drl;
            //string s = ds.Tables["Actors"]
            //        .Columns["CountryID"].ColumnName;
            //s = ds.Tables["Country"]
            //        .Columns["ID"].ColumnName;
            drl = new DataRelation("Country_Actor",
                ds.Tables["Country"]
                    .Columns["ID"],
                ds.Tables["Actors"]
                    .Columns["CountryID"]);
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;

            drl = new DataRelation(
                    "Actors_Roles",
                ds.Tables["Actors"]
                    .Columns["ID"],
                ds.Tables["Roles"]
                    .Columns["ActorID"]);
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;
            drl.ChildKeyConstraint.DeleteRule = Rule.Cascade;

            drl = new DataRelation(
                "Actors_Results",
                ds.Tables["Actors"]
                    .Columns["ID"],
                ds.Tables["Results"]
                    .Columns["ActorID"]);
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;
            drl.ChildKeyConstraint.DeleteRule = Rule.Cascade;

            drl = new DataRelation(
                "Films_Roles",
                ds.Tables["Films"]
                    .Columns["ID"],      
                ds.Tables["Roles"]
                    .Columns["FilmID"]);
    
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;

            drl = new DataRelation(
                "Competition_Results",
                ds.Tables["Competition"]
                    .Columns["ID"],  
            ds.Tables["Results"]
                .Columns["CompetitionID"]);

            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;

            drl = new DataRelation(
               "Films_GenreOfFilms",
               ds.Tables["Films"]
                   .Columns["ID"],
               ds.Tables["GenreOfFilms"]
                   .Columns["FilmID"]);
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;
            drl.ChildKeyConstraint.DeleteRule = Rule.Cascade;

            drl = new DataRelation(
               "Genres_GenreOfFilms",
               ds.Tables["Genres"]
                   .Columns["ID"],
                ds.Tables["GenreOfFilms"]
                   .Columns["GenreID"]);
            ds.Relations.Add(drl);
            drl.ChildKeyConstraint.UpdateRule = Rule.Cascade;
        }
    }
}
