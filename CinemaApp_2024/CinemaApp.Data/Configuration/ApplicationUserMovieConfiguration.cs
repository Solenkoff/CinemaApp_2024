namespace CinemaApp.Data.Configuration
{
    using CinemaApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApplicationUserMovieConfiguration : IEntityTypeConfiguration<ApplicationUserMovie>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserMovie> builder)
        {
            builder
                .HasKey(um => new { um.MovieId, um.ApplicationUserId });

            builder
                .HasOne(um => um.Movie)
                .WithMany(m => m.MovieApplicationUsers)
                .HasForeignKey(m => m.MovieId);

            builder
                .HasOne(um => um.ApplicationUser)
                .WithMany(au => au.ApplicationUserMovies)
                .HasForeignKey(au => au.ApplicationUserId);

        }
    }
}
