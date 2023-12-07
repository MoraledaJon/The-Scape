using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats
{
    private int hp = 3;
    private int maxhp = 3;
    

    public int playerHp { get { return hp; } set { hp = value; } }
    public int playerMaxhp { get { return maxhp; } set { maxhp = value; } }

}

public class HackPlayerStats : MonoBehaviour
{
    [SerializeField]
    private LevelLoader retryLevel;
    [SerializeField]
    private PlayerStats playerStats = new PlayerStats();
    [SerializeField]
    private CameraShake shake;
    public bool cinemachineShake = false;
    [SerializeField]
    private ParticleSystem hitEffect;
    [SerializeField]
    private ParticleSystem deathEffect;

    public List<GameObject> playerPart;

    void Update()
    {
        if (playerStats.playerHp == 0)
        {
            deathEffect.Play();
            retryLevel.HackGameOver();
            transform.gameObject.SetActive(false);
        }
    }

    public void getHit()
    {
        if (cinemachineShake)
        {
            CinemachineShake.Instance.ShakeCamera(2.0f, 1.0f);
            hitEffect.Play();
            Destroy(playerPart[0]);
            playerStats.playerHp--;
            playerPart.RemoveAt(0);
        }
        else
        {
            shake.Shake(0.4f, 0.2f);
            hitEffect.Play();
            Destroy(playerPart[0]);
            playerStats.playerHp--;
            playerPart.RemoveAt(0);
        }
        

    }
}
