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

    float timer;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        if (timer>0) 
        {
            timer-= Time.deltaTime;
        
        }
        if (timer <= 0) 
        {
            PlayGruntSound();
            ResetTimer();
        }
        
    }

    private void ResetTimer() 
    {
        timer = Random.Range(3f,5f);
    
    }

    public void PlayFootstepSound()
    {
        if (footstepClips.Length == 0) return;
        audioSource.clip = footstepClips[Random.Range(0, footstepClips.Length)];
        audioSource.Play();
    }
    public void PlayGruntSound()
    {
        if (audioSource.isPlaying) return;
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
