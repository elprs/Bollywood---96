namespace Bollywood.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bollywood.Entities;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Bollywood.Database.Mydatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Bollywood.Database.Mydatabase context)
        {
            //==============Create ProductionCode
            ProductionCode c1 = new ProductionCode() { Number = "AT-12345" };
            ProductionCode c2 = new ProductionCode() { Number = "BF-55555" };
            ProductionCode c3 = new ProductionCode() { Number = "JP-34567" };

            //==============Create Genres
            Genre g1 = new Genre() { Kind = "Action" };
            Genre g2 = new Genre() { Kind = "Drama" };
            Genre g3 = new Genre() { Kind = "Comedy" };

            //==============Create Directors
            Director d1 = new Director() { FirstName = "Pedro", LastName = "Almodovar", Country = Country.Spain, PhotoUrl = "#", DateOfBirth = new DateTime(1960, 6, 12) };
            Director d2 = new Director() { FirstName = "Quentin", LastName = "Tarantino", Country = Country.America, PhotoUrl = "#", DateOfBirth = new DateTime(1980, 9, 12) };
            Director d3 = new Director() { FirstName = "Steven", LastName = "Spielberg", Country = Country.America, PhotoUrl = "#", DateOfBirth = new DateTime(1946, 12, 18) };

            //==============Create Actors
            Actor a1 = new Actor() { FirstName = "Brad", LastName = "Pitt", DateOfBirth = new DateTime(1963, 12, 18), PhotoUrl = "#", Country = Country.America, Telephone = "6958451236", Salary = 46000 };
            Actor a2 = new Actor() { FirstName = "Thanasis", LastName = "Veggos", DateOfBirth = new DateTime(1927, 5, 7), PhotoUrl = "#", Country = Country.Greece, Telephone = "45981652", Salary = 35000 };
            Actor a3 = new Actor() { FirstName = "Hector", LastName = "Gatsos", DateOfBirth = new DateTime(1987, 4, 17), PhotoUrl = "#", Country = Country.Greece, Telephone = "123123123", Salary = 50000 };

            //==============Create Movies
            Movie m1 = new Movie() { Title = "Avatar", Country = Country.America, Duration = 180, PhotoUrl = "#", ProductionDate = new DateTime(2009, 01, 01), Rating = 7.8, TrailerUrl = "#" };
            Movie m2 = new Movie() { Title = "Julieta", Country = Country.Spain, Duration = 198, PhotoUrl = "#", ProductionDate = new DateTime(2016, 01, 01), Rating = 7.1, TrailerUrl = "#" };
            Movie m3 = new Movie() { Title = "Seven", Country = Country.America, Duration = 156, PhotoUrl = "#", ProductionDate = new DateTime(1995, 01, 01), Rating = 8.6, TrailerUrl = "#" };

            //==============Assign Director to Movie
            m1.Director = d1;
            m2.Director = d1;
            m3.Director = d2;

            //==============Assign Acotrs to Movie
            m1.Actors = new List<Actor>() { a1, a2, a3 };
            m2.Actors = new List<Actor>() { a3 };
            m3.Actors = new List<Actor>() { a2 };

            //==============Assign Genres to Movie
            m1.Genres = new List<Genre>() { g1, g2 };
            m2.Genres = new List<Genre>() { g2, g3 };
            m3.Genres = new List<Genre>() { g3 };

            //==============Assign Movies to Production Code
            c1.Movie = m1;
            c2.Movie = m2;
            c3.Movie = m3;

            //==============Adding Context Tables
            context.ProductionCodes.AddOrUpdate(x => x.Number, c1, c2, c3);
            context.Genres.AddOrUpdate(x => x.Kind, g1, g2, g3);
            context.Actors.AddOrUpdate(x => x.FirstName, a1, a2, a3);
            context.Directors.AddOrUpdate(x => x.FirstName, d1, d2, d3);
            context.Movies.AddOrUpdate(x => x.Title, m1, m2, m3);





        }
    }
}
