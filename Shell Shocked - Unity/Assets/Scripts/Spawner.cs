using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;

    //represents how long we want there to be between spawns 
    public float cooldownDuration;

    public float spawnRange = 1;

    //Represents how long it has been since we last spawned something 
    private float cooldownTimer = 0;


    // Update is called once per frame
    void Update()
    {
        //this adds the time passed since our last frame to our timer 
        cooldownTimer += Time.deltaTime;


        if (cooldownTimer >= cooldownDuration )
        {
            //this picks a random number and uses it to make a new spawn location 
            Vector3 offset = Vector3.zero;
            offset.y = Random.Range(-spawnRange, spawnRange);

            //action: spawn a prefab 
            Instantiate(prefabToSpawn, transform.position+ offset, prefabToSpawn.transform.rotation);

            //resets the cooldown time back to 0
            cooldownTimer = 0;
        }



      


        
    }
}
