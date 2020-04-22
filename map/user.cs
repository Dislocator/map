using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class User
    {
        public string Name { get; set; }
        public int PlayerPosX { get; set; }
        public int PlayerPosY { get; set; }
        public User(string Name, int PlayerPosX, int PlayerPosY)
        {
            this.Name = Name;
            this.PlayerPosX = PlayerPosX;
            this.PlayerPosY = PlayerPosY;

        }
        public User()
        {

        }
    }
}
