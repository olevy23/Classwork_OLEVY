using UnityEngine;

// Variables, Data Types & Operators
// Attach this to an empty GameObject and press Play. Work through the TODOs.
public class Classwork_VariablesDataTypesOperators_OLEVY : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Declare a variable of the RIGHT type (write the full line):
        // TODO   1. arrows: 12
        int arrows = 12;
        // TODO   2. player's name: Kael
        string playerName = "Kael";
        // TODO   3. gate is open: true
        bool gateOpen = true;
        // TODO   4. a single grade letter: B
        char grade = 'B';
        // TODO   5. move speed: 4.5
        float moveSpeed = 4.5f;
        // TODO   6. a precise price: 19.99
        float price = 19.99f;

        // TODO A2. Name the TYPE (int / float / double / char / bool / string):

        // TODO   7. number of potions
        int potionCount;
        // TODO   8. character name
        string characterName;
        // TODO   9. is the door locked
        bool doorLocked;
        // TODO   10. one keyboard key as a letter
        char keyboardKey;

        // TODO A3. Compute the result (write the value as a comment):
        // TODO   11. 8 + 5        13. 20 % 6        15. 2 + 3 * 4
        // TODO   12. 15 / 4       14. 10 % 2        16. (2 + 3) * 4
        // 11: 13 || 12: 3 || 13: 2 || 14: 0 || 15: 14 || 16: 20 ||
        // TODO A4. Rewrite each with a COMPOUND operator:
        // TODO   17. score = score += 100;
        // TODO   18. health = health -= 20;
        // TODO   19. speed = speed *= 2;
        // TODO   20. lives = lives --1;   (also show the -- form)

        // TODO A5. PREDICT the final value (write it as a comment):
        // TODO   21.   int x = 10;
        //              x += 5;
        //              x -= 3;
        //              result: 12
        // TODO   22.   int h = 100;
        //              h -= 30;
        //              h += 2 * 20;
        //              result: 110
        // TODO 23. Declare four stats for a MONSTER (name, health, attack,
        //          alive) with proper types, then print them on one line.
        string monsterName = "slime";
        int monsterHP = 20;
        int monsterATK = 2;
        bool monsterAlive = true;
        string monsterStatus;
            if (monsterAlive == true)
            {
                monsterStatus = "alive";
            }
            else
            {
                monsterStatus = "dead";
            }
        Debug.Log("You see a " + monsterName + ". It has " + monsterHP + " Health and " + monsterATK + " Attack. It is " + monsterStatus + ".");
        // TODO 24. int health = 100; apply a 25 hit, a 40 heal, a 60 hit with
        //          compound operators, printing health after each. What three
        //          numbers appear?
        int health = 100;
        health -= 25; // 75
        health += 40; // 115
        health -= 60; // 55

        // TODO 25. Fix each broken line, then write the corrected version:
        //            int speed = 5.5;
        //            string name = Aria;
        //            int g = "20";
        float speed = 5.5f;
        string name = "Aria";
        int g = 20;

        // TODO 26. SWAP: int a = 3; int b = 8; write code that swaps them so
        //          a becomes 2 and b becomes 1. Try this first with an extra
        //          variable, then do it without any other variables.
        int a = 3;
        int b = 8;

        int c = a;
        a = b;
        b = c;

        a = 3;
        b = 8;

        a = a * b; // a=24, b=8
        b = a / b; // a=24, b=3
        a = a / b; // a=8 b =3

        // TODO 27. SECONDS TO CLOCK: given int totalSeconds, print hours, 
        //          minutes and seconds: e.g. if totalSeconds is set to:
        //              125, output is "2m 5s"
        //              3600, output is "1h"
        //              10000, output is "2h 46m 40s"
        int totalSeconds = 3082;
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = (totalSeconds % 3600) % 60;
        Debug.Log(hours + "h " + minutes + "m " + seconds + "s");
        // TODO 28. EVERY THIRD HIT: a sword deals 10 damage, but every 3rd hit
        //          deals double. Using %, print the damage of hits 1 to 6.
        int swordDamage = 10;
        int swordHit = 0;
        while (swordHit < 6) 
        {
            swordHit += 1;
            if (swordHit % 3 == 0)
            {
                Debug.Log("Attack number " + swordHit + " deals " + (swordDamage * 2) + "damage.");
            }
            else
            {
                Debug.Log("Attack number " + swordHit + " deals " + swordDamage + "damage.");
            }
        }
    }
}
