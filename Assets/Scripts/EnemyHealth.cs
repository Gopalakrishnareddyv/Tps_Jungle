using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField]int health = 5;
    [SerializeField] ParticleSystem particle;
    public void EnemyDamage(int damage)
    {
        health -= damage;
        particle.Play();
        if (health <= 0)
        {
            EnemyCount.instance.Increment();
            this.gameObject.SetActive(false);
        }
    }
}
