using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Problem
{
    internal class Gameplay
    {
        Random random = new Random();
        int WINNING_POSITION = 100;
        int playerPosition = 0;
        public void Position()
        {
            int playerPosition = 0;
            Console.WriteLine("Lets Play");
            Console.WriteLine("You are at " + playerPosition);
            Console.WriteLine("Lets Roll the Die");
        }
        public int DiceRoll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Result on Dice" + "\n" + dice);
            return dice;
        }
        public void Check()
        {
            while (playerPosition < WINNING_POSITION)
            {
                int ROLL = random.Next(0, 3);
                Console.WriteLine(ROLL);
                switch (ROLL)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        playerPosition += 0;
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        playerPosition += DiceRoll();
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        playerPosition += DiceRoll();
                        break;
                }
                Console.WriteLine("You're at - "+playerPosition);
            }
        }
    }
}
