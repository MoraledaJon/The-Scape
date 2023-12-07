using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HackStageManager : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private GameObject stage1;
    [SerializeField]
    private GameObject stage2;
    [SerializeField]
    private GameObject stage3;
    [SerializeField]
    private TextMeshProUGUI stageNumber;

    public LevelLoader LevelLoader;
    DontDestroy dontDestroy;

    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
    }

    public void NextStage(int stageNumber)
    {
  
        StartCoroutine(LoadNextStage(stageNumber));
        
    }
    
    
    IEnumerator LoadNextStage(int stage)
    {
        switch (stage)
        {
            case 1:
                yield return new WaitForSeconds(1f);

                anim.SetTrigger("Start");

                yield return new WaitForSeconds(1f);

                stage1.SetActive(false);

                yield return new WaitForSeconds(0.5f);

                stage2.SetActive(true);
                stageNumber.text = "2";

                anim.SetTrigger("End");
                break;
            case 2:
                yield return new WaitForSeconds(1f);

                anim.SetTrigger("Start");

                yield return new WaitForSeconds(1f);

                stage2.SetActive(false);

                yield return new WaitForSeconds(0.5f);

                stage3.SetActive(true);
                stageNumber.text = "3";

                anim.SetTrigger("End");
                break;
            case 3:
                yield return new WaitForSeconds(1f);

                dontDestroy.bankNumber++;
                LevelLoader.HackClear();

                break;

        }
        

    }
}
