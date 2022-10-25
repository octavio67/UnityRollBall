using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame1");
    }

    public void PlayStage2() 
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
       // SceneManager.LoadScene("Quit");
    }

    
}
