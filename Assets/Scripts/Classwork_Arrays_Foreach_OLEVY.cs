using System;
using Unity.Burst.Intrinsics;
using UnityEngine;

// L9 - Arrays & foreach (In-Class Classwork)
// Work through the TODOs in order. Attach this to an empty GameObject and press Play to test.
// Directions:
//   Section A - read the code and write your predicted answer, then test it.
//   Section B - write the code for each task.
//   Section C - solve each mini-interview problem (the approach is up to you).
public class Classwork_Arrays_Foreach_OLEVY : MonoBehaviour
{
    void Start()
    {
        // For Section A, use this array:
        int[] loot = { 5, 10, 15, 20 };

        // ============================================================
        // SECTION A: Trace & Predict (predict, then test)
        // ============================================================
        // A1. loot[0]
        // Answer: 5
        //
        // A2. loot[3]
        // Answer: 20
        //
        // A3. loot.Length
        // Answer: 4
        //
        // A4. loot[loot.Length - 1]
        // Answer: 20
        //
        // A5. loot[4]        (valid, or ERROR?)
        // Answer: ERROR
        //
        // A6. loot[-1]       (valid, or ERROR?)
        // Answer: ERROR
        //
        // A7. What does this print?
        //     foreach (int g in loot)
        //     {
        //         Debug.Log(g);
        //     }
        // Answer: 5, 10, 15, 20
        //
        // A8. What does this print?
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Debug.Log(loot[i]);
        //     }
        // Answer: 5, 10

        // ============================================================
        // SECTION B: Application (write the code)
        // ============================================================
        // B1. Declare three arrays (write the full lines):
        //     a) three room names as strings: "Hall", "Vault", "Cell"
        //     b) four potion counts as ints: 2, 4, 6, 8
        //     c) an empty array that holds 5 ints (all start at 0)
        //string[] names = { "Hall", "Vault", "Cell"}
        //int[] potCount = { 2, 4, 6, 8}
        //int[] emptyArray = {0, 0, 0, 0, 0}

        // B2. TOTAL LOOT: add up every value in the loot array above and print
        //     the total.
        //

        //int lootTotal = 0;
        //for (int i = 0; i < loot.Length; i++) 
        //{
        //    lootTotal += loot[i];
        //}
        //Debug.Log(lootTotal);

        // B3. INVENTORY LIST: given a string[] of items, print each item together
        //     with its index, like "0: torch".

        //string[] items = { "lamp oil", "rope", "bomb", "rubies" };
        //for (int i = 0; i < items.Length; i++)
        //{
        //    Debug.Log(i + ": " + items[i] );
        //}


        // B4. UPGRADE A SLOT: change the third item of an int[] to a new value,
        //     then print the whole array.

        //int[] numbers = { 1, 2, 3, 4, 5 };
        //
        //numbers[2] = 1000000;
        //
        //foreach (int count in numbers) 
        //{
        //    Debug.Log(count);
        //}

        // ============================================================
        // SECTION C: Mini-Interview (write the code)
        // ============================================================
        // C1. STRONGEST ENEMY: given int[] enemyHealth, find and print the
        //     largest value (don't use a built-in Max).
        //

        //int[] enemyHealth = { 5, 5, 1, 6, 9 };
        //int max = 0;
        //
        //foreach (int check in enemyHealth)
        //{
        //    if (check > max)
        //    {
        //        max = check;
        //    }
        //}
        //Debug.Log(max);

        // C2. COUNT THE POTIONS: given a string[] of items and a target word
        //     (say "potion"), print how many times the target appears.
        //

        //string[] vendorItems = {"potion", "potion", "arrow", "potion", "sword" };
        //int count = 0;
        //
        //foreach (string total in vendorItems) 
        //{
        //    if (total == "potion") 
        //    {
        //        count += 1;
        //    }
        //}
        //
        //Debug.Log(count);

        // C3. REVERSE ROLL CALL: given a string[] of party members, print the
        //     names from last to first.
        //

        //string[] party = { "Jake", "Jerry", "Jim", "John" };
        //string[] reversedParty = new string[party.Length];
        //for (int i = 0; i < party.Length; i++) 
        //{
        //    reversedParty[i] = party[party.Length - i - 1];    
        //}
        //
        //
        //Debug.Log("Reverse roll call is:");
        //foreach (string name in reversedParty)
        //{
        //    Debug.Log(name);
        //}

        // C4. SURVIVORS: given int[] enemyHealth, print how many enemies are
        //     still alive (health above 0).
        //

        //int[] enemyHealth = { 0, 0, 12, 30, 0, 40 };
        //int aliveCount = 0;
        //
        //foreach (int count in enemyHealth) 
        //{
        //    if(count > 0)
        //    {
        //        aliveCount += 1;
        //    }
        //}
        //Debug.Log(aliveCount);

        // C5. SORT THE LOOT: given an int[] of values in any order, rearrange
        //     them so they run from smallest to largest, then print them in order.
        //

        //int[] values = { 1, 9, 5, 3, 4};
        //
        //for (int i = 0; i < values.Length - 1; i++)
        //{
        //    for (int j = 0; j < values.Length - i - 1; j++)
        //    {
        //        if (values[j] > values[j + 1])
        //        {
        //            int sorter = values[j];
        //            values[j] = values[j + 1];
        //            values[j + 1] = sorter;
        //        }
        //    }
        //}
        //
        //Debug.Log(values[0] + " " + values[1] + " " + values[2] + " " + values[3] + " " + values[4]);

        // C6. FIND IN THE SORTED LOOT: using the now-sorted values from C5, look
        //     for a particular value and print whether it is in the list and, if
        //     so, at what index.
        //

        //int search = 3;
        //int index = 0;
        //foreach(int item in values)
        //{
        //    index++;
        //    if(item == search)
        //    {
        //        Debug.Log(index + ": " + item);
        //    }
        //}

        // C7. PALINDROME WORD: given a word (say "level"), print whether it reads
        //     the same forwards and backwards.
        
        //string palindrome = "level";
        //string reversePal = string.Empty;
        //
        //for (int i = palindrome.Length - 1; i >= 0 ; i--)
        //{
        //    reversePal += palindrome[i];
        //}
        //
        //Debug.Log(reversePal);
        //
        //if (palindrome == reversePal)
        //{
        //    Debug.Log(palindrome + " is a palindrome");
        //
        //}
        //else
        //{
        //    Debug.Log(palindrome + " is not a palindrome");
        //}

    }
}
