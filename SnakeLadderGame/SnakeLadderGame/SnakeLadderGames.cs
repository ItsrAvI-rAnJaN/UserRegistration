using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    internal class SnakeLadderGames
    {
        // Assingn Winning Player
        int Win = 0;

        // player Num
        int[] Player = { 0, 0 };

        // Dice Count of Each Player 
        int[] PlayerDice = { 0, 0 };

        // Create Method to Playing Games by twio Player
        public void PlayGames()
        {
            int DiceRoll;
            int ArrayIndex;
            Random random = new Random();

            string[] choiceArray = { "NoPlay", "Ladder", "Snake" };
            int Turn = 0;
            while (Player[0] < 100 && Player[1] < 100)
            {
                Console.WriteLine("\nPlayer " + (Turn + 1) + " is playing");
                Console.WriteLine("Player " + (Turn + 1) + " Current Position : {0} ", Player[Turn]);

                // Dice Roll to Get 1 to 6 no
                DiceRoll = random.Next(1, 7);
                PlayerDice[Turn]++;
                Console.WriteLine("Player " + (Turn + 1) + " Dice Roll are :{0} ", PlayerDice[Turn]);
                Console.WriteLine("Number Appeared on Dice is :{0} ", DiceRoll);

                //Player Options generation "Array"
                ArrayIndex = random.Next(choiceArray.Length);
                Console.WriteLine("Player Option is : {0}", choiceArray[ArrayIndex]);

                //Actions according to player option
                if (choiceArray[ArrayIndex] == "NoPlay" && Turn == 0)
                {
                    Turn = 1;
                    continue;
                }
                else if (choiceArray[ArrayIndex] == "NoPlay" && Turn == 1)
                {
                    Turn = 0;
                    continue;
                }
                if (choiceArray[ArrayIndex] == "Ladder")
                {
                    //If player position reach at 100.
                    if ((Player[Turn] + DiceRoll) >= 100)
                    {
                        Player[Turn] = 100;
                        Win = Turn;
                        break;
                    }
                    else
                    {
                        Player[Turn] += DiceRoll;
                        continue;
                    }
                }
                else if (choiceArray[ArrayIndex] == "Snake")
                {
                    //If Player Position is Less than the Number Appeared on Dice
                    if (Player[Turn] < DiceRoll)
                    {
                        Player[Turn] = 0;
                    }
                    else
                    {
                        Player[Turn] -= DiceRoll;
                    }
                }

                //If any player reaches to 100
                if (Player[0] == 100 || Player[1] == 100)
                {
                    Win = Turn;
                    break;
                }

                //Changing turns Playe 1 or Player 2
                if (Turn == 0)
                {
                    Turn = 1;
                }
                else
                {
                    Turn = 0;
                }
            }
            Console.WriteLine("\n################################");
            Console.WriteLine("\nWinner : Player {0}", (Win + 1));
            Console.WriteLine("Player Current position : {0} ", Player[Win]);
        }

    }




}