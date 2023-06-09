﻿namespace PokemonReviewApp.Models
{
    // Category model to represent the Category data inside the MySQL database.
    public class Category
	{
        // Unique ID for each Category
        public int Id { get; set; }

        // Name of the Category
        public string Name { get; set; }

        // Collection of many-to-many join entities that associates Pokemon with Categories.
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}

