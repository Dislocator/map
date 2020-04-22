using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Temp
    {
        public void tempo()
        {
            List<Items> items = new List<Items>();


            Items PotionLuck = new Items(3, "Мне повезёт!", 30, 5);// 5
            Items PotionEvade = new Items(4, "Бутылка", 100, 1); //Уход из боя 3
            Items PotionStun = new Items(5, "Футболка \"Зенит\"", 50, 3); //Стан 5
            Items SwordOfThuth = new Items(6, "Меч тысячи Истин", 50, 10); //+ к урону 1
            for (int i = 0; i < 20; i++)
            {
                Items PotionHeal = new Items(1, "Зелье Пажилого Лечения", 100, 1);// 20
                items.Add(PotionHeal);

            }
            for (int i = 0; i < 10; i++)
            {
                Items PotionDex = new Items(2, "Пиво \"Жигулёвское\"", 35, 5);//Шанс уворота 10
                items.Add(PotionDex);

            }


            List<Mob> mobs = new List<Mob>();
            Mob RadTarakan = new Mob(1, "Рад-таракан", 50, 0, 10);
            mobs.Add(RadTarakan);
            Mob Adidas = new Mob(2, "Гопник from ППК", 100, 0, 20);
            mobs.Add(Adidas);
            Mob AdidasAdvanced = new Mob(3, "Гопник from ХНУРЭ", 200, 0, 40);
            mobs.Add(AdidasAdvanced);
            Mob Vahter = new Mob(4, "Вахтёр", 250, 0, 5);
            mobs.Add(Vahter);
            Mob Saenko = new Mob(5, "Саенко", 2000, 0, 1);
            mobs.Add(Saenko);
            Mob Gomunkul = new Mob(6, "Гумункул", 200, 0, 30);
            mobs.Add(Gomunkul);
            List<Ability> allAbility = new List<Ability>();
            Ability journal = new Ability(1, "Бросить журналом посещаимости", 250, 2, 0, 0, 0);
            allAbility.Add(journal);
            Ability theoreme = new Ability(2, "Рассказать теорему", 10, 1, 0, 0, 0);
            allAbility.Add(theoreme);
            Ability advise = new Ability(3, "Дать совет", 50, 5, 0, 0, 0);
            allAbility.Add(advise);
            Ability dialoge = new Ability(4, "Попытаться завязать диалог", 3, 1, 0, 0, 0);
            allAbility.Add(dialoge);
            Ability Slam = new Ability(5, "Пнуть ногой", 30, 3, 0, 0, 0);
            allAbility.Add(Slam);
            List<Ability> abilities = new List<Ability>();
            Hero hero = new Hero();
            Console.WriteLine("Выбери героя!\n" +
                "1. Login \n" +
                "2. Анимешник \n" +
                "3. Шурик из БЭЭЛ \n" +
                "4. ДядяЧуприн \n"
                );
            string PickHero = Console.ReadLine();
            switch (PickHero)
            {
                case "1":
                    Hero login = new Hero("Login", 1000, 0, abilities);
                    hero = login;
                    break;
                case "2":
                    Hero anime = new Hero("Анимешник", 100, 0, abilities);
                    hero = anime;
                    break;
                case "3":
                    Hero gay = new Hero("Шурик из БЭЭЛ", 100, 0, abilities);
                    hero = gay;
                    break;
                case "4":
                    Hero chuprin = new Hero("ДядяЧуприн", 100, 0, abilities);
                    hero = chuprin;
                    break;
                default:
                    Console.WriteLine("Нет такого героя! Не придумали! Выбирай из того, что есть");
                    break;
            }
            Console.WriteLine($"Был выбран Герой {hero.Name}");

            for (int i = 1; i < 3; i++)
            {
                foreach (var spell in allAbility)
                {
                    Console.WriteLine($"{spell.AbbilityId} {spell.Name}");
                }

                int ChosenAblility = Convert.ToInt32(Console.ReadLine());
                abilities.Add(allAbility[ChosenAblility - 1]);
                Console.WriteLine($"Выбран скилл!{allAbility[ChosenAblility - 1].Name}");

            }
            Console.WriteLine("Твои скиллы:");
            foreach (var spell in abilities)
            {
                Console.WriteLine(spell.Name);

            }
            bool Fight = true;
            while (Fight)
            {
                Random random = new Random();
                int IndexRandom = random.Next(0, mobs.Count);
                Mob RandomMob = new Mob();
                RandomMob = mobs[IndexRandom];

                Console.WriteLine($"Ты встретил врага {RandomMob.Name}\n" +
                $"Твой ход! Выбирай абилку:\n" +
                $"");
                while (RandomMob.Hp > 0 && hero.HP > 0)
                {
                    Console.WriteLine("Твой ход! Выбирай абилку:");
                    foreach (var spell in abilities)
                    {
                        Console.WriteLine((abilities.IndexOf(spell) + 1) + " " + spell.Name);

                    }
                    int abil = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine($"Кастую {abilities[abil - 1].Name}");
                    RandomMob.Hp -= abilities[abil - 1].Damage;
                    Console.WriteLine($"Ты нанёс { abilities[abil - 1].Damage} урона!");
                    Console.WriteLine($"У моба осталось: {RandomMob.Hp} ХП!");

                    hero.HP -= RandomMob.Damage;
                    Console.WriteLine($"{RandomMob.Name} ударил тебя и нанёс {RandomMob.Damage}");
                    Console.WriteLine($"У тебя осталось {hero.HP} ХП!");
                }

                if (RandomMob.Hp <= 0)
                {
                    Console.WriteLine($"{RandomMob.Name} повержен!");
                    Console.WriteLine($"У тебя осталось: {hero.HP} ХП");

                }
                else
                {
                    Console.WriteLine($"Ты умер, даже не убив {RandomMob.Name} Shame! Shame! Shame! \n у него осталось {RandomMob.Hp} ХП кста");
                    Fight = false;
                }
                Console.WriteLine();
            }

        }
    }
}
