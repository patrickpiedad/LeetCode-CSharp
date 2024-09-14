namespace LeetCode_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] scores = [1, 3, 5, 10, 15];
            int[] ages = [1, 2, 3, 4, 5];



        }

        //public static int BestTeamScore(int[] scores, int[] ages)
        //{
        // I will get two arrays, scores and ages, where the ith index of each array represents the score and age of the ith player
        // I need to create a team with the highest overall score
        // Constraint => No conflicts can exist where a younger player has a strictly higher score than an older player
        // In other words, younger players must have an equal or lower score than older players

        // Will the arrays ever be empty? => No
        // Will the ages or scores values ever be negative, zero, or null? => No

        // Scores [1 3 5 10 15] / Ages [1 2 3 4 5]
        // Player 0 has Score 1 and Age 1
        // Player 1 has Score 3 and Age 2
        // Player 2 has Score 5 and Age 3
        // Player 3 has Score 10 and Age 4
        // Player 4 has Score 15 and Age 5

        // For loop to iterate through arrays, since a single for loop with i can be used to move through both arrays
        // Comparison to check the current oldest player age and score against iterating player age and score
        // Create currentOldestAge and currentOldestScore variables
        // Create maxScore variable
        // Set current to first element in the loop i = 0 and maxScore equal to first element in scores array
        // if (ages[i] < currentOldestAge && scores[i] > currentOldestScore && maxScore + ), then maxScore = maxScore - currentOldestScore + scores[i]
        // update currentOldestAge = ages[i] and currentOldestScore = scores[i]
        // else, meaning ages are the same or ages are different, then maxScore = maxScore + scores[i]



        //}
    }
}