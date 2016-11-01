using System;

namespace ConsoleApplication
{
    //Warning: Extremely slow. Should work but had to kill it. 
    public class Recursive
    {
        private static int sideLength = 2;
        private static int sideCheckpoints = sideLength + 1;
        private static int count = 0;
        public static void Run(string[] args)
        {

            Move(0,0);
            Console.WriteLine(count);
        }

        private static void Move(int x, int y)
        {
            if (x == sideCheckpoints - 1 && y == sideCheckpoints - 1)
            {
                ++count;
                return;
            }

            if(x == sideCheckpoints) return;
            if(y == sideCheckpoints) return;

            MoveRight(x,y);
            MoveDown(x,y);
        }

        private static void MoveRight(int x, int y){
            x++;
            Move(x,y);
        }

        private static void MoveDown(int x, int y){
            y++;
            Move(x,y);
        }
    }
}
