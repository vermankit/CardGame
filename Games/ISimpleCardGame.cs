using CardGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Games
{
    public interface ISimpleCardGame
    {
        /// <summary>
        /// Method to display menu of game
        /// </summary>
        void DisplayMenu();


        /// <summary>
        /// Function to draw the card from deck
        /// </summary>
        Card DrawCard();

        /// <summary>
        /// Function to reset the deck to 52 cards
        /// </summary>
        void ResetDeck();

        /// <summary>
        /// Function to shuffle the card in deck;
        /// </summary>
        void ShuffleCards();

        /// <summary>
        /// Restart Game
        /// </summary>
        void RestartGame();

        /// <summary>
        /// Card in deck
        /// </summary>
        /// <returns></returns>
        int LeftCards();

    }
}
