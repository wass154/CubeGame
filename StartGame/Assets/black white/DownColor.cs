using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownColor : MonoBehaviour
{
     public SpriteRenderer Down;
    // Start is called before the first frame update
    void Start()
    {
      Down= GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        if(cubecolor.ischange){
Down.color=Color.yellow;
        }
        if(cubecolor.ischange==false){
 Down.color=Color.black;
        }
    }
}
