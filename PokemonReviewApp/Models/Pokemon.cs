﻿namespace PokemonReviewApp.Models
{
    // Pokemon model to represent the Pokemon data inside the MySQL database.
    public class Pokemon
    {
        // Unique ID for each Pokemon
        public int Id { get; set; }

        // Name of the Pokemon
        public string Name { get; set; }

        // BirthDate represents the creation date of this specific Pokemon record in the database
        public DateTime BirthDate { get; set; }
    }
}
