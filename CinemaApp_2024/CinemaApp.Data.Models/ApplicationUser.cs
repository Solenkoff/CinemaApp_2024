
namespace CinemaApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        // TODO: Add more properties to our user

        public virtual ICollection<ApplicationUserMovie> ApplicationUserMovies { get; set; }
            = new HashSet<ApplicationUserMovie>();

    }
}
