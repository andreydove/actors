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

        protected override void FillCollections(DataSet ds)
        {
            FillActor(ds);
            FillCountry(ds);
            FillRoles(ds);
            FillResults(ds);
            FillGenreOfFilms(ds);
            FillFilms(ds);
            FillCompetition(ds);
            FillGenres(ds);
        }

        private bool FillActor(DataSet ds)
        {
            if (!ds.Tables.Contains("Actor"))
                return false;
            if (this.actors == null)
            {
                actors =
                    new Dictionary<int, Actor>();
            }
            foreach (DataRow dr
                    in ds.Tables["GeographicalRegion"].Rows)
            {
                Actor obj = new Actor();
                FillEntityMembers(dr, obj);
                obj.CommonName = dr["CommonName"].ToString();
                //obj.FormalName = dr["FormalName"].ToString();
                obj.BirthDate = DateTime.Parse(dr["BirthDate"].ToString());
                obj.MaritalStatus = dr["MaritalStatus"].ToString();
                obj.CountryID = Int32.Parse(dr["CountryID"].ToString());
                //this.actors[obj.Id] = obj;
            }
            return true;
        }

        private bool FillCountry(DataSet ds)
        {
            if (!ds.Tables.Contains("Country"))
                return false;
            if (this.countries == null)
            {
                countries =
                    new Dictionary<int, Country>();
            }
            foreach (DataRow dr
                in ds.Tables["Country"].Rows)
            {
                Country obj = new Country();
                FillEntityMembers(dr, obj);
                obj.CountryID =
                    Int32.Parse(dr["CountryID"].ToString());
                obj.CountryName =
                    dr["CountryName"].ToString();
                //this.countries[obj.Id] = obj;
            }
            return true;
        }

        private bool FillRoles(DataSet ds)
        {
            if (!ds.Tables.Contains("Roles"))
                return false;
            if (this.roles == null)
            {
                roles =
                    new Dictionary<int, Roles>();
            }
            foreach (DataRow dr
                    in ds.Tables["Roles"].Rows)
            {
                Roles obj = new Roles();
                obj.FilmID = Int32.Parse(
                    dr["FilmID"].ToString());
                obj.Role =
                    dr["Role"].ToString();
                //this.roles[obj.Id] = obj;
            }
            return true;
        }

        private bool FillResults(DataSet ds)
        {
            if (!ds.Tables.Contains("Results"))
                return false;
            if (this.results == null)
            {
                results = new Dictionary<int, Results>();
            }
            foreach (DataRow dr in ds.Tables["Results"].Rows)
            {
                Results obj = new Results();
                FillEntityMembers(dr, obj);
                obj.Result = dr["Result"].ToString();
                obj.Nomination = dr["Nomination"].ToString();
                obj.CompetitionID = Int32.Parse(
                    dr["CompetitionID"].ToString());
                obj.Year = Int32.Parse(
                    dr["Year"].ToString());
                //this.results[obj.Id] = obj;
            }
            return true;
        }

        private bool FillGenreOfFilms(DataSet ds)
        {
            if (!ds.Tables.Contains("GenreOfFilms"))
                return false;
            if (this.genreOfFilms == null)
            {
                genreOfFilms =
                    new List<GenreOfFilms>();
            }
            foreach (DataRow dr
                              in ds.Tables["GenreOfFilms"].Rows)
            {
                GenreOfFilms obj =
                    new GenreOfFilms();
                obj.GenreID = Int32.Parse(
                    dr["GenreID"].ToString());
                obj.FilmID = Int32.Parse(
                    dr["FilmID"].ToString());
                //this.genreOfFilms[obj.Id] = obj;
            }
            return true;
        }

        private bool FillFilms(DataSet ds)
        {
            if (!ds.Tables.Contains("Films"))
                return false;
            if (this.film == null)
            {
                film = new
                    Dictionary<int, Films>();
            }
            foreach (DataRow dr
                in ds.Tables["Films"].Rows)
            {
                Films obj =
                    new Films();
                FillEntityMembers(dr, obj);
                obj.FilmID = Int32.Parse(
                    dr["FilmID"].ToString());
                obj.FilmName = dr["FilmName"].ToString();
                obj.ReleaseDate = DateTime.Parse(
                    dr["ReleaseDate"].ToString());
                obj.Studio = 
                    dr["Studio"].ToString();
                //this.film[obj.Id] = obj;
            }
            return true;
        }

        private bool FillCompetition(DataSet ds)
        {
            if (!ds.Tables.Contains("Competition"))
                return false;
            if (this.competitions == null)
            {
                competitions = new
                    Dictionary<int, Competition>();
            }
            foreach (DataRow dr
                in ds.Tables["Competition"].Rows)
            {
                Competition obj =
                    new Competition();
                FillEntityMembers(dr, obj);
                obj.CompetitionID = Int32.Parse(
                    dr["CompetitionID"].ToString());
                obj.Competitions = dr["Competitions"].ToString();
                //this.competitions[obj.Id] = obj;
            }
            return true;
        }

        private bool FillGenres(DataSet ds)
        {
            if (!ds.Tables.Contains("Genres"))
                return false;
            if (this.genres == null)
            {
                genres = new
                    Dictionary<int, Genres>();
            }
            foreach (DataRow dr
                in ds.Tables["Genres"].Rows)
            {
                Genres obj =
                    new Genres();
                FillEntityMembers(dr, obj);
                obj.GenreID = Int32.Parse(
                    dr["GenreID"].ToString());
                obj.Genre= dr["Genre"].ToString();
                //this.genres[obj.Id] = obj;
            }
            return true;
        }


    }
}
