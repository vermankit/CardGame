using CardGame.Entities;
using CardGame.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class CardGameApp
    {
        private readonly ISimpleCardGame _simpleCardGame;
        public CardGameApp(ISimpleCardGame simpleCardGame)
        {
            _simpleCardGame = simpleCardGame;
        }
        public void Start()
        {
            Console.WriteLine(AppConstants.WelcomeLine);
            Console.WriteLine(AppConstants.DottedLine);
            try
            {
                _simpleCardGame.DisplayMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Starting Game {ex.Message}");
                if(ex is InvalidOperationException)
                {
                    Console.WriteLine(SimpleCardGameConstants.Restarting);
                    _simpleCardGame.RestartGame();
                    _simpleCardGame.DisplayMenu();
                }
            }
          
        }
    }
}
