using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraf : MonoBehaviour
{
    public Transform tar;
    public Vector3 vec;
    [Range(1,10)]
    public float smoothFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void FixedUpdate()
    {
        Vector3 targetPosition = tar.position + vec;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
