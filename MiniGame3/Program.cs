using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            StartGame();

            
            Console.ReadLine();

        }
        private static void StartGame()
        {

            List<Soccer> team = new List<Soccer>();

            team.Add(new Soccer("Goal Keeper", 1));
            team.Add(new Defence("Defence 1", 2));
            team.Add(new Defence("Defence 2", 3));
            team.Add(new Defence("Defence 3", 4));
            team.Add(new Defence("Defence 4", 5));
            team.Add(new Midfield("Midfield 1", 6));
            team.Add(new Midfield("Midfield 2", 7));
            team.Add(new Midfield("Midfield 3", 8));
            team.Add(new Midfield("Midfield 4", 9));
            team.Add(new Forward("Forward 1", 10));
            team.Add(new Forward("Forward 2", 11));

            Random random = new Random();
            int SoccerShirt;
            int PassControl = 12;
            bool CanBeScored;
            SoccerShirt = random.Next(1, 12);
            Console.WriteLine("The team went on the offensive!");
            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                while (PassControl == SoccerShirt)
                {
                    SoccerShirt = random.Next(1, 12);
                }

                PassControl = SoccerShirt;
                if (!team[SoccerShirt - 1].GivePass())
                {
                    Console.WriteLine("The No: " + SoccerShirt + " player's pass fails!");
                    CanBeScored = false;
                    break;
                }
                else
                {
                    Console.WriteLine("The No: " + SoccerShirt + " player's pass successful!");

                }



            }

            Console.WriteLine("-----------------------------------------------");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("The number " + SoccerShirt + "player faces the goalkeeper...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("-----------------------------------------------");
            System.Threading.Thread.Sleep(1000);

            if (CanBeScored = true)
            {
                if (team[SoccerShirt - 1].GoalShoot())
                {

                    Console.WriteLine("Goallllllll!!!!");
                }
                else
                {

                    Console.WriteLine(SoccerShirt + " Missed the Goal!");

                }
            }

        }


    }
}
