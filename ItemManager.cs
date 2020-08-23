using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public bool IsRoll = false;
    public bool Rampage = false;

    public Item[] activeItems; //The 5 active powers and the equipped weapon

    public void LifeGained(float life)
    {
        foreach (Item item in activeItems)
        {
            item.LifeGained(life);
        }
    }
}