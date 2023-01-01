using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milop2 : MonoBehaviour
{
    public float speed;
    float movx;
    float movy;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movx = 0;
        movy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(movx * speed * Time.deltaTime, movy * speed * Time.deltaTime);
      
     
        if (Input.GetKeyDown(KeyCode.Q))
        {
            movx = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            movx = 1;
        }
   
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.D))
        {
            movx = 0;

        }
    }
}

