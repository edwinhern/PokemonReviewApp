namespace PokemonReviewApp.Models
{
    // Review model to represent the Review data inside the MySQL database.
    public class Review
	{
        // Unique ID for each Review
        public int Id { get; set; }

        // Title of the Review
        public string Title { get; set; }

        // Text included with the Review
        public string Text { get; set; }

        // Rating of the Review
        public int Rating { get; set; }

        // Reviewer who wrote the Review
        public Reviewer Reviewer { get; set; }

        // Pokemon which the Review is about
        public Pokemon Pokemon { get; set; }
    }
}

