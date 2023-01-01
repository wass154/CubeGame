using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 vec;
    public int counter;
    public float doublespeed;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        vec = new Vector2(directionX, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity=new Vector2(vec.x * speed, vec.y * speed);
 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
         
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "star")
        {
            counter++;
            Destroy(this);
            print(counter);
        }
    }
}
