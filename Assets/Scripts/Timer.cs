using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeValue = 300;
    public Text timeText;
  
    public GameObject pauseUI;
    public GameObject pauseUI2;

    public GameObject endOfTime;

    // Use this for initialization
    void Start()
    {
        endOfTime.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        if (timeValue < 0 || pauseUI.activeSelf == true || pauseUI2.activeSelf == true)
        {
            timeValue = 0;
        }

        if (timeValue == 0 && pauseUI.activeSelf == false && pauseUI2.activeSelf == false)
        {
            endOfTime.SetActive(true);
        }
        
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00} {1:00}", minutes, seconds);
    }
}
