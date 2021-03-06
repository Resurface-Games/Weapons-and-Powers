using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public basicCombatBehavior healthScript;
    public EnemyScript[] enemies;

    
    public void Spawn(GameObject prefab, Vector2 location, Vector2 rotation)
    {
        Instantiate(prefab, location, rotation);
    }

    public void GainLife(int life)
    {
        healthScript.health += life;
    }

    public void DamageALLEnemies(int damage)
    {
        foreach (EnemyScript v in enemies)
        {
            enemies[v].health -= damage;
        }
    }

    public void DamageSelf(int damage)
    {
        healthScript.health -= damage;
    }
}