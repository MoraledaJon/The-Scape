using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerCollider : MonoBehaviour
{
    public Manager manager;
    public LevelLoader LevelLoader;
    public TextMeshProUGUI interactionText;
    private bool isButtonPressed;
    public Camera cam;
    private int moneyCount = 0;
    public Transform camera1;
    public GameObject toCarGame;
    public Animator circleAnimator;
    private Animator bankCircle;
    public Animator bankCameraAnimator;
    public Animator money1Animator;
    public Animator money2Animator;
    public Animator money3Animator;
    public Animator money4Animator;


    DontDestroy dontDestroy;
    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
    }

    public void Interaction(InputAction.CallbackContext context)
    {
        isButtonPressed = context.ReadValueAsButton();
    }

    private void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "bank":
                circleAnimator.SetTrigger("show");
                break;
            case "atm1":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "atm2":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "atm3":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "atm4":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "atm5":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "atm6":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
            case "bankCameraChange":
                bankCameraAnimator.SetTrigger("toMoney");
                break;
            case "money1":
                money1Animator.SetTrigger("show");
                break;
            case "money2":
                money2Animator.SetTrigger("show");
                break;
            case "money3":
                money3Animator.SetTrigger("show");
                break;
            case "money4":
                money4Animator.SetTrigger("show");
                break;
            case "toCarGame":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("show");
                break;
        }
    }


    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.tag)
        {
            case "bank":
                if(isButtonPressed)
                {
                    circleAnimator.SetTrigger("notshow");
                    LevelLoader.LoadBankInside();
                }
                break;
            case "atm1":
                if(isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(1);
                }
                break;
            case "atm2":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(2);
                }
                break;
            case "atm3":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(3);
                }
                break;
            case "atm4":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(4);
                }
                break;
            case "atm5":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(5);
                }
                break;
            case "atm6":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    dontDestroy.playerPosition = transform.position;
                    dontDestroy.cameraPosition = cam.transform.position;
                    LevelLoader.ToHackGame(6);
                }
                break;
            case "money1":
                if (isButtonPressed)
                {
                    money1Animator.SetTrigger("notshow");
                    col.gameObject.SetActive(false);
                    moneyCount++;
                    if (moneyCount == 4)
                    {
                        toCarGame.SetActive(true);
                    }
                }
                break;
            case "money2":
                if (isButtonPressed)
                {
                    money2Animator.SetTrigger("notshow");
                    col.gameObject.SetActive(false);
                    moneyCount++;
                    if (moneyCount == 4)
                    {
                        toCarGame.SetActive(true);
                    }
                }
                break;
            case "money3":
                if (isButtonPressed)
                {
                    money3Animator.SetTrigger("notshow");
                    col.gameObject.SetActive(false);
                    moneyCount++;
                    if (moneyCount == 4)
                    {
                        toCarGame.SetActive(true);
                    }
                }
                break;
            case "money4":
                if (isButtonPressed)
                {
                    money4Animator.SetTrigger("notshow");
                    col.gameObject.SetActive(false);
                    moneyCount++;
                    if (moneyCount == 4)
                    {
                        toCarGame.SetActive(true);
                    }
                }
                break;
            case "toCarGame":
                if (isButtonPressed)
                {
                    bankCircle.SetTrigger("notshow");
                    LevelLoader.LoadPreRaceGame();
                }
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        switch(col.gameObject.tag)
        {
            case "bank":
                circleAnimator.SetTrigger("notshow");
                break;
            case "atm1":
                bankCircle.SetTrigger("notshow");
                break;
            case "atm2":
                bankCircle.SetTrigger("notshow");
                break;
            case "atm3":
                bankCircle.SetTrigger("notshow");
                break;
            case "atm4":
                bankCircle.SetTrigger("notshow");
                break;
            case "atm5":
                bankCircle.SetTrigger("notshow");
                break;
            case "atm6":
                bankCircle.SetTrigger("notshow");
                break;
            case "bankCameraChange":
                bankCameraAnimator.SetTrigger("toBank");
                break;
            case "money1":
                money1Animator.SetTrigger("notshow");
                break;
            case "money2":
                money2Animator.SetTrigger("notshow");
                break;
            case "money3":
                money3Animator.SetTrigger("notshow");
                break;
            case "money4":
                money4Animator.SetTrigger("notshow");
                break;
            case "toCarGame":
                bankCircle = GameObject.Find("CircleButton").GetComponent<Animator>();
                bankCircle.SetTrigger("notshow");
                break;
        }
    }
}
