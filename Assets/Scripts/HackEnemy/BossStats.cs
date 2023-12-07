using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStatsClass
{
    private int hp = 30;
    private int maxhp = 30;

    public int enemyHp { get { return hp; } set { hp = value; } }
    public int enemyMaxhp { get { return maxhp; } set { maxhp = value; } }

}

public class BossStats : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem deathEffect;
    [SerializeField]
    private ParticleSystem hitEffect;
    public LevelLoader retryLevel;
    public BossStatsClass bossStats = new BossStatsClass();
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
    public GameObject canvas;
    void Update()
    {
        if (isHack4)
        {
            if (bossStats.enemyHp == 0)
            {
                deathEffect.Play();
                shake.Shake(0.6f, 0.4f);
                hack4script.enemyNumber++;
                transform.gameObject.SetActive(false);
            }
        }
        else
        {
            if (bossStats.enemyHp == 0)
            {
                canvas.SetActive(false);
                deathEffect.Play();
                if (!isCinmeachine)
                    shake.Shake(0.6f, 0.4f);
                else
                    CinemachineShake.Instance.ShakeCamera(2.0f, 1.0f);
                hackStage.NextStage(enemyNumer);
                transform.gameObject.SetActive(false);
            }
        }

    }

    public void getHit()
    {
        bossStats.enemyHp--;
        hitEffect.Play();
    }
}
