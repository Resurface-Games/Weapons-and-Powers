using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    public basicCombatBehavior bombCombatBehavior;

    public float range; //How far the bomb will reach
    public float Damage; //How much damage the bomb will do.
    public float delay; //The amount of seconds you before the explosion


    void Start()
    {
        bombCombatBehavior = gameObject.GetComponent<basicCombatBehavior>();
        animator = gameObject.GetComponent<Animator>();
    }

    public async void BombDropped()
    {
        animator.SetTrigger("Start"); //Tell the animator to start looping the bomb waiting to explode animation.
        await Task.Delay(delay * 1000); //Wait for delay seconds
        Explode();
    }

    void Explode()
    {
        animator.SetTrigger("Explode"); //Tell the animator to start the explosion animation

        if (range > 0)
        {
            Array hits = Physics2D.OverlapCircleAll(transform.position, range);
            foreach (var hit in hits)
            {
                hit = hit.GetComponent<basicCombatBehavior>();
                if (hit != null)
                {
                    hit.Deal(Damage, bombCombatBehavior);
                }
            }
        }
    }
}