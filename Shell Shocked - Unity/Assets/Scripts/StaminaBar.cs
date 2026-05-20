using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScrollingBar : MonoBehaviour
{
    // Unity editor variable
    [SerializeField]
    Image scrollingBar;
    [SerializeField]
    float fillArea, MaxGauge;
    [SerializeField]
    float depleteSpeed = 1;


    // Update is called once per frame
    void Update()
    {
        fillArea -= depleteSpeed * Time.deltaTime;
        scrollingBar.fillAmount = fillArea / MaxGauge;

        if (fillArea <= 0)
        {
            SceneManager.LoadScene(0);
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

        if (collision.gameObject.tag == ("Oil"))
        {
            fillArea = fillArea - 5;
          
        }

        if (collision.gameObject.tag == ("DEATHBARRIER OF DOOM"))
        {
            fillArea = fillArea - 10;

        }

        if (collision.gameObject.tag == ("Kelp"))
        {
            fillArea = fillArea + 15;
        }
    }
    }
