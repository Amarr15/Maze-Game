namespace Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello To The Maze Game (:");
            Console.WriteLine("Use Keyboard Arrows To Move The Player");

            Maze maze = new Maze(60,20);
            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }

        }
    }
}
