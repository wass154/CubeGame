using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// scene libraire
 using UnityEngine.UI;

public class white : MonoBehaviour
{

    //dash variables
    private int death;
    private bool cDash = true;
    private bool isdash;
    public float delayrestart=1f;
    private float dashpower = 20f;
    private float dashtime = 0.2f;
    private float dashdown = 1f;
    [SerializeField] private TrailRenderer trail;

    //
    [SerializeField] public static Rigidbody2D rb;
    public static float speed=5f;
    public float jump;
    [SerializeField] private float movex;
    private bool isground;
    public Transform t;
    public float checkradius;
    public LayerMask ground;
    private bool Face = true;
    private int extrajump;
    public int extravalue;
    public Camera camera2;
    public int R;

    // Start is called before the first frame update
    void Start()
    {
        R=0;
        camera2.enabled=false;
        death=0;
        rb = GetComponent<Rigidbody2D>();
        extrajump = extravalue;
    }
     private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("cube"))
        {
    
         StartCoroutine(c());
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);// restrat game
            death++;
            print("death");
            print(death);
            //if  SceneManager.LoadScene(0) go to scene 0 to link a time with function make a ienumerator then added in the void function with start courtine

        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("edge")){
R=2;
        }
    }
    IEnumerator c(){ // ienumerator to set time with delay 
           yield return new WaitForSeconds(delayrestart);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (isdash)
        {
            return;//return true
        }
        /*move player with add speed from him */
        movex = Input.GetAxisRaw("Horizontal");
        rb.velocity= new Vector2(movex * speed ,rb.velocity.y);
        /**/
        /*jump logic when he touched ground*/
     isground = Physics2D.OverlapCircle(t.position,checkradius, ground);

      if(Face==false&& movex>0)
        {
            Flip();
        }
      else if(Face==true&&movex<0)
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
        if (isdash)
        {
            return;//return true
        }
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
           if(isground==true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jump;
        }
           if(Input.GetKeyDown(KeyCode.LeftShift)&&cDash&&R==2)
        {
            StartCoroutine(dash());
        }
        
    }
  
    private IEnumerator dash()
    {
        cDash = false;
        isdash = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashpower, 0f);
        trail.emitting = true;
        yield return new WaitForSeconds(dashtime);
        trail.emitting = false;
        rb.gravityScale = originalGravity;
        isdash = false;
        yield return new WaitForSeconds(dashdown);
        cDash = true;
    }
   /* private void fallDetect()
    {
        if (t.position.y>mf)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }*/
  
       
    }

