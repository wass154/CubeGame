using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milogame : MonoBehaviour
{
    public float speed;
    public float jump;
    [SerializeField] private Rigidbody2D rb;
   /* [SerializeField] private Animator anim;*/
    public Transform pos;
    [SerializeField] private bool isground;
    public float checkradius;
    public LayerMask ground;
    [SerializeField] private float counter;
    public float jumptime;
    [SerializeField] private bool isjump;
    /*[SerializeField] private bool doublejump;*/
    private float movex;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       /* anim = GetComponent<Animator>();*/
    }

    // Update is called once per frame
    void Update()
    {
        movex = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movex * speed, rb.velocity.y);
        if (movex < 0)
        {
            transform.eulerAngles = new Vector3(0, 180f, 0);
        }
        else if(movex>0)
        {
            transform.eulerAngles = new Vector3(0, 0f, 0);
        }
       /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jump;
        }*/
      


      

     

        /*if (movex == 0)
        {
            anim.SetBool("Run", false);
        }
        else if (movex != 0)
        {
            anim.SetBool("Run",true);
        }*/


        /*if(isground==true && Input.GetKeyDown(KeyCode.UpArrow)){
            anim.SetTrigger("j");
            isjump = true;
            counter = jumptime;
            rb.velocity = Vector2.up * jump;*/

    }
    void FixedUpdate()
    {
        isground = Physics2D.OverlapCircle(pos.position, checkradius, ground);
        if (isground == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jump;
        }
    }
}
