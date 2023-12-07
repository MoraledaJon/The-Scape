using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private List<ParticleSystem> spawnEffect;
    [SerializeField]
    private Animator animation;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            StartCoroutine(SpawnEnemy());
            animation.SetTrigger("open");
            transform.gameObject.SetActive(false);
        }
    }

    IEnumerator SpawnEnemy()
    {
        foreach(ParticleSystem effect  in spawnEffect)
        {
            effect.Play();
        }
        

        yield return 0;
    }
}
