using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D physicsBody = null;


    private void Awake()
    {
        //Gets the rigidbody2D component that is attached to the same object as this script and stores that component in the physicsBody variable 
        physicsBody = GetComponent<Rigidbody2D>();
    }

  



void Update()
    {
       physicsBody.linearVelocityX = -speed;
    }
}
