using StatePokemon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StatePokemon.Pokemon
{
	internal class PPokemon
	{
        public IChangeale State{ private get; set; }
        public PPokemon(IChangeale state) => State = state; 
        
        public string Evolve()
        {
            State.Evolve(this);
            return State.GetType().Name;
        }
        public string DisEvolve()
        {
            State.DisEvolve(this);
            return State.GetType().Name;
        }

    }
}
