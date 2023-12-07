using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float enemySpeed;
    [SerializeField]
    private float within_range;
    [SerializeField]
    private bool toPlayer;

    void Update()
    {
        transform.LookAt(player);

        if(toPlayer)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3 (player.position.x , transform.position.y, player.position.z), enemySpeed * Time.deltaTime);
    }
}
