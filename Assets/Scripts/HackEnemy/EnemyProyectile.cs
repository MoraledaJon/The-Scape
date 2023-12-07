using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProyectile : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private float timeBtwShoots;
    [SerializeField]
    private float startTimeBtwShoots;
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private GameObject projectileHitable;
    [SerializeField]
    private float speed;
    [SerializeField]
    private bool lookAtPlayer;
    [SerializeField]
    private int hitableSmallNumber;
    [SerializeField]
    private int hitableHighNumber;
    [SerializeField]
    private bool halfHalf;

    private bool hitableBall = false;

    private int random;

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
            random = Random.Range(hitableSmallNumber, hitableHighNumber);

            if (halfHalf)
            {
                if(hitableBall)
                {
                    GameObject ball = (GameObject)Instantiate(projectileHitable, transform.position, Quaternion.identity);

                    Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(transform.forward * speed);
                    timeBtwShoots = startTimeBtwShoots;
                    hitableBall = false;
                }
                else
                {
                    GameObject ball = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);

                    Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(transform.forward * speed);
                    timeBtwShoots = startTimeBtwShoots;
                    hitableBall = true;
                }
                
            }
            else
            {
                if (random == 1)
                {
                    GameObject ball = (GameObject)Instantiate(projectileHitable, transform.position, Quaternion.identity);

                    Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(transform.forward * speed);
                    timeBtwShoots = startTimeBtwShoots;
                }
                else
                {
                    GameObject ball = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);

                    Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(transform.forward * speed);
                    timeBtwShoots = startTimeBtwShoots;
                }
            }
        }else
        {
            timeBtwShoots -= Time.deltaTime;
        }
    }
}
