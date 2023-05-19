namespace PokemonReviewApp.Models
{
    // The PokemonCategory model is a join entity that enables the many-to-many relationship between Pokemon and Category.
    public class PokemonCategory
    {
        // The ID of the associated Pokemon.
        public int PokemonId { get; set; }

        // The ID of the associated Category.
        public int CategoryId { get; set; }

        // Navigation property to the associated Pokemon.
        public Pokemon Pokemon { get; set; }

        // Navigation property to the associated Category.
        public Category Category { get; set; }
    }
}
