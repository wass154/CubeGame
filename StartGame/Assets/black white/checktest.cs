using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checktest : MonoBehaviour
{
     GameObject cube;
      public int spawnPointX ;
  public int spawnPointY ;
   public int spawnPointZ ;
    int death;
    // Start is called before the first frame update
    void Start()
    {
          death=0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D cube) {
       if(cube.gameObject.CompareTag("cube")){
         cube.transform.position = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        death++;
        txt.i+=1;
        print(death);
     }
 }
}
