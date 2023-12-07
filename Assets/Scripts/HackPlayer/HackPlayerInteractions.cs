using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class HackPlayerInteractions : MonoBehaviour
{
    HackPlayerStats playerStats;
    [SerializeField]
    private Animator firstSpawnAnim;
    [SerializeField]
    private PlayableDirector director;
    private HackPlayerController controller;
    [SerializeField]
    private Animator canvasAnimator;
    [SerializeField]
    public HackStageManager hackStage;
    public Proyectile proyectile;

    void Start()
    {
        playerStats = GetComponent<HackPlayerStats>();
        controller = GetComponent<HackPlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemyProyectile")
        {
            playerStats.getHit();
            Destroy(other.gameObject);
        }
        if (other.tag == "proyectileHitable")
        {
            playerStats.getHit();
            Destroy(other.gameObject);
        }
        else if(other.tag == "Hack5Spawn1")
        {
            firstSpawnAnim.SetTrigger("spawn");
            Destroy(other.gameObject);
        }
        else if (other.tag == "changeCamera")
        {
            director.Play();
            controller.canMove = false;
            proyectile.canShoot = false;
            controller.isHack5Animation = true;
            canvasAnimator.SetTrigger("open");
        }
        else if(other.tag == "nextGame")
        {
            hackStage.NextStage(3);
        }
    }
}
