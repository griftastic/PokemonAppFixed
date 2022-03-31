using System.Collections.Generic;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemonTeam = new List<Pokemon>();
    

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level;
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne;
            pokemon.MoveTwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour;
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach (Pokemon p in _pokemonTeam)
            {
                if (nickName == p.PokemonNickName)
                {
                    p.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                    p.PokemonNickName = newPokemon.PokemonNickName;
                    p.Level = newPokemon.Level;
                    p.PokemonType = newPokemon.PokemonType;
                    p.SecondaryType = newPokemon.SecondaryType;
                    p.MoveOne = newPokemon.MoveOne;
                    p.MoveTwo = newPokemon.MoveTwo;
                    p.MoveThree = newPokemon.MoveThree;
                    p.MoveFour = newPokemon.MoveFour;

                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}