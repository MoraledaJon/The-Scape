using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    EnemyStats enemyStats;

    private void Start()
    {
        enemyStats = GetComponent<EnemyStats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "proyectile")
        {
            enemyStats.getHit();
            Destroy(other.gameObject);
        }
    }
}
