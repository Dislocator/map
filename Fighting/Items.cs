using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double effect { get; set; }
        public int count { get; set; }
        public int duration { get; set; }
        public Items(int Id, string Name, double effect, int duration)
        {
            this.Id = Id;
            this.Name = Name;
            this.effect = effect;
            this.duration = duration;

        }
    }
}
