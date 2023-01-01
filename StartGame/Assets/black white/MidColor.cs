using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidColor : MonoBehaviour
{
     public SpriteRenderer Mid;
    // Start is called before the first frame update
    void Start()
    {
        Mid= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         if(cubecolor.ischange){
 Mid.color=Color.green;
        }
        if(cubecolor.ischange==false){
Mid.color=Color.white;
        }
    }
}
