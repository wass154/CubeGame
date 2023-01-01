using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopColor : MonoBehaviour
{
     public SpriteRenderer Top;
    // Start is called before the first frame update
    void Start()
    {
         Top= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cubecolor.ischange){
 Top.color=Color.yellow;
        }
        if(cubecolor.ischange==false){
 Top.color=Color.black;
        }
    }
}
