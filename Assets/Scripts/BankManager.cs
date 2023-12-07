using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public List<GameObject> bank;
    public int bankNumber = 1;
    DontDestroy dontDestroy;
    public GameObject player;
    public GameObject cam;
    public Animator securityDoor;
    public Animator bankDoor;
    public Animator lasers;
    private bool doAnimation = false;
    private bool doDoorAnimation = false;
    public PlayerMovment character;
    public GameObject laserAndDoor;
    public GameObject OpenDoor;


    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
    }

    private void Start()
    {
        bankNumber = dontDestroy.bankNumber;
        if(dontDestroy.playerPosition != Vector3.zero)
        {
            player.transform.position = dontDestroy.playerPosition;
            cam.transform.position = dontDestroy.cameraPosition;
        }
    }


    void Update()
    {
        switch (bankNumber)
        {
            case 1:
                bank[0].gameObject.SetActive(true);
                break;
            case 2:
                bank[0].gameObject.SetActive(false);
                bank[1].gameObject.SetActive(true);
                break;
            case 3:
                bank[1].gameObject.SetActive(false);
                bank[2].gameObject.SetActive(true);
                break;
            case 4:
                bank[2].gameObject.SetActive(false);
                bank[3].gameObject.SetActive(true);
                break;
            case 5:
                bank[3].gameObject.SetActive(false);
                bank[4].gameObject.SetActive(true);
                break;
            case 6:
                bank[4].gameObject.SetActive(false);
                bank[5].gameObject.SetActive(true);
                if (!doAnimation)
                    StartCoroutine(SecurityDoorAnimation());
                break;
            case 7:
                bank[5].gameObject.SetActive(false);
                bank[6].gameObject.SetActive(true);
                laserAndDoor.SetActive(false);
                OpenDoor.SetActive(true);
                if(!doDoorAnimation)
                    StartCoroutine(BankDoorAnimation());
                break;
        }
    }

    IEnumerator SecurityDoorAnimation()
    {
        character.canMove = false;
        yield return new WaitForSeconds(1.5f);
        securityDoor.SetTrigger("open");
        lasers.SetTrigger("open");
        doAnimation = true;   
        yield return new WaitForSeconds(11f);
        character.canMove = true;
    }

    IEnumerator BankDoorAnimation()
    {
        character.canMove = false;
        yield return new WaitForSeconds(1);
        bankDoor.SetTrigger("open");
        doDoorAnimation = true;
        yield return new WaitForSeconds(6f);
        character.canMove = true;
    }
    public void GetBank(int bank)
    {
        bankNumber = bank;
    }

}
