using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;

    //represents how long we want there to be between spawns 
    public float cooldownDuration;

    //Represents how long it has been since we last spawned something 
    private float cooldownTimer = 0;


    // Update is called once per frame
    void Update()
    {
        //this adds the time passed since our last frame to our timer 
        cooldownTimer += Time.deltaTime;


        if (cooldownTimer >= cooldownDuration )
        {
            //action: spawn a prefab 
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            //resets the cooldown time back to 0
            cooldownTimer = 0;
        }



      


        
    }
}
