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
            Wall wall1 = new Wall(0, 0, 10, 1);
            borders.Add(wall1);
            Wall wall2 = new Wall(0, 0, 1, 10);
            borders.Add(wall2);
            Wall wall3 = new Wall(0, 9, 10, 1);
            borders.Add(wall3);
            Wall wall4 = new Wall(9, 0, 1, 10);
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

                    //if (x == login.PlayerPosX && y == login.PlayerPosY)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Black;
                    //    Console.BackgroundColor = ConsoleColor.Green;
                    //    Console.Write("O");
                    //    Console.ResetColor();
                    //    //}
                    //    //else if (x == krisa.MobPosX && y == krisa.MobPosX)
                    //    //{
                    //    //    Console.ForegroundColor = ConsoleColor.Black;
                    //    //    Console.BackgroundColor = ConsoleColor.Blue;
                    //    //    Console.Write("M");
                    //    //    Console.ResetColor();

                    //    //}
                    //}
                    //else if (x == 1 && y == 1 || x == 2 && y == 1 || x == 3 && y == 1 || x == 1 && y == 1 || x == 6 && y == 1 || x == 2 && y == 3 || x == 7 && y == 3 || x == 8 && y == 3 || x == 3 && y == 4 
                    //    || x == 1 && y == 5 || x == 4 && y == 5 || x == 6 && y == 5 || x == 1 && y == 6 || x == 4 && y == 6 || x == 6 && y == 6 || x == 1 && y == 7 || x == 4 && y == 7 || x == 6 && y == 7 
                    //    || x == 3 && y == 8 || x == 6 && y == 8)
                    //{
                    //        Console.BackgroundColor = ConsoleColor.Yellow;
                    //        Console.ForegroundColor = ConsoleColor.Black;
                    //        Console.Write("X");
                    //        Console.ResetColor();

                    //    }

                    foreach (var wall in borders)
                    {
                        if(x == wall.WallPosX && y == wall.WallPosY)
                        {
                            wall.WallCreate();
                            if(wall.WallSizeX > 1)
                            {
                                wall.WallPosX += 1;
                                wall.WallSizeX -= 1;
                                
                            }
                            if (wall.WallSizeY > 1)
                            {
                                wall.WallPosY += 1;
                                wall.WallSizeY -= 1;
                            }
                            
                        }
                    }
                        //else if (x == 1 && y == 8 || x == 8 && y == 8)
                        //{
                        //    Console.BackgroundColor = ConsoleColor.DarkBlue;
                        //    Console.ForegroundColor = ConsoleColor.Black;

                        //    Console.Write("E");
                        //    Console.ResetColor();

                        //}
                        //else if (x == 1 && y == 2 || x == 8 && y == 2 || x == 5 && y == 3 || x == 7 && y == 4 || x == 3 && y == 5 || x == 8 && y == 7 || x == 7 && y == 7 || x == 6 && y == 2 || x == 7 && y == 2)
                        //{
                        //    Console.ForegroundColor = ConsoleColor.Black;
                        //    Console.BackgroundColor = ConsoleColor.Blue;
                        //    Console.Write("M");
                        //    Console.ResetColor();

                        //}
                        //else if (x == 8 && y == 1 || x == 7 && y == 8)
                        //{
                        //Console.ForegroundColor = ConsoleColor.Black;
                        //Console.BackgroundColor = ConsoleColor.DarkYellow;
                        //Console.Write("$");
                        //Console.ResetColor();
                        //}
                        //else if (x == 0 | x == 9)
                        //{
                        //    Console.ForegroundColor = ConsoleColor.Black;
                        //    Console.BackgroundColor = ConsoleColor.Red;
                        //    Console.Write("|");
                        //    Console.ResetColor();

                        //}
                        //else if (y == 0 | y == 9)
                        //{
                        //    Console.ForegroundColor = ConsoleColor.Black;
                        //    Console.BackgroundColor = ConsoleColor.Red;
                        //    Console.Write("-");
                        //    Console.ResetColor();
                        //}

                        //else
                        //{
                        //    Console.BackgroundColor = ConsoleColor.White;

                        //    Console.Write(" ");
                        //    Console.ResetColor();

                        //}


                    }
                 Console.Write("\n");
            //    CurrentX = login.PlayerPosX;
            //    CurrentY = login.PlayerPosY;
            //    }
            //    Console.WriteLine("Choose your DESTINY!");
            //    Console.WriteLine("Move:\n 1. UP\n 2. Down\n 3. Left\n 4. Right");
            //    int move = Convert.ToInt32(Console.ReadLine());
            //    switch(move)
            //{
            //    case 1:
            //        if (login.PlayerPosX +1 && login.PlayerPosY == (x == 1 && y == 1 || x == 2 && y == 1 || x == 3 && y == 1 || x == 1 && y == 1 || x == 6 && y == 1 || x == 2 && y == 3 || x == 7 && y == 3 || x == 8 && y == 3 || x == 3 && y == 4
            //            || x == 1 && y == 5 || x == 4 && y == 5 || x == 6 && y == 5 || x == 1 && y == 6 || x == 4 && y == 6 || x == 6 && y == 6 || x == 1 && y == 7 || x == 4 && y == 7 || x == 6 && y == 7
            //            || x == 3 && y == 8 || x == 6 && y == 8))
            //        {

            //        }
            //            break;
                    
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    case 4:
            //        break;
            //    default:
            //        break;
            }
                

            

            }
        }
    }


