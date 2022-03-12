using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public bool pause = false;
    public GameObject pausedUI;

    public GameObject pauseUI;
    public GameObject pauseUI2;
    public GameObject endOfTime;

    // Use this for initialization
    void Start() {
        pausedUI.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if ((Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) && pauseUI.activeSelf == false && pauseUI2.activeSelf == false && endOfTime.activeSelf == false)
        {
           pause = !pause;
        }

        if (pause)
        {
            pausedUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (pause == false)
        {
            pausedUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void resume()
    {
        pause = false;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void quit()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
