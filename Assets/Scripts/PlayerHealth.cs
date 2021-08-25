using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth;
    [SerializeField] float ReBirth;
    public void PlayerDie(int damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            ReBirth -= 1;
            if (ReBirth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    
}
