using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    basicCombatBehavior combatBehavior;

    public new string name; //The name of the weapon
    public string description; //The description for this weapon
    public string flavor; //The flavor text for this weapon (optional)
    public Sprite artwork; //The image for this weapon
}