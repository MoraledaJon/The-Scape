using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatsClass
{
    private int hp = 10;
    private int maxhp = 10;

    public int enemyHp { get { return hp; } set { hp = value; } }
    public int enemyMaxhp { get { return maxhp; } set { maxhp = value; } }

}

public class EnemyStats : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem deathEffect;
    [SerializeField]
    private ParticleSystem hitEffect;
    public LevelLoader retryLevel;
    public EnemyStatsClass enemyStats = new EnemyStatsClass();
    [SerializeField]
    private int enemyNumer;
    [SerializeField]
    public HackStageManager hackStage;
    [SerializeField]
    public Hack42Enemy hack4script;
    [SerializeField]
    private CameraShake shake;
    public bool isHack4 = false;
    public bool isCinmeachine = false;
    void Update()
    {
        if(isHack4)
        {
            if (enemyStats.enemyHp == 0)
            {
                deathEffect.Play();
                shake.Shake(0.6f, 0.4f);
                hack4script.enemyNumber++;
                transform.gameObject.SetActive(false);
            }
        }
        else
        {
            if (enemyStats.enemyHp == 0)
            {
                deathEffect.Play();
                if(!isCinmeachine)
                    shake.Shake(0.6f, 0.4f);
                else
                    CinemachineShake.Instance.ShakeCamera(2.0f, 1.0f);
                hackStage.NextStage(enemyNumer);
                transform.gameObject.SetActive(false);
                Debug.Log(enemyNumer);
            }
        }
 
    }

    public void getHit()
    {
        enemyStats.enemyHp--;
        hitEffect.Play();
    }
}
