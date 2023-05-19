namespace PokemonReviewApp.Models
{
    // Reviewer model to represent the Reviewer data inside the MySQL database.
    public class Reviewer
	{
        // Unique ID for each Reviewer
        public int Id { get; set; }

        // First Name of the Reviewer
        public string FirstName { get; set; }

        // Last Name of the Reviewer
        public string LastName { get; set; }

        // Collection of Reviews written by the Reviewer
        public ICollection<Review> Reviews { get; set; }
    }
}

