using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField]int health = 5;
    public void EnemyDamage(int damage)
    {
        var enemyCount = GameObject.Find("EnemyCount").GetComponent<EnemyCount>();
        health -= damage;
        if (health <= 0)
        {
            enemyCount.Increment();
            this.gameObject.SetActive(false);
        }
    }
}
