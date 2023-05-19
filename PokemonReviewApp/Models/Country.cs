namespace PokemonReviewApp.Models
{
    // Country model to represent the Country data inside the MySQL database.
    public class Country
	{
        // Unique ID for each Country
        public int Id { get; set; }

        // Name of the Country
        public string Name { get; set; }

        // Collection of Owners associated with the Country
        public ICollection<Owner> Owners { get; set; }
    }
}

