using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void Settings() 
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void BacktoMainMenu() 
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void HighScore() 
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void QuitGame() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
    


    // Start is called before the first frame update


}

