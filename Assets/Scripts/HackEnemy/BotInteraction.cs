using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotInteraction : MonoBehaviour
{
    BotStats botStats;

    private void Start()
    {
        botStats = GetComponent<BotStats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "proyectile")
        {
            botStats.botGetHit();
            Destroy(other.gameObject);
        }
    }
}
