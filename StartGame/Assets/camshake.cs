using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camshake : MonoBehaviour
{
    public float shaketime,shakepower;
    public SpriteRenderer rend;

   public float speedScale = 1f;
    public Color fadeColor = Color.black;
    // Rather than Lerp or Slerp, we allow adaptability with a configurable curve
    public AnimationCurve Curve = new AnimationCurve(new Keyframe(0, 1),
        new Keyframe(0.5f, 0.5f, -1.5f, -1.5f), new Keyframe(1, 0));
    public bool startFadedOut = false;
public GameObject img;

    private float alpha = 0f; 
    private Texture2D texture;
    private int direction = 0;
    private float time = 0f;
public int i=0;



    // Start is called before the first frame update
    void Start()
    {
        i=0;
        img.SetActive(false);
            print(Edg.sha);
            if (startFadedOut) alpha = 1f; else alpha = 0f;
        texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
        texture.Apply();

        
         
        }
      
    

    // Update is called once per frame
    void Update()
    {
         if (direction == 0 && Edg.sha==true)
        {
            if (alpha >= 1f) // Fully faded out
            {
                i++;
                print(i);
                alpha = 1f;
                time = 0f;
                direction = 1;
              
            }
            else // Fully faded in
            {
                i++;
                print(i);
                alpha = 0f;
                time = 1f;
                direction = -1;
               
            }

           
                 
        }
        if(i==10){
            img.SetActive(true);
           
                SceneManager.LoadScene(3);
        }
        
       
       
       
    }
    private void LateUpdate(){
        if(shaketime>0){
            shaketime-=Time.deltaTime;
            float xamount=Random.Range(-1f,1f)*shakepower;
            transform.position+=new Vector3(xamount,0f,0f);
        }
    }
    public void startshake(float length,float power){
        shaketime=length;
        shakepower=power;
    }
    void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.tag == "edge"  ){  
  startshake(-5f,1f);
  
  
        }
    }

    public void OnGUI()
    {
        if (alpha > 0f) GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);
        if (direction != 0)
        {
            time += direction * Time.deltaTime * speedScale;
            alpha = Curve.Evaluate(time);
            texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
            texture.Apply();
            if (alpha <= 0f || alpha >= 1f) direction = 0;
        }
    }
}












