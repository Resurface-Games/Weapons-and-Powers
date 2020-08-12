using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "New Weapon")] //Delete this when making a new weapon
public class Weapon : ScriptableObject
{
    public Functions function; //If you want to call any functions from Functions.cs, type function.NameOfFunction().
    public new string name; //The name of the weapon
    public string description; //The description for this weapon
    public string flavor; //The flavor text for this weapon (optional)
    public Sprite artwork; //The image for this weapon

    public int health; //The player's base health when using this weapon
    public int damage; //The player's base attack damage when using this weapon
    public int moveSpeed; //The player's base movement speed when using this weapon
    public int attackSpeed; //This determines the base amount of time between attacks when using this weapon


    public void ItemEncountered()
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

    public bool Ability(int button)
    {
        if (button == abilityKey)
        {
            //This will happen when the player activates the ability
            return true; //This is needed so that the cooldown manager knows if something happened.
        }
    }

    public void OnShoot()
    {
        //This happens when player shoots.
        //This is usefull when you want something to happen every x shots.
    }

    public void OnSwing()
    {
        //This happens when player swings a weapon.
        //This is usefull when you want something to happen every x swings.
    }

    public void OnLifeGain(int LifeGained)
    {
        //This is called when the player gains life, 
        //and in the parameters is the amount of life gained.
    }

    public void OnDamaged(int damage)
    {
        //This is called when the player is damaged.
        //The damage that is dealt will be passed through the parameters.
        //This can be used for a "thorns" effect.
    }

    public void OnEnemyDeath()
    {
        //This is called when an enemy dies.
        //This can be used for a looting effect.
    }
}