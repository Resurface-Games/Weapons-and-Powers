using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    
    public float delay; //The amount of seconds you before the explosion

    public async void Spawned()
    {
        animator.SetTrigger("Start"); //Tell the animator to start looping the bomb waiting to explode animation.
        await Task.Delay(delay * 1000); //Wait for delay seconds
        animator.SetTrigger("Explode"); //Tell the animator to start the explosion animation.
    }
}