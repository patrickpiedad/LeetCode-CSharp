// namespace LeetCode_CSharp;
//
// public class Blackjack
// {
//     // Calculate score of a blackjack hand
//     // J & K ==> 20points
//     // 21 highest score
//     // over 21 => score of 0points
//     // 1-10 is normal points, J/Q/K are 10 points, A is 11 or 1 points
//
//
//     private CalculateScoreHelper(List<Cards> cards, int currentScore, int index)
//     {
//         if (index >= cards.Size)
//         {
//             return currentScore;
//         }
//
//         int result = currentScore;
//
//
//         foreach (var score in cards[index])
//         {
//             int currentResult = CalculateScoreHelper(cards, currentScore + score, index + 1);
//             if (currentResult > 21)
//             {
//                 currentResult = 0;
//             }
//
//             result = Max(currentResult, result);
//         }
//
//         return result;
//     }
//
//     public int CalculateScore(List<Card> cards)
//     {
//         //error checking to check
//         if (cards == null)
//         {
//             return 0;
//         }
//
//         return CalculateScoreHelper(cards, 0, 0);
//     }
//
//
//     public class Card
//     {
//         private int cardValue;
//
//         public List<int> GetValues()
//         {
//             // if number then return number
//             // if A, then return 1 and 11 based on score
//             return [];
//         }
//     }