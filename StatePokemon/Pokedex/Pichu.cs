using StatePokemon.Interfaces;
using StatePokemon.Pokedex;
using StatePokemon.Pokemon;

namespace StatePokemon.Pokedex
{
	class Pichu : IChangeale
	{
		// its like an override
		public void Evolve(PPokemon pokemon) => pokemon.State = new Pikachu();
		public void DisEvolve(PPokemon pokemon) { }
	}
}
class Pikachu : IChangeale
{
	// its like an override
	public void Evolve(PPokemon pokemon) => pokemon.State = new Raichu();
	public void DisEvolve(PPokemon pokemon) => pokemon.State = new Pichu();
}
class Raichu : IChangeale
{
	public void Evolve(PPokemon pokemon) { }
	public void DisEvolve(PPokemon pokemon) => pokemon.State = new Pikachu();

}