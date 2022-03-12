using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionR : MonoBehaviour {

    public float intervalr = 11;
    public GameObject potionR;
    public Player2Controller player2;
    public Player1Controller player1;
    // Use this for initialization
    void Start() {
        potionR.SetActive(false);
        player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1Controller>();
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();
    }

    // Update is called once per frame
    void Update() {
        if (intervalr > 0)
            intervalr -= Time.deltaTime;
        else
            enabled = false;
        if (intervalr < 0 && player1.ourHealth != 0 && player2.ourHealth2 != 0)
            potionR.SetActive(true);
    }
}