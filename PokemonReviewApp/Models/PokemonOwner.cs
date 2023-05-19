namespace PokemonReviewApp.Models
{
    // The PokemonOwner model is a join entity that enables the many-to-many relationship between Pokemon and Owner.
    public class PokemonOwner
    {
        // The ID of the associated Pokemon.
        public int PokemonId { get; set; }

        // The ID of the associated Owner.
        public int OwnerId { get; set; }

        // Navigation property to the associated Pokemon.
        public Pokemon Pokemon { get; set; }

        // Navigation property to the associated Owner.
        public Owner Owner { get; set; }
    }
}
