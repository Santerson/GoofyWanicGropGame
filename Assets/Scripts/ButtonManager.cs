using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goToScene1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }

    public void goToTitleScreen()
    {
               UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
