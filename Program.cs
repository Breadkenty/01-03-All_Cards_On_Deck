using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_All_Cards_On_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            // make n = 52 since we are dealing with 52 elements

            // for firstIndex from n - 1 down to 1 do:
            // secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex

            // Now swap the values at firstIndex and secondIndex by doing this:
            // firstValue = the value from items[firstIndex]
            // secondValue = the value from items[secondIndex]
            // items[firstIndex] = secondValue
            // items[secondIndex] = firstValue

            // Priming the code, prepares 'card' to be inserted into 'allCards' as an array of strings.
            string card;
            var randomNumber = new Random();

            // Creates the list of combinations to later combine in the function to follow.
            var suitList = new List<string>() { "Clubs", "Spades", "Queens", "Diamonds" };
            var rankList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Empty string to add the combined set of cards that will be used when shuffling.
            var allCards = new List<string>() { };
            var playerOneHand = new List<string> { };
            var playerTwoHand = new List<string> { };

            // // Combines suits and ranks and all of its combinations. It also adds the combination to the allCards list.
            foreach (var selectedRank in rankList)
            {
                foreach (var selectedSuit in suitList)
                {
                    card = $"{selectedRank} of {selectedSuit}";
                    allCards.Add(card);
                }
            }

            // Shuffles the cards.
            for (var firstIndex = allCards.Count - 1; firstIndex >= 0; firstIndex--)
            {
                // Assigning a random number that is between 0 and firstIndex
                int secondIndex = randomNumber.Next(0, firstIndex);

                // Swaps the firstIndex of the deck with the secondIndex.
                var swapCards = allCards[firstIndex];
                allCards[firstIndex] = allCards[secondIndex];
                allCards[secondIndex] = swapCards;
            }

            var cardsLeft = allCards.Count;

            // Writes the cards you pulled into the console.
            playerOneHand.Add(allCards[0]);
            playerOneHand.Add(allCards[1]);
            playerTwoHand.Add(allCards[2]);
            playerTwoHand.Add(allCards[3]);
            allCards.Remove(allCards[0]);
            allCards.Remove(allCards[1]);
            allCards.Remove(allCards[2]);
            allCards.Remove(allCards[3]);

            Console.WriteLine($"\n\n\nYour hand = {playerOneHand[0]} and {playerOneHand[1]}\n");
            Console.WriteLine($"Their hand = {playerTwoHand[0]} and {playerTwoHand[1]}\n");

            Console.WriteLine($"There are {allCards.Count} cards left in the deck");
        }
    }
}