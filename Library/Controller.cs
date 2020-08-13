using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    Power[] powers;

    [SerializeField]
    Weapon[] weapons;
    
    [SerializeField]
    CIAN_RigidbodyMovement2D movementScript;

    [SerializeField]
    Transform playerTrans;

    [SerializeField]
    float distanceNeeded;
    

    void Update()
    {
        movementScript.movement = GetMovement();
    }

    Vector2 GetMovement()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    bool InRange(Vector2 playerPos, Vector2 itemPos, float distance)
    {
        if (Vector2.Distance(playerPos, itemPos) < distance)
        {
            return true;
            break;
        }

        return false;
    }
}