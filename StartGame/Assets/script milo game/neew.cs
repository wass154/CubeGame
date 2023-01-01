using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neew : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public float speed;
    public float jump;
    [SerializeField] private float movex;
    private bool isground;
    public Transform t;
    public float checkradius;
    public LayerMask ground;
    private bool Face = true;
    private int extrajump;
    public int extravalue;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        extrajump = extravalue;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*move player with add speed from him */
        movex = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movex * speed, rb.velocity.y);
        /**/
        /*jump logic when he touched ground*/
        isground = Physics2D.OverlapCircle(t.position, checkradius, ground);

        if (Face == false && movex > 0)
        {
            Flip();
        }
        else if (Face == true && movex < 0)
        {
            Flip();
        }
    }
    /*flip player from right to left */
    void Flip()
    {
        Face = !Face;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    void Update()
    {
        /* we can jump in air twice or replace value extra jump with 2 for double or triple jump*/
        /*
        if(isground == true)
        {
            extrajump = 1;
        }
        if ( Input.GetKeyDown(KeyCode.UpArrow)&& extrajump>0)
        {
            rb.velocity = Vector2.up * jump;
            extrajump--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)&& extrajump == 0 && isground == true){
            rb.velocity = Vector2.up * jump;
        }
        */
        /* 1 one jump max*/
        if (isground == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jump;
        }

    }

}
