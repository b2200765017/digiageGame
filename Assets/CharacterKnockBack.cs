using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterKnockBack : Character
{
    private Rigidbody2D _rb;
    private BoxCollider2D _col;
    private bool attacking = false;
    
    private new void Start()
    {
        _col = GetComponent<BoxCollider2D>();
        _rb = GetComponent<Rigidbody2D>();
        Initialization();
    }

    public void GetKnockBack(float knocbackDistance, Vector2 direction)
    {
        _rb.AddForce(direction * knocbackDistance, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {        
            if (attacking) col.transform.GetComponent<CharacterKnockBack>()
            .GetKnockBack(45,
                ((col.transform.position - transform.position).normalized));
        }

    }

    public IEnumerator Attack()
    {
        attacking = true;
        _col.enabled = true;
        yield return new WaitForSeconds(0.1f);
        _col.enabled = false;
        attacking = false;
    }
}
