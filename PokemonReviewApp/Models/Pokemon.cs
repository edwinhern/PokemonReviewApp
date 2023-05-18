namespace PokemonReviewApp.Models
{
	// Model: Used to represent the data inside the database (MySQL)
	public class Pokemon
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public DateTime BirthDate { get; set; }
	}
}

