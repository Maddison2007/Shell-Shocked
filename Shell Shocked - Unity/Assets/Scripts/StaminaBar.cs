using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScrollingBar : MonoBehaviour
{
    // Unity editor variable
    //This is where i created the variables for all of the items 
    [SerializeField]
    Image scrollingBar;
    [SerializeField]
    float fillArea, MaxGauge;
    [SerializeField]
    float depleteSpeed = 1;


    // Update is called once per frame
    void Update()
    {
        //This takes the fillArea and makes it decrease over a certain amount of time 
        fillArea -= depleteSpeed * Time.deltaTime;
        //This creates a max amount it can be decreased before the player dies.
        scrollingBar.fillAmount = fillArea / MaxGauge;

        //This will bring up the title screen if the player dies AKA if the energy bar reaches 0
        if (fillArea <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // CONDITION:
        // If the Enemy tag has collided with the player
        if (collision.gameObject.tag == ("Enemy"))
        {
            fillArea = fillArea - 5;
       
        }
        //This determines how much the energy bar goes down when the player touches an oil spill
        if (collision.gameObject.tag == ("Oil"))
        {
            fillArea = fillArea - 5;
          
        }
        //This will take away energy if the player touches the bottom barrier 
        if (collision.gameObject.tag == ("DEATHBARRIER OF DOOM"))
        {
            fillArea = fillArea - 10;

        }
        //This determines how much the energy bar goes up when the player collects a piece of kelp
        if (collision.gameObject.tag == ("Kelp"))
        {
            fillArea = fillArea + 15;
   
        }
        //This determines how much the energy bar goes down when the player touches anything with the whale tag.
        //(The shark and the whale prefabs)
        if (collision.gameObject.tag == ("Whale"))
        {
            fillArea = fillArea - 10;
        }
    }
    }
