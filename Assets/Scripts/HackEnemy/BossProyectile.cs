using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProyectile : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private float timeBtwShoots;
    [SerializeField]
    private float startTimeBtwShoots;
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private float speed;
    [SerializeField]
    private bool lookAtPlayer;


    public bool phase1 = true;
    public int phase1Count = 1;


    public bool phase2 = false;
    public bool phase3 = false;


    private void Start()
    {
        timeBtwShoots = startTimeBtwShoots;
    }

    private void Update()
    {
        if(lookAtPlayer)
        {
            transform.LookAt(player);
        } 

        if (timeBtwShoots <= 0)
        {
            if(phase1)
            {
                GameObject ball = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);

                ball.transform.parent = gameObject.transform;

                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                ballRigidbody.AddForce(transform.forward * speed);

                timeBtwShoots = startTimeBtwShoots;

                phase1Count++;
                

                if (phase1Count == 3)
                {
                    StartCoroutine(WaitSeconds());
                }
            }
            else if(phase2)
            {

            }
            else if(phase3)
            {

            }
            

        }
        else
        {
            timeBtwShoots -= Time.deltaTime;
        }
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(3f);

        phase1Count = 0;
    }
}
