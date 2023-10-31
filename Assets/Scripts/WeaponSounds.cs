using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] weaponSwingClips;
    [SerializeField] AudioClip[] weaponHitClips;

    public void PlayWeaponSwingSound()
    {
        audioSource.clip = weaponSwingClips[Random.Range(0, weaponSwingClips.Length)];
        audioSource.Play();
    }
    public void PlayWeaponHitSound()
    {
        audioSource.clip = weaponHitClips[Random.Range(0, weaponHitClips.Length)];
        audioSource.Play();
    }

}
