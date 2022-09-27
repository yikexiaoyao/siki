using System;

namespace _045_枚举
{
    class Program
    {
        //枚举
        //enum RoleType
        //{
        //    Mage, Archer, Assassin, Tank, Support, Warrior
        //}
        //enum GameState
        //{
        //    Menu,Running,Pause,Fail,Success
        //}
        enum Week
        {
            Sun, Mon, Tue, Wed, THu, Fri, Sat
        }
        static void Main(string[] args)
        {
            //RoleType roleType = RoleType.Assassin;

            //GameState gameState = GameState.Menu;
            //gameState = GameState.Running;
            //if (gameState == GameState.Menu)
            //{

            //}
            //Console.WriteLine(gameState);

            Week day = Week.Mon;
            day = Week.Tue;
            int d = (int)day;
            Console.WriteLine(day);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
