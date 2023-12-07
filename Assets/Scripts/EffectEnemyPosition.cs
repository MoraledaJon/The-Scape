using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectEnemyPosition : MonoBehaviour
{
    [SerializeField]
    private Transform enemy;

    ParticleSystem particles;
    // Start is called before the first frame update
    void Awake()
    {
        particles = GetComponent<ParticleSystem>();

        particles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.position;
    }
}
