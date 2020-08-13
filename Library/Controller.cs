using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFunctions : MonoBehaviour
{
    public Power[] powers;
    public Weapon[] weapons;
    public CIAN_RigidbodyMovement2D movementScript;
    

    void Update()
    {
        movementScript.movement.x = Input.GetAxisRaw("Horizontal");
        movementScript.movement.y = Input.GetAxisRaw("Vertical");
    }
}