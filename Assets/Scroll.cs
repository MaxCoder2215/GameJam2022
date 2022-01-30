using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    //https://www.youtube.com/watch?v=HrDxnMI7pCc
    // Start is called before the first frame update

    public float speed = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 offset = new Vector2 (Time.time * speed, 0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;


    }
}
