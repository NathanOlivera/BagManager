using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Pokemon
    {
        public string name;
        public string especie;
        public string tipo;
        public int nivel;
        public int hp;
        public int hpmax;
        public bool paralisado;
        public bool envenenado;

        public override string ToString()
        {
            return $"{name} Nivel: {nivel} HP Atual: {hp} HP Max: {hpmax} {(paralisado == true ? "Paralisado" : "")} {(envenenado == true ? "Envenenado" : "")}";

        }

        public Pokemon(string name, string especie, string tipo, int nivel, int hp, int hpmax, bool paralisado, bool envenenado)
        {
            this.name = name;
            this.especie = especie;
            this.tipo = tipo;
            this.nivel = nivel;
            this.hp = hp;
            this.hpmax = hpmax;
            this.paralisado = paralisado;
            this.envenenado = envenenado;
        }
    }
}
