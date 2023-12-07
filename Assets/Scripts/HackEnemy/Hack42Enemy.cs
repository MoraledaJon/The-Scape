using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack42Enemy : MonoBehaviour
{
    public int enemyNumber = 0;
    [SerializeField]
    public HackStageManager hackStage;
    private bool isChanging = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemyNumber);
        if(enemyNumber == 2)
        {
            if(!isChanging)
            {
                hackStage.NextStage(3);
                isChanging = true;
            }
            
        }
    }
}
