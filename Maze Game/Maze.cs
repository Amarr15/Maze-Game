using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Maze
    {
        private int _Width, _Height;
        private Player _Player;
        private IMazeObject[,] _MazeObjectsArray;
        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectsArray = new IMazeObject[width, height];
            _Player = new Player()
            {
                x = 1,
                y = 1,
            };
        }
        public void DrawMaze()
        {
            Console.Clear();
            for(int y = 0; y < _Height; y++)
            {
                for(int x = 0; x < _Width; x++)
                {
                    if(x==39 && y==19)
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if(x == 0 || y == 0 || x == _Width-1 || y == _Height-1)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x,y].Icon);
                    }
                    else if (x == _Player.x && y ==_Player.y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else if (x%2 ==0 && y%2==0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x % 4 == 0 && y % 4 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x % 7 == 0 && y % 7 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }
        }
        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            ConsoleKey Key = userInput.Key;

            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    UpDatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpDatePlayer(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    UpDatePlayer(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpDatePlayer(-1, 0);
                    break;
            }
        }

        public void UpDatePlayer(int dx, int dy)
        {
            int newX=_Player.x + dx;
            int newY=_Player.y + dy;
            if (newX < _Width && newX>=0 && newY< _Height && newY>=0 && _MazeObjectsArray[newX,newY].IsSolid == false)
            {
                _Player.x = newX;
                _Player.y = newY;
                DrawMaze();
            }
        }

    }
}
