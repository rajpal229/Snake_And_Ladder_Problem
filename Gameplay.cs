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
            int chance = 0;
            int die = DiceRoll();
            while (playerPosition < WINNING_POSITION)
            {
                int ROLL = random.Next(0, 3);
                //Console.WriteLine(ROLL);
                switch (ROLL)
                {
                    case 0:
                        DiceRoll();
                        Console.WriteLine("No Play: Stay on your position");
                        playerPosition += 0;
                        break;
                    case 1:
                        playerPosition += DiceRoll();
                        if(playerPosition > WINNING_POSITION)
                        {
                            playerPosition -= DiceRoll();
                            Console.WriteLine("No Play: Stay on your position");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ladder: Move Forward");
                        }
                        break;
                    case 2:
                        playerPosition -= DiceRoll();
                        Console.WriteLine("Snake: Go Back");
                        if(playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                }
                chance += 1;
                Console.WriteLine("You're New Position - "+playerPosition);
            }
            Console.WriteLine("Count of Dice Played: "+chance);
            Console.WriteLine("*****You have won the Game*****");
        }
    }
}
