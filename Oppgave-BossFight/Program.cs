using System;

namespace Oppgave_BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = new GameCharacter(100, 20, 40,"Moron");
            var boss = new GameCharacter(400,30, 10,"Boss");
            var playerTurn = true;

            while (player1._alive && boss._alive)
            {
                if (playerTurn)
                {
                    player1.Fight(boss);
                    playerTurn = false;
                }
                else
                {
                    boss.Fight(player1);
                    playerTurn = true;
                } 
            }
        }
    }
}
