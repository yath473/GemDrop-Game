using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Menu : MonoBehaviour
{
    bool isPause;
    bool isResume;
    public GameObject menu;

    public bool IsPause
    {
        get { return isPause; }
        set { isPause = value; }
    }
    public bool IsResume
    {
        get { return isResume; }
        set { isResume = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        IsPause = false;
        IsResume = false;
        menu.gameObject.SetActive(IsPause);
        menu.gameObject.SetActive(IsResume);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPause = !IsPause;
            menu.gameObject.SetActive(IsPause);

            if (IsPause)
            {
                Time.timeScale = 0.0f;
            }
            else
            {
                Time.timeScale = 1.0f;
            }

        }

    }

    public void Quit()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;

    }
    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        menu.gameObject.SetActive(false);
    }
}
