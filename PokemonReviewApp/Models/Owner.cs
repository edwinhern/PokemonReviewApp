namespace PokemonReviewApp.Models
{
    // Owner model to represent the Owners data inside the MySQL database.
    public class Owner
	{
        // Unique ID for each Owner
        public int Id { get; set; }

        // Name of the Owner
        public string Name { get; set; }

        // Name of the Gym they are associated with
		public string Gym { get; set; }

        // Country where the Owner is located
        public Country Country { get; set; }

        // Collection of many-to-many join entities that associates Pokemon with Owners.
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}

