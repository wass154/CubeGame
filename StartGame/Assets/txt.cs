using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class txt : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public static int i;
    // Start is called before the first frame update
    void Start()
    {
        i=0;
        scoretext=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
       scoretext.text="DEATH:"+i;
    }
}
