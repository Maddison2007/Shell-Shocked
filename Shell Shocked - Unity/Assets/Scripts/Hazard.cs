using UnityEngine;

public class Hazard : MonoBehaviour
{
    //built in unity function for handling collisions, this function will be called when another object bumps into the one this script is attached to 
     void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object we collided with

        Collider2D objectWeCollidedWith = collisionData.collider;

        //get player health script attached to that object if there is one 

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        //check if we actually found a player health script on the object we collided with 
        //this if statement is true if the player variable is not null aka empty
        if (player != null)

        {
            //this means there was a player health script attached to the object we bumped into this means this object is indeed a player 
            //we now perform our action
            player.Kill();
        }
    }

}
