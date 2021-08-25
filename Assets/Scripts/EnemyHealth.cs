using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField]int health = 5;
    public void EnemyDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
