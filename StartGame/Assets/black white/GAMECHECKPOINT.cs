using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMECHECKPOINT : MonoBehaviour
{
    private static GAMECHECKPOINT instance;
    public Vector2 lastcheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(instance);
        }
            else{
                Destroy(gameObject);
            }
        }
    }

