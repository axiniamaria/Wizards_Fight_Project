using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionB : MonoBehaviour {

    public float intervalb = 8;
    public GameObject potionB;
    public Player2Controller player2;
    public Player1Controller player1;
    // Use this for initialization
    void Start () {
        potionB.SetActive(false);
        player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1Controller>();
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();
    }
	
	// Update is called once per frame
	void Update () {
        if (intervalb > 0)
            intervalb -= Time.deltaTime;
        else
            enabled = false;
        if (intervalb < 0 && player1.ourHealth != 0 && player2.ourHealth2 != 0)
            potionB.SetActive(true);
    }
}
