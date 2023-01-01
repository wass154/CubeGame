using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubetest : MonoBehaviour
{
    public GameObject cube;
 public int spawnPointX ;
  public int spawnPointY ;
   public int spawnPointZ ;
    int death;
    // Start is called before the first frame update
    void Start()
    {
        death=0;
    }
void OnCollisionEnter2D(Collision2D cube) {
       if(cube.gameObject.CompareTag("cube")){
         cube.transform.position = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
        death++;
        txt.i+=1;
        print(death);
     }
 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
