using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class col : MonoBehaviour
{
    public GameObject canvas;
    public GameObject panel1,panel2;
    public Canvas c;
    public Camera camera1;
     public Camera camera2;
     public GameObject cam1;
      public GameObject cam2;
      public Text text1;
     public int i,k;
 

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
        camera1.enabled=true;
        camera2.enabled=false;
        i=0;
        k=1;
        text1.enabled=false;
   
        
         
    }
void Freeze(){
    white.rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
}
    // Update is called once per frame
    void Update()
    {
      
    }
//     void pan1(){
//   panel1.SetActive(true);  
//   k++;

// }
// void pan2(){
//         panel1.SetActive(false);  
//         panel2.SetActive(true);  
//     }


     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("cube") && i==0){
            //change camera and fixed position player and set dialogue
   camera1.enabled = false;
         camera2.enabled = true;    
        canvas.gameObject.SetActive(true);
       //k++;
        Invoke("Freeze",k);

        
      

// dialogue panel

if(k==1){
Invoke("pan1",2);
k++;
}
if(k==2){
Invoke("pan2",2);
}
}



/*
if(k==3){
    panel2.SetActive(false);
}
*/
print("dialogue3");

i++;

print("dialogue3");
i++;
print("dialogue3");
i++;
if(i==3){
    Invoke("ret",2);
    i++;
}
  }
     
  
        
       
    
    void OnTriggerExit2D(Collider2D other){
        camera1.enabled = true;
         camera2.enabled = false;
        
         Destroy(this);
          canvas.gameObject.SetActive(false);
    }
    
    void ret(){
        white.rb.constraints = RigidbodyConstraints2D.None;
        white.rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}

    
    

    



    




