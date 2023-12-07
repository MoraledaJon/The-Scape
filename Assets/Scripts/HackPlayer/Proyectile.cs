using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Proyectile : MonoBehaviour
{
    public GameObject ballPrefab;
    public float speed;
    private bool isAutoShoot = false;
    private bool isShootPressed;
    public bool isAutoMode = false;
    private float timeBtwShoots;
    [SerializeField]
    private float startTimeBtwShoots;
    [SerializeField]
    private TextMeshProUGUI autoShootText;
    [SerializeField]
    private Animator r2clickAnimation;
    public bool canShoot = true;


    public void Shoot(InputAction.CallbackContext context)
    {
        if (!isAutoMode)
        {
            if(canShoot)
            {
                if(context.performed)
            {
                GameObject ball = (GameObject)Instantiate(ballPrefab, transform.position, transform.rotation);

                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                ballRigidbody.AddForce(transform.forward * speed);
            }
            }
            
            
        }

    }
    public void AutoShoot(InputAction.CallbackContext context)
    {
        if(canShoot)
        {
            if (context.performed)
            {
                if (!isAutoMode)
                {
                    isAutoMode = true;
                    r2clickAnimation.SetTrigger("click");
                }
                else
                {
                    isAutoMode = false;
                    r2clickAnimation.SetTrigger("click");
                }
            }
        }
    }

    private void Update()
    {
        if(canShoot)
        {
            if (isAutoMode)
            {
                autoShootText.text = "ON";
                if (timeBtwShoots <= 0)
                {
                    GameObject ball = (GameObject)Instantiate(ballPrefab, transform.position, transform.rotation);

                    Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(transform.forward * speed);
                    timeBtwShoots = startTimeBtwShoots;
                }
                else
                {
                    timeBtwShoots -= Time.deltaTime;
                }
            }
            else
            {
                autoShootText.text = "OFF";
            }
        }
        
        
    }
}

