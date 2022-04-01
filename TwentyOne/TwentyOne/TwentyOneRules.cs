﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        
        public static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // Count the aces in hand
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // Initialize an array of results
            int[] result = new int[aceCount + 1];
            // Add the values in hand together
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            // If no ace found, return result
            if (result.Length == 1) return result;

            // If one ace is found, value changes from 1 to 11
            for(int i = 1; i < result.Length; ++i)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool isBusted(List<Card> Hand)
        {
            int values = GetAllPossibleHandValues(Hand).Min();
            if (values > 21) return true;
            else return false;
        }
        public static bool shouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);

            foreach(int value in possibleHandValues)
            {
                if(value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
