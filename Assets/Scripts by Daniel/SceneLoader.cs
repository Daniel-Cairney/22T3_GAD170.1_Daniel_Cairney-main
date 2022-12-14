using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DanielCairney
{
    /// <summary>
    /// This class holds functionality for scene transition and reloading this scene to restart the game.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        // TODO Loader 1/4: Declare a string variable for the name of the scene we want to load, which is this scene. (Write in the scene's name in Unity's Inspector.)
        private string sceneName = "Platformer (Basic Scene)";

        private void LoadScene(string scene)
        {
            // TODO Loader 2/4: Call Unity's "SceneManager.LoadScene" method and pass in your scene name variable to its parametersówithin the parentheses ( ).
            SceneManager.LoadScene(scene);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // TODO Loader 3/4: Call your load scene method to load this same scene again (effectively restarting the game).
            if (collision.gameObject.tag == "Finish")
            {
                LoadScene(sceneName);
            }
            // TODO Loader 4/4: Add this script to a gameobject so that it can restart the game when collided with. (A flag might be good!)

            // TODO Loader Final: Add code comments describing what you hope your code is doing throughout this script.
            /// throughout the script the scene will reload when the character (Alan) collides with the object which in my instance is a flag, it starts with line 16 where i declare the
            /// scene as a variable, then i make the scene a string. from line 22 it can detect if Alan collides with the game object, from there the if statement makes it so if Alan collides with
            ///the object it will reload the scene
            // TODO Loader Bonus 1: Modify your load scene method so that you can write any string or int level and it will load that. (Hint: Adding parameters to it might help!)

            // TODO Loader Bonus 2: Add a reference to your second scene (or any scenes you want) so that a second (or more) level can be loaded!

        }
    }
}
