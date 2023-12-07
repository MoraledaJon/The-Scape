using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceStat
{
    private int hp = 3;
    private int maxhp = 3;
    

    public int playerHp { get { return hp; } set { hp = value; } }
    public int playerMaxhp { get { return maxhp; } set { maxhp = value; } }

}

public class RaceStats : MonoBehaviour
{
    [SerializeField]
    private LevelLoader levelLoader;
    [SerializeField]
    private RaceStat raceStat = new RaceStat();
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private CanvasGetClose canvasGetClose;

    void Update()
    {
        if (raceStat.playerHp == 0)
        {
            levelLoader.RestartRace();
        }
    }

    public void getHit()
    {
        raceStat.playerHp--;
        CinemachineShake.Instance.ShakeCamera(2f, 1f);
        anim.SetTrigger("hit");
        canvasGetClose.PoliceGetClose(raceStat.playerHp);
    }
}
