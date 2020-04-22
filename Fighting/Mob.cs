using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Mob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Hp { get; set; }
        public double Resistance { get; set; }
        public double Damage { get; set; }
        public Mob(int Id, string Name, double Hp, double Resistance, double Damage)
        {
            this.Name = Name;
            this.Hp = Hp;
            this.Resistance = Resistance;
            this.Damage = Damage;
            this.Id = Id;
        }
        public Mob()
        {

        }
    }
}
