using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PPOS : MonoBehaviour
{
    private GAMECHECKPOINT g;
    // Start is called before the first frame update
    void Start()
    {
  g=GameObject.FindGameObjectWithTag("G").GetComponent<GAMECHECKPOINT>();
  transform.position=g.lastcheckpoint;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
