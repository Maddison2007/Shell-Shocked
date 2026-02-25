using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //text
        Debug.Log("Hello World! :D");
        Debug.LogError("Caleeb keeps objecting");
        Debug.LogWarning("SHOCKING BEHAVIOUR!!!!!!!!! :(");


      
       
    }

    // Update is called once per frame
    void Update()
    {
        //repeated text
        Debug.Log("L to Caleb in the chat");

        transform.Rotate(0.1f, 0, 0);
    }
}
