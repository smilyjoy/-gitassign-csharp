using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Game
    {

        class Player
        {
            public string Name { get; set; }
            public int Runs { get; set; }

            public Player(string name, int runs)
            {
                Name = name;
                Runs = runs;
            }
        }

        class Team : IEnutmerable
        {
            private Player[] playerArray = new Player[4];
            public Team()
            {
                playerArray[0] = new Player("Rohit", 30);
                playerArray[1] = new Player("Anil", 40);
                playerArray[2] = new Player("Ajay", 28);
                playerArray[3] = new Player("Sunil", 20);
            }
            public IEnumerator GetEnumerator()
            {
                return playerArray.GetEnumerator();
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                Team obj = new Team();
                foreach (Player p in obj)
                {
                    Console.WriteLine("Name is {0} and Runs is {1}", p.Name, p.Runs);
                }
                Console.ReadLine();
            }


        }
    }
}
    
