using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] footstepClips;
    [SerializeField] AudioClip[] gruntClips;

    public void PlayFootstepSound()
    {
        audioSource.clip = footstepClips[Random.Range(0, footstepClips.Length)];
        audioSource.Play();

    }
    public void PlaygruntSound()
    {
        audioSource.clip = gruntClips[Random.Range(0, gruntClips.Length)];
        audioSource.Play();

    }
}
