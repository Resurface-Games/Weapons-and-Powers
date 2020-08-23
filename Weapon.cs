using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    //You don't need to add anything here, it is for when we import this into unity.
    public Animator animator; //The animations for this weapon.
    public AudioSource ShootSound; //The shooting sound for this weapon.
    public AudioSource ReloadSound; //The reload sound for this weapon.
    public AudioSource outOfAmmoSound;

    public int health; //The player's base health when using this weapon
    public int damage; //The player's base attack damage when using this weapon
    public int moveSpeed; //The player's base movement speed when using this weapon
    public int attackSpeed; //This determines the base amount of time between attacks when using this weapon

    public bool Equipped = false;

    void Update()
    {
        
    }

    public void Reload()
    {
        animator.SetTrigger("Reload");
        ReloadSound.Play();
    }
}