using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public Health Health { get; private set; }
    [field: SerializeField] public PlayerSounds Sound { get; private set; }
    [field: SerializeField] public WeaponSounds WeaponSound { get; private set; }
    [field: SerializeField] public PlayerAttack Attack { get; private set; }
}
