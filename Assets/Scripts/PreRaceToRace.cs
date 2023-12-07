using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreRaceToRace : MonoBehaviour
{
    private float timer = 0;
    public LevelLoader levelLoader;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 9f)
        {
            levelLoader.LoadNextLevel();
        }
    }
}
