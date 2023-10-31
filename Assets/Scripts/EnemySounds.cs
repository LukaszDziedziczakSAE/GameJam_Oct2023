using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] footstepClips;
    [SerializeField] AudioClip[] gruntClips;
    [SerializeField] AudioClip[] hittingClips;
    [SerializeField] AudioClip[] deathClips;

    public void PlayFootstepSound()
    {
        audioSource.clip = footstepClips[Random.Range(0, footstepClips.Length)];
        audioSource.Play();
    }
    public void PlayGruntSound()
    {
        audioSource.clip = gruntClips[Random.Range(0, gruntClips.Length)];
        audioSource.Play();
    }
    public void PlayHittingSound()
    {
        audioSource.clip = hittingClips[Random.Range(0, hittingClips.Length)];
        audioSource.Play();
    }
    public void PlayDeathSound()
    {
        audioSource.clip = deathClips[Random.Range(0, deathClips.Length)];
        audioSource.Play();
    }

}
