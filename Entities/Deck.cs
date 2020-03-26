using CardGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CardGame
{

    /// <summary>
    /// Deck to represent the deck of card
    /// </summary>
    public class Deck : IDeck
    {
        private  Queue<Card> _cards;

        public Deck()
        {
            Initalize();
        }

        #region Private Methods
        /// <summary>
        /// Intialize the deck with cards;
        /// </summary>
        public void Initalize()
        {
            try
            {
                _cards = new Queue<Card>();
                for (int i = CardConstants.MinCardValue; i <= CardConstants.MaxCardValue; i++)
                {
                    foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                    {
                        _cards.Enqueue(new Card()
                        {
                            Suit = suit,
                            Value = GetValue(i),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                //Log error somehwere                
               Console.WriteLine($"Error while initializing card {ex.Message}") ;
            }
            
        }
        /// <summary>
        /// Get the value to be displayed in card
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetValue(int value)
        {
            try
            {
                string valueDisplay = string.Empty;
                if (value >= 2 && value <= 10)
                {
                    valueDisplay = value.ToString();
                }
                else if (value == 11)
                {
                    valueDisplay = CardConstants.Jack;
                }
                else if (value == 12)
                {
                    valueDisplay = CardConstants.Queen;
                }
                else if (value == 13)
                {
                    valueDisplay = CardConstants.King;
                }
                else if (value == 1)
                {
                    valueDisplay = CardConstants.Ace;
                }

                return valueDisplay;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        #endregion End

        #region Public Method
        /// <summary>
        /// Method to suffle the deck
        /// </summary>
        public virtual void Shuffle()
        {
            List<Card> cards = _cards.ToList();
            Random random = new Random();
            try
            {
                for (int pos = cards.Count()-1  ; pos > 0; pos--)
                {
                    //Generate a random number
                    int randomNumber = random.Next(pos);

                    //Card to suffle with
                    Card currentCard = cards[pos];
                    cards[pos] = cards[randomNumber];
                    cards[randomNumber] = currentCard;
                }

                Queue<Card> shuffledCards = new Queue<Card>();
                foreach (var card in cards)
                {
                    shuffledCards.Enqueue(card);
                }
                _cards = shuffledCards;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Draw the top card
        /// </summary>
        /// <returns></returns>

        public Card DrawCard()
        {
            try
            {
                return _cards.Dequeue();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Reset the card deck
        /// </summary>
        public void ResetDeck()
        {
            //Re Initialize the decl
            Initalize();
        }

        public int TotalCard()
        {
            try
            {
                return _cards.Count();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        #endregion

    }
}
