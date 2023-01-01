using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milop1 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movy = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movy = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movx = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movx = 1;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow))
                {
            movy = 0;   
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            movx = 0;

        }
    }
}

