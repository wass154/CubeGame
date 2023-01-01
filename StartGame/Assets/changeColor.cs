using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Color color1 = Color.red; 
    public Color color2 = Color.blue; 
    public Color color3 = Color.white; 
    public SpriteRenderer spriteRenderer1;
     public SpriteRenderer spriteRenderer2;
       public SpriteRenderer spriteRenderer3;
       public SpriteRenderer Cube;
       
    // Start is called before the first frame update
    void Start()
    {
          spriteRenderer1 = GetComponent<SpriteRenderer>();
            spriteRenderer2 = GetComponent<SpriteRenderer>();
              spriteRenderer3 = GetComponent<SpriteRenderer>();
                 Cube = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("cube")){
            print("hit ground");
            // Cube.color = color1;
            // spriteRenderer1.color=color3;
            //  spriteRenderer2.color=color2;
            //   spriteRenderer3.color=color3;
              

        }
    }
}
