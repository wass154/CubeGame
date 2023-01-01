using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopbg : MonoBehaviour
{
    public float bgspeed;
    public Renderer bgrender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgrender.material.mainTextureOffset += new Vector2(bgspeed * Time.deltaTime, 0f);
    }
}
