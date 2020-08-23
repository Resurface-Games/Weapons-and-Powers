using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Power : Item
{
    public bool IsAblity; //Is this power an ability that is activated by pressing a button?
    public int cooldown; //If this power is an ability, there needs to be a cooldown time. This is measured in seconds

    public bool Equipped = false;

    public void ItemEncountered()
    {
        //ItemEncountered will be called if this is a power, and it is an ability.
        //It assigns a key to the ability.
        //You probably don't need to add anything to this function, 
        //but keep it here.
        public int abilityKey = Random.Range(0, 3);
    }

    public bool Ability(int button)
    {
        if (button == abilityKey)
        {
            //This will happen when the player activates the ability
            return true; //This is needed so that the cooldown manager knows if something happened.
        }
    }
}