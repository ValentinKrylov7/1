using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySoundStartButton()
    {
        AudioClip audioClip = Resources.Load<AudioClip>("Sounds/aimingMouse");
        audioSource.PlayOneShot(audioClip);
    }
}
