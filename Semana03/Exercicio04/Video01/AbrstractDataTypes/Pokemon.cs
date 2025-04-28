using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbrstractDataTypes
{
    public class Pokemon
    {
        string name;
        int exp;


        public Pokemon(string name, int exp){
            this.name = name;
            this.exp = exp;
        }

        public string Name {get{return name;} set{name = value;} }
        public int Exp {get{return exp;} set{exp = value;} }

        public bool IsPokemon(){
            return true;
        }
    }
}