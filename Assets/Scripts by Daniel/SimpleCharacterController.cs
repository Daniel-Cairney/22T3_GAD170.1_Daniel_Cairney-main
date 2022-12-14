using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielCairney
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.
        [SerializeField] private SpriteRenderer spriteRenderer; // Our character's sprite.

        // TODO Movement 1/8: Declare a variable for a reference to our 2D rigidbody, for physics stuff.
        [SerializeField] private Rigidbody2D rbody2D;
        // TODO Movement 2/8: Declare a variable for the speed we can run at in Unity-units-per-second.
        private float runSpeed = 3f; 
        // TODO Movement 3/8: Declare a variable for the strength of our jump.
        private float jumpStrength = 5f;
        private void Start() {
            rbody2D = GetComponent<Rigidbody2D>();

        }

        private void Update()
        {
            // TODO Movement 4/8: Store our horizontal player input value so we can access it later on.
            horizontalInputValue = Input.GetAxisRaw("Horizontal");
            // TODO Movement 5/8: Transform our character's position on the X axis. (Reference our stored horizontal input value here!)
            transform.position += new Vector3(horizontalInputValue, 0, 0) * Time.deltaTime * runSpeed;
            // TODO Movement 6/8: Check if the player presses the "Jump" button (by default, the space bar on the keyboard).
            if (Input.GetButtonDown("Jump")){
                rbody2D.velocity = new Vector3(rbody2D.velocity.x, jumpStrength);
            }
               
            // TODO Movement 7/8: If they do, then add vertical velocity to our rigidbody to make our character "jump"!
            //all of the last steps are in line 28 to 35
            // TODO Movement 8/8: Add this script to a game object and make a new prefab from it, and explore the level!

            // TODO Movement Final: Add code comments describing what you hope your code is doing throughout this script.
            /// my code is giving the character Alen player input movement. it starts with me declaring variables and data for jumpstrength and runspeed and a ridigbody for physics. 
            /// at line 29 and forth it can detect player input and make the character go left and right the the A and D. it can also read a players input to make Alan jump, in the if statement
            /// it detecs the input and when it detects it it makes Alan go up by the amount of data was stored before in the variable. 
            // TODO Movement Bonus 1: Ensure that our character can only jump if they are "grounded". (Hint: You can use a boolean as a part of this!)

            // TODO Movement Bonus 2: Flip our character's sprite so that it faces left/right if we are moving left/right. (Hint: A SpriteRenderer reference, and changing its FlipX = true/false will help!)

        }
    }
}
