using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielCairney
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class DanielsLevellingSystem : MonoBehaviour
    {
        // TODO XP 1/13 Declare a new variable to track the current amount of XP we have accumulated (our current XP).
        private float currentExperience;
        // TODO XP 2/13 Declare a new variable to track our current Level.
        private float currentLevel;
        // TODO XP 3/13 Declare a new variable to track the amount of XP required to level-up (our current Level Up Threshold).
        private float levelUpThreshold;

        private void Start()
        {
            // TODO XP 4/13: Set our current level to one.
            currentLevel = 1;
            // TODO XP 5/13: Set our current XP to zero.
            currentExperience = 0;
            // TODO XP 6/13: Set our current XP Threshold to be our level multiplied by our 100.
            levelUpThreshold = currentLevel * 100;
            // TODO XP 7/13: Debug out our starting values of our level, XP and current XP threshold.
            Debug.Log("Current Level " + currentLevel);
            Debug.Log("Current Experience " + currentExperience);
            Debug.Log("Level Up Threshold" + levelUpThreshold);
            // TODO XP 8/13: Increase the current XP by a random amount between 50 and 100.
            currentExperience += Random.Range(50 , 100);
            // TODO XP 9/13: Debug out our current XP.
            Debug.Log("Current XP " + currentExperience);
            // TODO XP 10/13: Check if our current XP is more than our threshold.
            if (currentExperience > levelUpThreshold) {
                currentLevel += 1;
                levelUpThreshold = currentLevel * 100;
                Debug.Log("Current Level " + currentLevel);
                Debug.Log("Current Experience " + currentExperience);
                Debug.Log("Level Up Threshold" + levelUpThreshold);
            }
            // TODO XP 11/13: If it is, then let's increase out level by one.
            // I did this on line 36 and 37 since its easier to read when its together
            // TODO XP 12/13: Let's also increase recalculate our current XP threshold as we've levelled up.
            // same here i did everything in the if statement in line 36
            // TODO XP 13/13: Debug out our new level value, as well as our current XP and the next threshold we need to hit.
            // and again again line 36
            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.
            /// my code is showing a leveling system in the games console. it starts with me making variables on the current xp, xp threshold and current level. then i set the data value on the 
            ///variables, then the debug.logs show the player in the console their current xp, level and xp threshold in the console. from line 32 it gives the character a random number of xp from 50, 100.
            ///it will show the random number of xp in the log on from line 34. from the if statement in line 36 it will calculate if the xp goes over the threshold it will put the level up 
            ///by 1 and display it in the console as well as display the new current xp and threshold again.
            ///
            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
