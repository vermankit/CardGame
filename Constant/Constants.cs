using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Class to store constants
    /// </summary>
    public class CardConstants
    {
        /// <summary>
        /// This represent the value of Card with is Ace
        /// </summary>
        public const int MinCardValue = 1;
        /// <summary>
        /// This represent the value of Card with is Ace
        /// </summary>
        public const int MaxCardValue = 13;

        /// <summary>
        /// Represent Ace of card
        /// </summary>
        public const string Ace = "A";

        /// <summary>
        /// Representd King of card
        /// </summary>
        public const string King = "K";

        /// <summary>
        /// Represent Ace of card
        /// </summary>
        public const string Queen = "A";

        /// <summary>
        /// Represent  Jack of card
        /// </summary>
        public const string Jack = "Q";
    }

    public class AppConstants
    {
        public const string WelcomeLine = "Welcome To Card Game";
        public const string DottedLine = ".......................";

    }

    public class SimpleCardGameConstants
    {
        public const string CardShuffled = "Card Shuffled";
        public const string InvalidMessage = "Invalid Input please enter again";
        public const string Restarting = "Restarting ...";
        public const string Restarted = "Restarted";
        public const string CardInDeck = "Card in Deck :";
        public const string CardLeft = "Card Left :";
        public const string CardPicked = "Card Picked :";
        public const string DrawCard = "----Play a card : Press 1";
        public const string MenuInfo = "Press key from options";
        public const string ShuffleCard = "----Shuffle the deck : Press 2";
        public const string RestartGame  ="----Restart the game : Press 3";
        public const string Exit = "----Exit : 4";
        public const string NoCard = "No card to play";
    }
}
