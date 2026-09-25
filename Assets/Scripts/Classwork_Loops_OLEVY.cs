using UnityEngine;

// L8 - Loops (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class Classwork_Loops_OLEVY : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: How Many Times Does the Body Run? (predict, then test)
        // ============================================================
        // 1.
        //     int i = 0;
        //     while (i < 5)
        //     {
        //         i++;
        //     }
        // Answer: Five times
        //
        // 2.
        //     int i = 0;
        //     while (i < 0)
        //     {
        //         i++;
        //     }
        // Answer: Will not run
        //
        // 3.
        //  int i = 0;
        //  do
        //  {
        //      i++;
        //  }
        //  while (i < 3);
        // Answer: Three times
        //
        // 4.
        //     for (int i = 0; i < 4; i++)
        //     {
        //     }
        // Answer: Four times
        //
        // 5.
        //     for (int i = 1; i <= 3; i++)
        //     {
        //     }
        // Answer: Three times

        // ============================================================
        // A2: Trace the Final Value
        // ============================================================
        // 6. What is n at the end?
        //     int n = 1;
        //     while (n < 100)
        //     {
        //         n *= 2;
        //     }
        // Answer: 128
        //
        // 7. What is s at the end?
        //     int s = 0;
        //     for (int i = 1; i <= 4; i++)
        //     {
        //         s += i;
        //     }
        // Answer: 4

        // ============================================================
        // A3: while, do-while, or for? (answer in a comment)
        // ============================================================
        // 8. Repeat a known number of times.
        // Answer: for
        // 9. Ask for a password; they must try at least once.
        // Answer: do-while
        // 10. Keep attacking while the enemy has health.
        // Answer: while

        // ============================================================
        // A4: break or continue? (answer in a comment)
        // ============================================================
        // 11. Stop searching once you find the item.
        // Answer: break
        // 12. Skip enemies that are already dead, keep checking the rest.
        // Answer: continue

        // ============================================================
        // A5: Spot the Bug (then write the fix)
        // ============================================================
        // 13. This is meant to print 0 through 4, but it has two problems:
        //     for (int i = 0; i < 5; i++); missing {
        //     Debug.Log(i);
        //                                  missing }
        // 14. This is meant to print 0 through 4, but something is missing:
        //     int i = 0;
        //     while (i < 5)
        //     {
        //         Debug.Log(i);            missing incrementation, will return 0 continuously
        //     }

        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 15. Use a for loop to print the numbers 1 through 10.
        
        //for (int i = 1; i <= 10; i++)
        //{
        //    Debug.Log(i);
        //}
        
        // 16. Use a while loop to add up 1 through 100 and print the total.
        
        //int j = 0;
        //while (j < 100)
        //{
        //    j += 1;
        //    Debug.Log(j);
        //}
        
        // 17. Loop 1 through 10, but use continue to skip 5 and break at 8.
        //     Which numbers print?
        
        //for(int k = 1; k < 11; k++)
        //{
        //    if(k == 5)
        //    {
        //        continue;
        //    }
        //    if(k == 8)
        //    {
        //        break;
        //    }
        //    Debug.Log(k);
        //}

        // 18. FIZZBUZZ (1 to 20): print the numbers 1 through 20, but print
        //     "Fizz" if the number is divisible by 3, print "Buzz" if it is
        //     divisible by 5, and print "FizzBuzz" if it is divisible by both
        //     3 and 5.
        
        //int l = 1;
        //while (l <= 20)
        //{
        //    Debug.Log(l);
        //    if((l % 3 == 0) && (l % 5 == 0))
        //    {
        //        Debug.Log("FizzBuzz");
        //    }
        //    else if(l % 3 == 0)
        //    {
        //        Debug.Log("Fizz");
        //    }
        //    else if(l % 5 == 0)
        //    {
        //        Debug.Log("Buzz");
        //    }
        //    l += 1;
        //}
       
        // 19. IS PRIME: given int n (greater than 1), print whether it is
        //     prime. Loop from 2 to n - 1; if any value divides n evenly it is
        //     not prime; use break to stop early.
       
        //int n = 13;
        //for(int m = 2; m <= (n - 1); m++)
        //{
        //
        //    if (n % m == 0)
        //    {
        //        Debug.Log(n + " is not prime!");
        //        break;
        //    }
        //    else if(m == (n - 1))
        //    {
        //        Debug.Log(n + " is prime!");
        //        break;
        //    }
        //    Debug.Log(n + " is so far prime");
        //}
        
        // 20. COUNTDOWN: use a for loop to print a countdown from 5 down to 1,
        //     then print "Go!".
        
        //for(int o = 5; o > 0; o--)
        //{
        //    Debug.Log(o);
        //    if(o == 1)
        //    {
        //        Debug.Log("Go!");
        //    }
        //}

    }
}
