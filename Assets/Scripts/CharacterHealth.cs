using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : Character
{
    private float health;
    [SerializeField] private GameFinishController _gameFinish ;
    
    public new void Start()
    {
        Initialization();
        health = characterData.Health;
    }
    public void TakeDamage()
    {
        health -= 1;
        if (health <= 0)
        {
            _gameFinish.Finish(gameObject.name);
        }
        GetComponent<CharacterUIHandler>().SetHealth(health);
    }

}
