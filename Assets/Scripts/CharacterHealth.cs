using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : Character
{
    private float health;
    
    public new void Start()
    {
        health = characterData.Health;
    }
    public void TakeDamage()
    {
        health -= 1;
        if (health <= 0)
        {
            Debug.Log("Game Is Finished!");
        }
        GetComponent<CharacterUIHandler>().SetHealth(health);
        Debug.Log(health);
    }

}
