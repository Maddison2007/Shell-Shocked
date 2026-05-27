using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollingBackground : MonoBehaviour
{
    //This will make variables for everything that needs to change in order for the background to move 
    public float speed;
    [SerializeField]
   
    private Renderer bgRenderer;

    // Update is called once per frame
    void Update()
    {
        //This will make sure the renderer can access the material and change the offset
        bgRenderer.material.mainTextureOffset+= new Vector2(speed * Time.deltaTime,0);
    }
}
