using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public Functions function; //If you want to call any functions from Functions.cs, type function.NameOfFunction().
    public new string name; //The name of the power
    public string description; //The description for this power
    public string flavor; //The flavor text for this power (optional)
    public Sprite artwork; //The image for this power

    public bool IsAblity; //Is this power an ability that is activated by pressing a button?
    public int cooldown; //If this power is an ability, there needs to be a cooldown time. This is measured in seconds

    public bool Equipped = false;


    if (Equipped)
    {
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
            //This happens when player swingsa sword.
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
}