using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [field: SerializeField] public Health Health { get; private set; }
    [field: SerializeField] public PlayerSounds Sound { get; private set; }
    [field: SerializeField] public WeaponSounds WeaponSound { get; private set; }
    [field: SerializeField] public PlayerAttack Attack { get; private set; }
    [field: SerializeField] public InputReader Input { get; private set; }
}
