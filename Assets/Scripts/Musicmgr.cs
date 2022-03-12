using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicmgr : MonoBehaviour
{

    static AudioSource audio;

    public void stop()
    {
        audio.Stop();
    }
}
