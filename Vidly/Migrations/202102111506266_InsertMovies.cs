namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hangover', 5, 11/02/2021, 17/06/2011, 3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 1, 11/02/2021, 13/01/2008, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 1, 11/02/2021, 03/07/2009, 4)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('ToyStory', 3, 11/02/2021, 07/003/1997, 6)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 4, 11/02/2021, 08/05/1990, 10)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Zootopia', 3, 11/02/2021, 09/09/2017, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
