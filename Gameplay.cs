using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Problem
{
    internal class Gameplay
    {
        Random random = new Random();
        int WINNING_POSITION = 100, turn = 1;
        int player_1_Position = 0, player_2_Position = 0;

        
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
            int chance1 = 0, chance2 = 0;
            while (player_1_Position < WINNING_POSITION && player_2_Position < WINNING_POSITION)
            {
                void PlayerSelection()
                {
                    switch (turn)
                    {
                        case 1:
                            Console.WriteLine("Chance of Player 1");
                            break;
                        default:
                            Console.WriteLine("Chance of Player 2");
                            break;
                    }
                }
                if (turn == 1)
                {
                    PlayerSelection();
                    Console.WriteLine("Player1 is at: "+player_1_Position);
                    int ROLL = random.Next(0, 3);
                    //Console.WriteLine(ROLL);
                    switch (ROLL)
                    {
                        case 0:
                            DiceRoll();
                            Console.WriteLine("No Play: Stay on your position");
                            player_1_Position += 0;
                            break;
                        case 1:
                            player_1_Position += DiceRoll();
                            if (player_1_Position > WINNING_POSITION)
                            {
                                player_1_Position -= DiceRoll();
                                Console.WriteLine("No Play: Stay on your position");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ladder: Move Forward");
                            }
                            break;
                        case 2:
                            player_1_Position -= DiceRoll();
                            Console.WriteLine("Snake: Go Back");
                            if (player_1_Position < 0)
                            {
                                player_1_Position = 0;
                            }
                            break;
                    }
                    chance1 += 1;
                    Console.WriteLine("You're New Position - " + player_1_Position);
                    turn += 1;
                }
                else
                {
                    PlayerSelection();
                    Console.WriteLine("Player2 is at: " + player_2_Position);
                    int ROLL = random.Next(0, 3);
                    //Console.WriteLine(ROLL);
                    switch (ROLL)
                    {
                        case 0:
                            DiceRoll();
                            Console.WriteLine("No Play: Stay on your position");
                            player_2_Position += 0;
                            break;
                        case 1:
                            player_2_Position += DiceRoll();
                            if (player_2_Position > WINNING_POSITION)
                            {
                                player_2_Position -= DiceRoll();
                                Console.WriteLine("No Play: Stay on your position");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ladder: Move Forward");
                            }
                            break;
                        case 2:
                            player_2_Position -= DiceRoll();
                            Console.WriteLine("Snake: Go Back");
                            if (player_2_Position < 0)
                            {
                                player_2_Position = 0;
                            }
                            break;
                    }
                    chance2 += 1;
                    Console.WriteLine("You're New Position - " + player_2_Position);
                    turn -= 1;
                }
            }
            Console.WriteLine("Count of Dice Played by Player1: "+chance1);
            Console.WriteLine("Count of Dice Played by Player2: " + chance2);
            if (player_1_Position == 100)
            {
                Console.WriteLine("*****Player1 have won the Game*****");
            }
            else
            {
                Console.WriteLine("*****Player2 have won the Game*****");
            }
        }
    }
}
