using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] PlayerWeapon weapon;
    Player player;

    private void Awake()
    {
         player = GetComponentInParent<Player>();
    }

    public void EnableWeapon()
    {
        weapon.ColliderEnabled();
    }

    public void DisableWeapon()
    {
        weapon.ColliderEnabled(false);
    }

    public void Swing()
    {
        player.WeaponSound.PlayWeaponSwingSound();
    }

    public void Footstep()
    {
        player.Sound.PlayFootstepSound();
    }
}
