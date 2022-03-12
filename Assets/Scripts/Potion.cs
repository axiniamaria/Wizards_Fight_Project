using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public float interval=5;
    public GameObject potion;
    public Player2Controller player2;
    public Player1Controller player1;
    // Use this for initialization
    void Start ()
    {
        potion.SetActive(false);
        player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1Controller>();
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();

    }

    // Update is called once per frame
    void Update () {

        if (interval > 0)
            interval -= Time.deltaTime;
        else
            enabled = false;
        if(interval<0 && player1.ourHealth!=0 && player2.ourHealth2!=0)
        potion.SetActive(true);
    }
}
