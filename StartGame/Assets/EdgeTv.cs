using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeTv : MonoBehaviour
{
    public Collider2D box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(B.isblue && W.iswhite && Y.isyellow && red.isred){
box.isTrigger=true;
        }
    }
}
