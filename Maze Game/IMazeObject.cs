using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public interface IMazeObject
    {
        //Here we deleted (set) because the wall will be fixed
        char Icon { get;} //The Chape Of The Maze Object
        bool IsSolid { get;} //Movement Block
    }
}
