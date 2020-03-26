using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Entities
{
     /// <summary>
     /// Contract for Deck
     /// </summary>
    public interface IDeck
    {      
        /// <summary>
        /// Method to shuffle the card
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Method to draw the card
        /// </summary>
        /// <returns></returns>
        Card DrawCard();

        /// <summary>
        /// Method to reset the deck
        /// </summary>
        void ResetDeck();

        /// <summary>
        /// Get the count of total card in deck
        /// </summary>
        /// <returns></returns>
        int TotalCard();

    }
}
