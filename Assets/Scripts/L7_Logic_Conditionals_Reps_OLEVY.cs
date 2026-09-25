using UnityEngine;

// L7 - Comparison, Logic & Conditionals (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class L7_Logic_Conditionals_Reps_OLEVY : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: True or False (answer in a comment)
        // ============================================================
        // 1. 5 == 5
        // Answer: true
        // 2. 5 != 5
        // Answer: false
        // 3. 7 > 3
        // Answer: true
        // 4. 7 < 3
        // Answer: false
        // 5. 4 >= 4
        // Answer: true
        // 6. 6 <= 2
        // Answer: false

        // ============================================================
        // A2: Evaluate the Logic (write the result)
        // ============================================================
        // 7. true && false
        // Answer: false
        // 8. false || true
        // Answer: true
        // 9. !true
        // Answer: false
        // 10. (2 > 1) && (3 > 2)
        // Answer: true

        // These values are shared by A3, A5 and A6 below.
        int health = 20;
        int gold = 100;
        bool hasKey = true;

        // ============================================================
        // A3: Scenario - True or False (health = 20, gold = 100, hasKey = true)
        // ============================================================
        // 11. health < 30
        // Answer: true
        // 12. hasKey && health > 50
        // Answer: false
        // 13. !hasKey
        // Answer: false
        // 14. gold >= 100 || hasKey
        // Answer: true

        // ============================================================
        // A4: Predict What Prints (write your prediction, then test)
        // ============================================================
        // 15.
        //     int h = 0;
        //     if (h <= 0)
        //     {
        //         Debug.Log("dead");
        //     }
        //     else
        //     {
        //         Debug.Log("alive");
        //     }
        // Answer: dead
        //
        // 16.
        //     int s = 75;
        //     if (s >= 90)
        //     {
        //         Debug.Log("A");
        //     }
        //     else if (s >= 70)
        //     {
        //         Debug.Log("C");
        //     }
        //     else
        //     {
        //         Debug.Log("F");
        //     }
        // Answer: C

        // ============================================================
        // A5: Fix the Bug (write the corrected code)
        // ============================================================
        // 17. This should print "dead" when health is 0, but it has a bug:
        //     if (health = 0)
        //     {
        //         Debug.Log("dead");
        //     }
        if (health == 0)
        {
            Debug.Log("dead");
        }
        //
        // 18. Both calls are meant to run only when hasKey is true,
        //     but right now only the first one is:
        //     if (hasKey)
        //         Open();
        //         Enter();
        
        //if (hasKey)
        //{
        //    Open();
        //    Enter();
        //}
        // added curly brackets to if function

        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 19. Make ONE boolean called canOpenVault that is true only when
        //     hasKey is true AND health is greater than 0.
        bool canOpenVault = (hasKey && (health > 0));
        // 20. Using the health above, write an if / else-if / else that prints
        //     "Dead" when health <= 0, "Low" when health < 30, otherwise "Fine".
        if(health<= 0)
        {
            Debug.Log("Dead");
        }
        else if (health < 30)
        {
            Debug.Log("Low");
        }
        else
        {
            Debug.Log("Fine");
        }
        // 21. Apply a trap (health -= 50), then clamp health so it never goes
        //     below 0.
        health -= 50;
       
        if (health <= 0)
        {
            health = 0;
        }
        // 22. LETTER GRADE: given int score (for example 75), print A, B, C, D
        //     or F using the 90 / 80 / 70 / 60 cutoffs.
        int score = 75;
        if (score >= 90)
        {
            Debug.Log("A");
        }
        else if (score >= 80)
        {
            Debug.Log("B");
        }
        else if (score >= 70)
        {
            Debug.Log("C");
        }
        else if (score >= 60)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
        // 23. LEAP YEAR: given int year, print whether it is a leap year.
        //     A year is a leap year when it is divisible by 4, except that
        //     century years must also be divisible by 400.
        int year = 1900;
        if((year % 100) == 0)
        {
            Debug.Log("just a normal year");
        }
        else if((year % 400) == 0)
        {
            Debug.Log("century year!");
        }
        else if((year % 4) == 0)
        {
            Debug.Log("leap year!");
        }
        else
        {
            Debug.Log("just a normal year");
        }

        // 24. FIZZBUZZ (one number): given int n, print "Fizz" if it is
        //     divisible by 3, print "Buzz" if it is divisible by 5, print
        //     "FizzBuzz" if it is divisible by both 3 and 5, otherwise print
        //     the number itself.
        int number = 16;
        string Fizz = "";
        string Buzz = "";
        string numNoFizzBuzz = "";
        if (number % 3 == 0 && number % 5 == 0)
        {
            Fizz = "Fizz";
            Buzz = "Buzz";
        }
        else if (number % 3 == 0)
        {
            Fizz = "Fizz";
        }
        else if (number % 5 == 0)
        {
            Buzz = "Buzz";
        }
        else 
        {
            numNoFizzBuzz = "16"; //Wanted to set string to mirror the number for this section, but compiler error so using just the same number value as a testing measure
        }
        Debug.Log(Fizz + Buzz + numNoFizzBuzz);
    }
}