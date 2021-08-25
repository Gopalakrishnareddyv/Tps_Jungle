using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    int enemy;
    [SerializeField] Text enemyCountText;
    public void Increment()
    {
        enemy++;
        enemyCountText.text = "enemies " + enemy + "/5";
        if (enemy == 5)
        {
            Debug.Log("GameEnd");
        }
    }
}
