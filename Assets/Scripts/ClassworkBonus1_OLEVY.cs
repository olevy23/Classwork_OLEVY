using UnityEngine;

public class ClassworkBonus1_OLEVY : MonoBehaviour
{
    void Start()
    {
        /* 
         * Requirements:
         * Use arithmetic operators to solve the following problems
         * Do not use conditionals, comparisons, if, else, loops, arrays, 
         * or other techniques and topics we have not covered in class. 
         */

        /*
         * Problem 1: Distributing Potions
         *
         * A party has a supply of potions that must be distributed
         * equally among the party members.
         *
         * Test values:
         * potionCount = 23
         * partyMembers = 5
         *
         * Calculate:
         * - How many potions each member receives.
         
         * - How many potions remain.
         * - How many additional potions are needed so everyone
         *   could receive one more potion.
         * 
         * Confirm your solution by testing with other values for 
         * potionCounts and partyMembers.
         */


        // Write your solution here.
        int potionCount = 25;
        int partyMembers = 5;
        int potionDistribution = potionCount / partyMembers;
        int potionRemainder = potionCount % partyMembers;
        int potionEqualizer = partyMembers - potionRemainder;
        Debug.Log("Each party member receives " + potionDistribution + " potion(s). " + potionRemainder + " potion(s) remain.");
        if (potionEqualizer != partyMembers)
        {
            Debug.Log("For everyone to get an equal amount of potions with no remainder, you will need " + potionEqualizer + " more potion(s).");
        }
            /*
         * Problem 2: Packing Items into Crates
         *
         * A supply ship can hold a maximum number of items in each crate.
         * Determine how many crates are required to hold all the items.
         *
         * Test values:
         * itemCount = 25
         * itemsPerCrate = 6
         *
         * Your solution must work for any positive itemCount and any 
         * positive itemsPerCrate. 
         * 
         * Remember, integer division will round down, and every item
         * must be in a crate. There can't be any left over. 
         *
         * Do not use if statements.
         */

        int itemCount = 25;
        int itemsPerCrate = 6;

        // Write your solution here.

        int crateCount = (itemCount / itemsPerCrate) + 1;

        /*
         * Problem 3: Making Change with Coins
         *
         * A shopkeeper needs to convert a total number of cents into
         * the fewest possible quarters, dimes, nickels, and pennies.
         *
         * Test value:
         * totalCents = 87
         *
         * Calculate:
         * - Number of quarters.
         * - Number of dimes.
         * - Number of nickels.
         * - Number of pennies.
         *
         * Use integers and arithmetic operators.
         */

        int totalCents = 87;

        // Write your solution here.
        int q = 25;
        int di = 10;
        int n = 5;
        int p = 1;

        int quarters = totalCents / q;
        totalCents -= quarters * q;
        int dimes = totalCents / di;
        totalCents -= dimes * di;
        int nickels = totalCents / n;
        totalCents -= nickels / n;
        int pennies = totalCents / p;
        totalCents -= pennies / p;
        Debug.Log("Your change is " + quarters + " quarters, " + dimes + " dimes, " + nickels + " nickels, and " + pennies + " pennies.");

        /*
         * Problem 4: Converting a Capital Letter to Lowercase
         *
         * Convert a capital letter into its lowercase equivalent
         * without using ToLower() or ToUpper().
         *
         * Test value:
         * char letter = 'G';
         *
         * Use arithmetic and casting to calculate the lowercase letter.
         *
         * Before writing the final solution, investigate what happens
         * when you run expressions such as:
         *
         * Debug.Log((char)('A' + 1));  // Also try other numbers
         * Debug.Log('B' - 'A');        // Also try other letters
         * Debug.Log((int)'A');         // Also try other letters
         * Debug.Log((int)'a');         // Also try other letters
         *
         * Your solution should work for other capital letters as well.
         */

        char letter = 'G';

        Debug.Log((char)('A' + 32));  // Also try other numbers
        Debug.Log('z' - 'a');        // Also try other letters
        Debug.Log((int)'G');         // Also try other letters
        Debug.Log((int)'g');         // Also try other letters

        // Write your solution here.

        Debug.Log((char)('G' + 32));

        /*
         * Problem 5: Reversing a Four-Digit Number
         *
         * A dungeon lock displays a four-digit access code.
         * The mechanism has reversed the digits, and you need to
         * calculate the original number in reverse order.
         *
         * Test value:
         * int code = 4827;
         *
         * The digits should be extracted and rearranged so that
         * the resulting number contains the digits in reverse order.
         *
         * For example:
         *
         * Original code: 4827
         * Reversed code: 7284
         *
         * Use arithmetic operators to extract the digits
         * Construct the reversed number using the extracted digits.
         * 
         * Do not convert the number to a string.
         * Do not use loops or arrays.
         *
         * Test your solution with other four-digit integers.
         */

        int code = 4827;
        // Write your solution here.

        int a = code / 1000;
        int b = (code - (a * 1000)) / 100;
        int c = (code - (a * 1000) - (b * 100)) / 10;
        int d = code - (a * 1000) - (b * 100) - (c * 10);
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(d);
        int edoc = (d * 1000) + (c * 100) + (b * 10) + a;
        Debug.Log(edoc);
        
    }
}