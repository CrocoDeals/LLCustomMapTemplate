using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScrolling : MonoBehaviour
{
    public float scrollX = 0.5f;
    public float scrollY = 0.5f;
    public int materialIndex = 0;

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scrollX;
        float offsetY = Time.time * scrollY;

        //GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
        GetComponent<Renderer>().materials[materialIndex].mainTextureOffset = new Vector2(offsetX, offsetY);
        
    }
}
