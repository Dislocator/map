using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Ability
    {
        public int AbbilityId { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public int Reload { get; set; }
        public int Stun { get; set; }
        public double Resistance { get; set; }
        public int LongTurmEffect { get; set; }
        public double ManaCost { get; set; }
        public Ability(int AbbilityId, string Name, double Damage, int Reload, int Stun, double Resistance, int LongTurmEffect)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Reload = Reload;
            this.Stun = Stun;
            this.Resistance = Resistance;
            this.LongTurmEffect = LongTurmEffect;
            this.AbbilityId = AbbilityId;
        }
    }
}
