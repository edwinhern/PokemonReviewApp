using System;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
	public interface IPokemonServices
	{
        ICollection<Pokemon> GetPokemons();
    }
}

