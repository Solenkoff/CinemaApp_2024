namespace CinemaApp.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class EntityValidationMessages
    {

        public static class Movie
        {
            public const string TitleRequiredMessage = "Movie title is required.";
            public const string GenreRequiredMessage = "Genre is required.";
            public const string ReleaseDateRequiredMessage = "ReleaseDate is required in the fallowing format: MM/yyyy.";
            public const string DirectorRequiredMessage = "Director name is required.";
            public const string DurationRequiredMessage = "Please specify movie duration.";

        }

    }
}
