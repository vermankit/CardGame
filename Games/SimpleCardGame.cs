using CardGame.Entities;
using CardGame.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Class for simple card game
    /// </summary>
    public class SimpleCardGame : ISimpleCardGame
    {
        private readonly IDeck _deck;

        public SimpleCardGame(IDeck deck)
        {
            _deck = deck;
        }

        /// <summary>
        /// Method to display menu of game
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine(SimpleCardGameConstants.MenuInfo);

            Console.WriteLine($"{ SimpleCardGameConstants.DrawCard} \n{SimpleCardGameConstants.ShuffleCard} \n{SimpleCardGameConstants.RestartGame} \n{SimpleCardGameConstants.Exit}");

            string selectedOperation = string.Empty;
            //shuffle card before start;
            _deck.Shuffle();
            Console.WriteLine($"{SimpleCardGameConstants.CardInDeck} {LeftCards()}");

            while (selectedOperation != "4")
            {
                Console.WriteLine(AppConstants.DottedLine);
                Console.WriteLine(SimpleCardGameConstants.MenuInfo);
                selectedOperation = Console.ReadLine();
                switch (selectedOperation)
                {
                    case "1":
                        var result = DrawCard();
                        Console.WriteLine($"{SimpleCardGameConstants.CardPicked} {result.ToString()} {SimpleCardGameConstants.CardLeft} {LeftCards()}");
                        break;
                    case "2":
                        ShuffleCards();
                        Console.WriteLine(SimpleCardGameConstants.CardShuffled);
                        break;
                    case "3":
                        Console.WriteLine(SimpleCardGameConstants.Restarting);
                        RestartGame();
                        Console.WriteLine(SimpleCardGameConstants.Restarted);
                        DisplayMenu();
                        break;
                    default:
                        Console.WriteLine(SimpleCardGameConstants.InvalidMessage);
                        break;
                }
            };
        }
        /// <summary>
        /// Restart Game
        /// </summary>
        public void RestartGame()
        {
            try
            {
                ResetDeck();
                _deck.Shuffle();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Function to draw the card from deck
        /// </summary>
        public Card DrawCard()
        {            
            try
            {

                if (_deck.TotalCard() == 0)
                {
                    throw new InvalidOperationException(SimpleCardGameConstants.NoCard);
                }
                return _deck.DrawCard(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        /// <summary>
        /// Function to reset the deck to 52 cards
        /// </summary>
        public void ResetDeck()
        {
            try
            {
                _deck.ResetDeck();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Function to shuffle the card in deck;
        /// </summary>
        public void ShuffleCards()
        {
            try
            {
                if (_deck.TotalCard() == 0)
                {
                    throw new InvalidOperationException(SimpleCardGameConstants.NoCard);
                }
                _deck.Shuffle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Card Left in deck
        /// </summary>
        /// <returns></returns>
        public int LeftCards()
        {
            try
            {
                return _deck.TotalCard();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
