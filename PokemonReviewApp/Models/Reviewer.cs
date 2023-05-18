using System;
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
    }
}

