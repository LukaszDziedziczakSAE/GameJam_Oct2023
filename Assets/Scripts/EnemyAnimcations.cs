using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimcations : MonoBehaviour
{
    [SerializeField] EnemyWeapon weapon;
    Enemy Enemy;

    private void Awake()
    {
        Enemy = GetComponentInParent<Enemy>();  
    }
    public void EnableWeapon()
    {
        print(name + " turning on weapon");
        weapon.ColliderEnabled();
    }

    public void DisableWeapon()
    {
        weapon.ColliderEnabled(false);
    }

    public void Footstep() 
    {
        Enemy.Sound.PlayFootstepSound();
    
    }
}
