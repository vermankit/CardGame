using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Entities
{
    /// <summary>
    /// Class to represent a card of deck 
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Prop to store the value of card
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Prop to store the suit to which the card belong
        /// </summary>
        public Suit Suit { get; set; }

        /// <summary>
        /// Method to diplay the name of
        /// </summary>
        /// <returns></returns>
        public override string ToString()        
        {
            return $"{Value} of {Suit.ToString()}";
        }
    }
}
