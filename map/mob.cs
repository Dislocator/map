using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class Mob
    {
        public string Name { get; set; }
        public int MobPosX { get; set; }
        public int MobPosY { get; set; }
        public Mob(string Name, int MobPosX, int MobPosY)
        {
            this.Name = Name;
            this.MobPosX = MobPosX;
            this.MobPosY = MobPosY;

        }
        public Mob()
        {

        }
    }
}
