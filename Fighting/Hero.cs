using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Hero
    {
        public string Name { get; set; }
        public double Mana { get; set; }
        public int Inventory { get; set; }
        public double HP { get; set; }
        public double Resistance { get; set; }
        public List<Ability> Abilities { get; set; }
        public double Xp { get; set; }
        public Hero(string Name, double HP, double Resistance, List<Ability> Abilities)
        {
            this.Name = Name;
            this.HP = HP;
            this.Resistance = Resistance;
            this.Abilities = Abilities;
        }
        public Hero()
        {

        }
    }
}
