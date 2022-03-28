# Dealing-Cards-Program-Assignment- 
//This program was part the coursera course Introduction C# programming unity Assignment (U of Colorado). 
Code for Dealing cards to 3 players

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome Peers!!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            //deck.Print();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            deck.TakeTopCard();

            // 1st Round of Dealing
            Card card11 = deck.TakeTopCard();
            Card card12 = deck.TakeTopCard();
            Card card13 = deck.TakeTopCard();

            // 2nd Round of Dealing
            Card card21 = deck.TakeTopCard();
            Card card22 = deck.TakeTopCard();
            Card card23 = deck.TakeTopCard();
            


            // flip all the cards over
            card11.FlipOver();
            card12.FlipOver();
            card13.FlipOver();
            card21.FlipOver();
            card22.FlipOver();
            card23.FlipOver();

            // print the cards for player 1
            Console.WriteLine();
            Console.WriteLine("The Cards for player 1:");
            Console.WriteLine();
            Console.WriteLine(card11.Rank + " of " + card11.Suit);
            Console.WriteLine(card21.Rank + " of " + card21.Suit);

            // print the cards for player 2
            Console.WriteLine();
            Console.WriteLine("The Cards for player 2:");
            Console.WriteLine();
            Console.WriteLine(card12.Rank + " of " + card12.Suit);
            Console.WriteLine(card22.Rank + " of " + card22.Suit);

            // print the cards for player 3
            Console.WriteLine();
            Console.WriteLine("The Cards for player 3:");
            Console.WriteLine();
            Console.WriteLine(card13.Rank + " of " + card13.Suit);
            Console.WriteLine(card23.Rank + " of " + card23.Suit);
            Console.WriteLine();
        }
    }
}
