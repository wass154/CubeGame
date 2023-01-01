using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1) ;
    }
   /*public void GoToSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }*/
    public void Quit()
    {
        Application.Quit();
    }
}
