using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject instructionsPanel;
    // Use this for initialization
    void Start () {
        instructionsPanel.SetActive(false);
    }
	public void playg()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
    public void quit()
    {
        Application.Quit();
    }

    public void instructions()
    {
        instructionsPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.I) )
        {
            instructionsPanel.SetActive(false);
        }
      
    }
}
