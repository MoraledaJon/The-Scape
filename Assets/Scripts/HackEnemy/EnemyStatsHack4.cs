using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatsClassHack4
{
    private int hp = 10;
    private int maxhp = 10;

    public int enemyHp { get { return hp; } set { hp = value; } }
    public int enemyMaxhp { get { return maxhp; } set { maxhp = value; } }

}

public class EnemyStatsHack4 : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem deathEffect;
    [SerializeField]
    private ParticleSystem hitEffect;
    public LevelLoader retryLevel;
    public EnemyStatsClassHack4 enemyStats = new EnemyStatsClassHack4();
    [SerializeField]
    private int enemyNumer;
    [SerializeField]
    public Hack42Enemy hack4script;
    [SerializeField]
    private CameraShake shake;
    void Update()
    {
        if (enemyStats.enemyHp == 0)
        {
            deathEffect.Play();
            shake.Shake(0.6f, 0.4f);
            hack4script.enemyNumber++;
            transform.gameObject.SetActive(false);
        }
    }

    public void getHit()
    {
        enemyStats.enemyHp--;
        hitEffect.Play();
    }
}
