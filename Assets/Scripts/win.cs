using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {

    public GameObject pauseUI;
    public GameObject pauseUI2;

    bool ui = false;
  

    public Player1Controller player1;
    public Player2Controller player2;

    // Use this for initialization
    void Start () {
        pauseUI.SetActive(false);
        pauseUI2.SetActive(false);
        
        player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1Controller>();
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();
    }
	
	// Update is called once per frame
	void Update () {
            if(player1.ourHealth==0 && ui==false)
            {
                Sound.PlaySound("win");
                ui = true;
                pauseUI2.SetActive(true);
                
            return;
            }
            else
            {
                if (player2.ourHealth2 == 0 && ui==false)
                {
                    Sound.PlaySound("win");
                    ui = true;
                    pauseUI.SetActive(true);
                    
                return ;
                }
            }
        }
   
}

