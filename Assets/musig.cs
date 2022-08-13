using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musig : MonoBehaviour
{
    public AudioSource audioSource;
    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.volume /= audioSource.volume;
            audioSource.Play();
        }
    }
}
