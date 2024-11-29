using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;

    // Start is called before the first frame update
    public void PlayAudio()
    {
        audio.Play();
    }
    public void PlayAudio2()
    {
        audio2.Play();
    }
    public void PlayAudio3()
    {
        audio3.Play();
    }
}
