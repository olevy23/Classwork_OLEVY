using UnityEngine;
// Methods II
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
// (For "write a method" tasks, add the method to THIS class, below Start.)
public class Classwork_Methods_II : MonoBehaviour
{
    int coins = 0;
    void Start()
    {

        // A1. Local variable or FIELD? (depends on WHERE it is declared)
        //     1. int health = 100;  declared at the top of the class
        //     Answer: Field
        //     2. int blow = 5;      declared inside a method
        //     Answer: Local
        //     3. a method's parameter
        //     Answer: Local
        //     4. a variable declared inside a for loop
        //     Answer: Local

        // A2. Can this code SEE the variable? (yes / no)
        //     5. void A() { int x = 1; }   ... can B() read x?
        //     Answer: no
        //     6. a FIELD named gold        ... can every method read gold?
        //     Answer: yes
        //     7. int y declared inside an if block ... can you use y after the if?
        //     Answer: no

        // A3. Overload or NOT? (can these two methods coexist? yes / no)
        //     8.  void Go()           and  void Go(int n)
        //     Answer: yes
        //     9.  int Add(int a)      and  int Add(int b)      (same parameter list)
        //     Answer: no
        //     10. void Log(string s)  and  void Log(int n)
        //     Answer: yes

        // A4. What does each call do?  (given:  void Heal(int amount = 10) )
        //     11. Heal();
        //     Answer: heals by 10
        //     12. Heal(25);
        //     Answer: heals by 25

        // A5. PASS-BY-VALUE - predict what prints:
        //     13. void Bump(int n)
        //         {
        //             n = n + 1;
        //         }
        //         int score = 5;
        //         Bump(score);
        //         Debug.Log(score);
        //     Answer: prints 6

        // A6. Fix the bug, then write the corrected version:
        //     14. void Mix(int a = 1, int b)        // optional before required
        void Mix(int b, int a = 1) { }
        //     15. void Dash() and void Dash()       // these two can't coexist - why?
        //void Dash() { }
        //void Dash(int distance) { } //multiples of the same method need to have different parameters to coexist
        //     16. Jump(2);                          // but only  void Jump()  exists
        void Jump(int height) { }

        // A7. Write these methods (add them below Start):
        //     17. Two overloads of Greet: Greet() prints "Hello, traveler!", and
        //         Greet(string name) prints "Hello, <name>!".
        Greet();
        Greet("Player");
        //     18. void AddCoins(int amount = 5) so callers can add 5 by default or
        //         pass their own amount. Keep a running total in a FIELD.
        AddCoins();
        AddCoins(150);
        AddCoins();
        //     19. int Power(int baseNum, int times = 2) that multiplies baseNum by
        //         itself 'times' times (so by default it squares the number).
        Power(2);
        Power(2, 5);

        //     20. Two overloads of Area: Area(int side) for a square and
        //         Area(int width, int height) for a rectangle.
        Area(5);
        Area(5, 7);
        // A8. SCOPE TRACE - answer in a comment:
        //     21. A FIELD at the top of the class:  int total = 0;
        //         and inside a method:              void Reset() { int total = 100; }
        //         After calling Reset(), what is the class's total? Why?
        //     Answer: total is going to equal 0, as the field and local variables having the same name means that the method will only affect the local variable's value rather than both versions of "total"
    }
    void Greet() 
    { 
        Debug.Log("Hello, traveler!"); 
    }
    void Greet(string name) 
    {
        Debug.Log("Hello, " + name + "!");
    }
    void AddCoins(int amount = 5)
    {
        coins += amount;
        Debug.Log(coins);
    }
    void Power(int baseNum, int times = 2)
    {
        int total = baseNum;
        for(int i = 0; i < times-1; i++)
        {
            total *= baseNum;
        }
        Debug.Log(total);
    }
    void Area(int side)
    {
        int area = (side * side);
        Debug.Log(area);
    }
    void Area(int width, int height)
    {
        int area = (width * height);
        Debug.Log(area);
    }

    // Write your methods for tasks 17-20 here.
}
