using UnityEngine;

//This means that our script can only be placed on an object that has a Rigidbody2D
[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    // Script Variables
    public float speed = 1f;
    private Rigidbody2D physicsBody = null;


    private void Awake()
    {
        //Gets the rigidbody2D component that is attached to the same object as this script and stores that component in the physicsBody variable 
       physicsBody =  GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        //Go to the RigidBody stored in our variable
        //change the LinearVelocity's X value to -1
        physicsBody.linearVelocityX = -speed;
    }

    public void MoveRight()
    {
        physicsBody.linearVelocityX = speed;
    }
}
