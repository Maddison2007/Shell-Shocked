using Unity.VisualScripting;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //This creates a variable for speed which can be changed in the objects inspector menu
    public float speed = 1f;

    //This ensures that the physics on the object is set to 0
    private Rigidbody2D physicsBody = null;


    private void Awake()
    {
        //Gets the rigidbody2D component that is attached to the same object as this script and stores that component in the physicsBody variable 
        physicsBody = GetComponent<Rigidbody2D>();
    }

  



    void Update()
    {
        //This ensures the direction that the object is moving in (x axis)
       physicsBody.linearVelocityX = -speed;
    }
}
