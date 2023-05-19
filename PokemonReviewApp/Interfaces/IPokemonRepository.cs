using System;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    // This is an interface for the PokemonRepository.
    // It defines the methods that a PokemonRepository should have.
    public interface IPokemonRepository
    {
        // This method declaration says that any class that implements IPokemonRepository should have a GetPokemons method 
        // that returns a collection of Pokemon objects.
        ICollection<Pokemon> GetPokemons();
    }
}
