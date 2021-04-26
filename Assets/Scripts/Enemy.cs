using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 40;
    [SerializeField] int damage = 10;

    public VictimCount killer;
    public void Damage(int remainingHealth)
    {
        if (remainingHealth <= 0)
        {
            killer.victimas++;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            health -= damage;
            Damage(health);
        }
    }
    // void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.tag == "bullet")
    //     {
    //         health -= damage;
    //         Damage(health);
    //     }
    // }
}