using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Script", menuName = "Power or Weapon Script")] //Delete this when making a new power/weapon
public class PowerAndWeaponTemplate : MonoBehavior
{
    void ItemEncountered()
    {
        //ItemEncountered will be called if this is a power, and it is an ability.
        //It assigns a key to the ability.
        //You probably don't need to add anything to this function, 
        //but keep it here.
        public int abilityKey = Random.Range(0, 3);
    }

    public void OnRoll()
    {
        //OnRoll() will be called whenever the player rolls. 
        //You don't have to worry about actually making the player roll.
        //This is just for adding stuff like drop a bomb, or make fire.
    }

    public void Ability(int button)
    {
        if (button == abilityKey)
        {
            //This will happen when the player activates the ability
            //Cooldown is managed elsewhere, soo don't worry about that
        }
    }

    public void OnShoot()
    {
        //This happens when player shoots.
        //This is usefull when you want something to happen every x shots.
    }

    public void OnLifeGain(int LifeGained)
    {
        //This is called when the player gains life, 
        //and in the parameters is the amount of life gained.
    }
}