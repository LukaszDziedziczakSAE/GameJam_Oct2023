using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] getHitClips;

    public void PlayCastleHitSound()
    {
        audioSource.clip = getHitClips[Random.Range(0, getHitClips.Length)];
        audioSource.Play();
    }

}
