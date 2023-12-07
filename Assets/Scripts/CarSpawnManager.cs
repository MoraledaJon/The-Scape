using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class spawner
{
    public GameObject spawer;
    public float cooldown;
    public float currentCooldown;

    public void ChangeTime()
    {
        currentCooldown -= Time.deltaTime;
    }


}
public class CarSpawnManager : MonoBehaviour
{   
  
    public GameObject[] spawners;
    private List<spawner> spawnerlist;
    [Range(0,60)]
    public float timemin;
    [Range(0,60)]
    public float timemax;
    public GameObject[] Carprefab;
    
    private float timer;

    private void Start()
    {
        spawnerlist = new List<spawner>();

        foreach (GameObject s in spawners)
        {
            float cd = Random.Range(timemin, timemax);
            spawner a = new spawner { spawer = s, cooldown = cd };
            a.currentCooldown = a.cooldown;
            spawnerlist.Add(a);
        }
    }
    void Update()
    {
        foreach(spawner s in spawnerlist)
        {
            if (s.currentCooldown > 0)
                s.ChangeTime();
            else
            {
                float cd = Random.Range(timemin, timemax);
                s.cooldown = cd;
                s.currentCooldown = s.cooldown;
                GameObject car = Carprefab[Random.Range(0, Carprefab.Length)];  
                Instantiate(car, s.spawer.transform);
            }
        }

    }
}
