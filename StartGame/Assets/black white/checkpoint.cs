using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private GAMECHECKPOINT g;
    // Start is called before the first frame update
    void Start()
    {
        g=GameObject.FindGameObjectWithTag("G").GetComponent<GAMECHECKPOINT>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("cube"))
        {
g.lastcheckpoint=transform.position;
        }
    }
}
