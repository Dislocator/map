using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Wall> borders = new List<Wall>();
            Wall wall1 = new Wall(0, 0, 9, 1);
            borders.Add(wall1);
            Wall wall2 = new Wall(0, 1, 1, 9);
            borders.Add(wall2);
            Wall wall3 = new Wall(0, 9, 9, 1);
            borders.Add(wall3);
            Wall wall4 = new Wall(9, 0, 1, 9);
            borders.Add(wall4);


            List<Wall> walls = new List<Wall>();
            Wall wall5 = new Wall(1, 1, 4, 1);
            walls.Add(wall5);
            Wall wall6 = new Wall(1, 1, 1, 4);
            walls.Add(wall6);
            Wall wall7 = new Wall(1, 5, 1, 4);
            walls.Add(wall7);
            Wall wall8 = new Wall(6, 5, 1, 4);
            walls.Add(wall8);
            Wall wall9 = new Wall(4, 5, 1, 3);
            walls.Add(wall9);
            Wall wall10 = new Wall(7, 3, 2, 1);
            walls.Add(wall10);
            Wall wall11 = new Wall(2, 3, 1, 1);
            walls.Add(wall11);
            Wall wall12 = new Wall(3, 8, 1, 1);
            walls.Add(wall12);
            Wall wall13 = new Wall(6, 1, 1, 1);
            walls.Add(wall13);
            Wall wall14 = new Wall(2, 6, 1, 1);
            walls.Add(wall14);
            


            User user = new User();
            User login = new User("Login", 5, 8);
            user = login;
            Mob mob = new Mob();
            Mob krisa = new Mob("Krisa", 4, 4);
            int CurrentX, CurrentY;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------WELCOME----TO-----THE-----DUNGEON-MASTER------V0.1\n");
            Console.ResetColor();
            Console.WriteLine("Map Legend: \n O - Player \n M - Mob \n x - Wall \n $ - Treasure \n E - NextLevel\n");
            
            for (int y = 0; y < 10; y++)
            {
                

                for (int x = 0; x < 10; x++)
                {


                    bool Login = true;
                    foreach (var wall in borders)
                    {
                        if (x == wall.WallPosX && y == wall.WallPosY)
                        {
                            wall.WallCreate();
                            Login = false;
                        }

                    }
                    if (Login)
                    {
                        Console.Write(" ");
                        //Login = false;
                    }


                }
                Console.Write("\n");
           
            }


            Console.ReadKey();

            }
        }
    }


