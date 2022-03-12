using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUI2 : MonoBehaviour {

    public Sprite[] Heartsprite;

    public Player2Controller player2;

    public Image Heart2;

    // Use this for initialization
    void Start () {
        player2 = GameObject.FindGameObjectWithTag("Playerr").GetComponent<Player2Controller>();
    }
	
	// Update is called once per frame
	void Update () {
        Heart2.sprite = Heartsprite[player2.ourHealth2];
    }
}
