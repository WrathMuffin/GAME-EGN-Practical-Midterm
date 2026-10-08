using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float maxHP;
    protected float currentHP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void TakeDamage(float damage)
    {
        Debug.Log("Damage taken!");
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log("You died");
        Destroy(gameObject);
    }
}
