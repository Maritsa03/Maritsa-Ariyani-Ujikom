using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float maxHP = 10;
    float currentHP;
    public bool OnPlayerDeath=true;
    public Animator animator;

    public void Start()
    {
        currentHP = maxHP;
        OnPlayerDeath=false;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHP -= damageAmount;
        Debug.Log("Player"+currentHP);

        if (currentHP <= 0)
        {
            OnPlayerDeath=true;
        }else
        {
            OnPlayerDeath=false;
        }
    }

    
}
