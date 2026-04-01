using UnityEngine;

public class PlayerHealth : MonoBehaviour
{ 
    // this function is not built into unity, it will only be called manually by our own code 
    //it must be marked as public so that our other scripts can access it
    public void Kill()
    {
        Debug.Log("PlayerHealth Kill()");
        //This will destroy the game object that this script is attached to 
        Destroy(gameObject);
    }

}
