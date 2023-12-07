using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaceInteractions : MonoBehaviour
{
    public SpawnManager spawnManager1;
    public LevelLoader levelLoader;
    public RaceStats raceStats;
    
    public void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "SpawnTrigger":
                spawnManager1.SpawnTriggerEntered();
                break;
            case "endRace":
                levelLoader.LoadNextLevel();
                break;
            case "Car":
                raceStats.getHit();
                break;
        }
        
    }
}
