using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    public static AudioClip lifeplayer,jumpplayer,winplayer;
    static AudioSource audio;

	// Use this for initialization
	void Start () {
        lifeplayer = Resources.Load<AudioClip>("life");
        jumpplayer = Resources.Load<AudioClip>("jump");
        winplayer = Resources.Load<AudioClip>("win");
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void PlaySound(string clip)
    {
        switch (clip) {
            case "life":
                audio.PlayOneShot(lifeplayer);
                break;
            case "jump":
                audio.PlayOneShot(jumpplayer);
                break;
            case "win":
                audio.PlayOneShot(winplayer);
                break;
        }
       
    }

    public void stop()
    {
        audio.Stop();
    }

}
