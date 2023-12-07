using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasGetClose : MonoBehaviour
{
    public GameObject vanImage;
    public GameObject policeImage;
    public float vanSpeed;
    public float policeSpeed;
    private bool canMove = false;
    private float distance;
    public float lerpSpeed;
    private bool isHit;
    private Vector3 newPos;
    private float startingX;
    private float timer;
    public Animator anim;

    void Start()
    {
        StartCoroutine(DelayStart());
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            vanImage.transform.Translate(vanImage.transform.right * vanSpeed * Time.deltaTime);
            policeImage.transform.Translate(vanImage.transform.right * policeSpeed * Time.deltaTime);
        }

        if (isHit)
        {
            timer += Time.deltaTime;
            canMove = false;
            
            if (timer <= 1.5f)
            {
                policeImage.transform.position = Vector3.Lerp(policeImage.transform.position, newPos, lerpSpeed * Time.deltaTime);
            }
            else
            {
                canMove = true;
                timer = 0;
                isHit = false;
            }
           
        }

    }
    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(10.5f);

        Debug.Log("start");

        canMove = true; 
    }

    public void PoliceGetClose(int lifes)
    {
        distance = vanImage.transform.position.x - policeImage.transform.position.x;

        switch(lifes)
        {
            case 2:
                newPos = new Vector3(policeImage.transform.position.x + (distance / 2), policeImage.transform.position.y, policeImage.transform.position.z);
                break;
            case 1:
                newPos = new Vector3(policeImage.transform.position.x + (distance / 2), policeImage.transform.position.y, policeImage.transform.position.z);
                policeSpeed = vanSpeed;
                break;
            case 0:
                newPos = new Vector3(policeImage.transform.position.x + (distance - 100), policeImage.transform.position.y, policeImage.transform.position.z);
                vanSpeed = 0;
                policeSpeed = 0;
                anim.StopPlayback();
                break;
        }
       
        isHit = true;

        startingX = policeImage.transform.position.x;
    }
}
