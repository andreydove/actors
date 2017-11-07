using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Actors.Model;

namespace Actors.Repository
{

    public partial class ActorsRepository
    {

        public override void FillDataSet(DataSet ds)
        {
            CheckArgumentDataSet(ds);
            FillActorTable(ds);
            FillCountryTable(ds);
            FillRolesTable(ds);
            FillResultsTable(ds);
            FillGenreOfFilmsTable(ds);
            FillFilmsTable(ds);
            FillCompetitionTable(ds);
            FillGenresTable(ds);
        }

        private void FillActorTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Actor"];
            if (this.actors == null)
            {
                throw new Exception(
                    "Відсутня колекція actor");
            }
            foreach (KeyValuePair<int, Actor> pair
                    in this.actors)
            {
                DataRow dr = dt.NewRow();
                Actor obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["CommonName"] = obj.CommonName;
                dr["FormalName"] = obj.FormalName;
                dr["BirthDate"] = obj.BirthDate;
                dr["Age"] = obj.Age;
                dr["MaritalStatus"] = obj.MaritalStatus;
                dr["CountryID"] = obj.CountryID;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }

        private void FillCountryTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Country"];
            if (this.countries == null)
            {
                throw new Exception(
                    "Відсутня колекція country");
            }
            foreach (KeyValuePair<int, Country> pair
                    in this.countries)
            {
                DataRow dr = dt.NewRow();
                Country obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["CountryID"] = obj.CountryID;
                dr["CountryName"] = obj.CountryName;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillRolesTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Roles"];
            if (this.roles == null)
            {
                throw new Exception(
                    "Відсутня колекція Roles");
            }
            foreach (KeyValuePair<int, Roles> pair
                    in this.roles)
            {
                DataRow dr = dt.NewRow();
                Roles obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["FilmID"] = obj.FilmID;
                dr["Role"] = obj.Role;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillResultsTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Results"];
            if (this.results == null)
            {
                throw new Exception(
                    "Відсутня колекція results");
            }
            foreach (KeyValuePair<int, Results> pair
                    in this.results)
            {
                DataRow dr = dt.NewRow();
                Results obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["Result"] = obj.Result;
                dr["Nomination"] = obj.Nomination;
                dr["CompetitionID"] = obj.CompetitionID;
                dr["Year"] = obj.Year;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillGenreOfFilmsTable(DataSet ds)
        {
            DataTable dt = ds.Tables["GenreOfFilms"];
            if (this.genreOfFilms == null)
            {
                throw new Exception(
                    "Відсутня колекція genreOfFilms");
            }
            foreach (GenreOfFilms obj 
                in this.genreOfFilms)
            {
                DataRow dr = dt.NewRow();
                //GenreOfFilms obj = pair.Value;
                //FillEntityColumns(dr, obj);
                dr["GenreID"] = obj.GenreID;
                dr["FilmID"] = obj.FilmID;
                //dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillFilmsTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Films"];
            if (this.film == null)
            {
                throw new Exception(
                    "Відсутня колекція films");
            }
            foreach (KeyValuePair<int, Films> pair
                    in this.film)
            {
                DataRow dr = dt.NewRow();
                Films obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["FilmID"] = obj.FilmID;
                dr["FilmName"] = obj.FilmName;
                dr["ReleaseDate"] = obj.ReleaseDate;
                dr["Studio"] = obj.Studio;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillCompetitionTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Competition"];
            if (this.competitions == null)
            {
                throw new Exception(
                    "Відсутня колекція actor");
            }
            foreach (KeyValuePair<int, Competition> pair
                    in this.competitions)
            {
                DataRow dr = dt.NewRow();
                Competition obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["CompetitionID"] = obj.CompetitionID;
                dr["Competitions"] = obj.Competitions;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }
        private void FillGenresTable(DataSet ds)
        {
            DataTable dt = ds.Tables["Genres"];
            if (this.genres == null)
            {
                throw new Exception(
                    "Відсутня колекція genres");
            }
            foreach (KeyValuePair<int, Genres> pair
                    in this.genres)
            {
                DataRow dr = dt.NewRow();
                Genres obj = pair.Value;
                FillEntityColumns(dr, obj);
                dr["GenreID"] = obj.GenreID;
                dr["Genre"] = obj.Genre;
                dt.Rows.Add(dr);
                //obj.Id = (int)dr["Id"];
            }
        }


    }
}
