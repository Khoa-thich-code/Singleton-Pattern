using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayerBehavior : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void FadeNewMusic(AudioClip clip)
    {
        //code here
    }
}
