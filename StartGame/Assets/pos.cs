using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos : MonoBehaviour
{
    public GameObject cube;
    public Rigidbody2D rb;
    public SpriteRenderer R;
     Color m_NewColor;
    // Start is called before the first frame update
    void Start()
    {
           R = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("p")){
this.transform.position=cube.transform.position;
rb.constraints = RigidbodyConstraints2D.FreezePositionX;

 R.color = Color.blue;



print("p hit");
        }
    }
}
