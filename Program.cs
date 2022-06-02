using System;
using System.Collections.Generic;

namespace Objektorientering
{
    class Program
    {
        //Pause til 13.35 ^^ 
        static void Main(string[] args)
        {
            // Lag en liste av pokemon man kan møte når man går i grasset
            // Velg en random av de til å sloss med en player pokemon til en av dem har dødd

            var player = new Player("Bjarne");
            PlayerWalksInGrass(player);
        }

        public static void PlayerWalksInGrass(Player player)
        {
            var pokemonInGrass = new List<Pokemon>();
            pokemonInGrass.Add(new Snorlax());
            pokemonInGrass.Add(new Charmander());
            pokemonInGrass.Add(new Magicarp());
            pokemonInGrass.Add(new Gengar());
            pokemonInGrass.Add(new Ditto());

            var random = new Random();
            int index = random.Next(pokemonInGrass.Count);
            var randPokemon = pokemonInGrass[index];

            player.Fight(randPokemon);


        }
    }
}
