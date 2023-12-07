using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack6Proyectile : MonoBehaviour
{
    public AnimationCurve myCurve1;
    public AnimationCurve myCurve2;
    public AnimationCurve myCurve3;
    public float speed;
    private BossProyectile boss;

    private void Start()
    {
        boss = transform.parent.parent.gameObject.GetComponent<BossProyectile>();
    }

    void Update()
    {
        Debug.Log(boss.phase1Count);
        switch (boss.phase1Count)
       {
            case 1:
                Debug.Log("sahjdhakjsdh");
                transform.position = new Vector3(transform.position.x, myCurve1.Evaluate((Time.time)), transform.position.z);
                break;
            case 2:
                transform.position = new Vector3(transform.position.x, myCurve2.Evaluate((Time.time)), transform.position.z);
                break;
            case 3:
                transform.position = new Vector3(transform.position.x, myCurve3.Evaluate((Time.time)), transform.position.z);
                break;

        }
            
    }
}
