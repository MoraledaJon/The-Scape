using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInteraction : MonoBehaviour
{
    BossStats bossStats;

    private void Start()
    {
        bossStats = GetComponent<BossStats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "proyectile")
        {
            bossStats.getHit();
            Destroy(other.gameObject);
        }
    }
}
