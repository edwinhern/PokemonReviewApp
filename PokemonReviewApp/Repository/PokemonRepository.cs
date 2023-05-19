using System;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    // This class is a repository that implements the IPokemonRepository interface.
    // It is responsible for interacting with the database context to perform operations related to Pokemon.
    public class PokemonRepository : IPokemonRepository
    {
        // This is a private field that holds the reference to the database context.
        private readonly DataContext _context;

        // This is the constructor of the PokemonRepository class. 
        // It takes a DataContext object as a parameter which is injected from the outside when creating an instance of the class.
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        // This method gets all the Pokemon from the database, ordered by their Id, and returns them as a List.
        // ICollection is a type that represents a collection of objects that can be individually accessed by index.
        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
