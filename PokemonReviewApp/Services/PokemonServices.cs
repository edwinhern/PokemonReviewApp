using System;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Services
{
	public class PokemonServices : IPokemonServices
	{
		private readonly IPokemonRepository _pokemonRepository;

		public PokemonServices(IPokemonRepository pokemonRepository)
		{
			_pokemonRepository = pokemonRepository;
		}

        public ICollection<Pokemon> GetPokemons()
        {
            return _pokemonRepository.GetPokemons();
        }
    }
}

