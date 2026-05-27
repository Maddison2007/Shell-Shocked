using UnityEngine;
using UnityEngine.SceneManagement;
//This allows the scene to change when the play button is pressed
public class SceneChange : MonoBehaviour
{
    
    public void ChangeToScene (string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);

    }
    

}
