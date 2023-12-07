using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotStatsClass
{
    private int hp = 5;
    private int maxhp = 5;

    public int botHp { get { return hp; } set { hp = value; } }
    public int botMaxHp { get { return maxhp; } set { maxhp = value; } }

}

public class BotStats : MonoBehaviour
{
    //[SerializeField]
    //private ParticleSystem deathEffect;
    //[SerializeField]
    //private ParticleSystem hitEffect;

    public BotStatsClass botStats = new BotStatsClass();
    [SerializeField]
    private CameraShake shake;
    public bool cinemachineShake = false;
    [SerializeField]
    private ParticleSystem hitEffect;
    [SerializeField]
    private ParticleSystem deathEffect;


    void Update()
    {
        if (botStats.botHp == 0)
        {
            deathEffect.Play();
            transform.gameObject.SetActive(false);
            if(cinemachineShake)
            {
                CinemachineShake.Instance.ShakeCamera(1.5f, 1.0f);
            }
            else
            {
                shake.Shake(0.2f, 0.1f);
            }
            
        }
    }

    public void botGetHit()
    {
        botStats.botHp--;
        hitEffect.playbackSpeed = 5.5f;
        hitEffect.Play();
    }
}
