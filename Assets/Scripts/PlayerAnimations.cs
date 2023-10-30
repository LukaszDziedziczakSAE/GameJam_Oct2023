using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] PlayerWeapon weapon;

    public void EnableWeapon()
    {
        weapon.ColliderEnabled();
    }

    public void DisableWeapon()
    {
        weapon.ColliderEnabled(false);
    }
}
