using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayer : MonoBehaviour
{
    private static AmbientAudioPlayer instance = null;
    public static AmbientAudioPlayer GetInstance()
    {
        if (instance == null)
        {
            instance = new AmbientAudioPlayer();
        }
        return instance;
    }
    private AmbientAudioPlayer()
    {

    }
    public void FadeNewMusic(AudioClip clip)
    {
        //code here
    }
}

