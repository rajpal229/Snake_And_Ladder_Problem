namespace Snake_And_Ladder_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            Gameplay playerPosition = new Gameplay();
            playerPosition.Position();
            Gameplay dice = new Gameplay();
            dice.DiceRoll();
            Gameplay check = new Gameplay();
            check.Check();


        }
    }
}