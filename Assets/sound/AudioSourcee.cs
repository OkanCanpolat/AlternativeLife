using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourcee : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip audioClip;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        
    }

    public void sesiCal(AudioClip audioClip)
    {
        _audioSource.PlayOneShot(audioClip);
    }
}
