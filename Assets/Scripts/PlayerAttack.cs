using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputReader input;
    [SerializeField] Animator animator;

    Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    [field: SerializeField] public int AttackDamage { get; private set; } 

    private void Start()
    {
        input.Attack += OnAttack;
    }

    private void OnAttack()
    {
        animator.SetTrigger("Attack");
        player.Sound.PlaygruntSound();
    }
}
