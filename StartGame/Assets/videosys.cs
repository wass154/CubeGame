using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class videosys : MonoBehaviour
{
 
    public  int i;
    public VideoPlayer vid;
    // Start is called before the first frame update
    void Start()
    {
        vid.loopPointReached += CheckOver;
    }

    // Update is called once per frame
    void Update()
    {
       if(i==1){
     SceneManager.LoadScene(2);
       }
    }
 
void CheckOver(UnityEngine.Video.VideoPlayer vid)
{
     vid.playbackSpeed = vid.playbackSpeed / 10.0F;
     print  ("Video Is Over");
     i=1;
}
}
