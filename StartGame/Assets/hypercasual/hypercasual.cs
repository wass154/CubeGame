using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hypercasual : MonoBehaviour
{
    public float speed = 1000f;
    public float scalespeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        transform.localScale = new Vector2(transform.localScale.x+0.1f*scalespeed, transform.localScale.y);
    }

}