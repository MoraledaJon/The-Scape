using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
public class TitleScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject play;
    [SerializeField]
    private GameObject exit;
    [SerializeField]
    private GameObject playArrow;
    [SerializeField]
    private GameObject exitArrow;
    [SerializeField]
    private PlayableDirector director;
    [SerializeField]
    private Animator canvasAnimation2;


    private void Update()
    {
        if(EventSystem.current.currentSelectedGameObject == play)
        {
            play.transform.localScale = new Vector3(1.5f,1.5f, 1.5f);
            playArrow.SetActive(true);
            exit.transform.localScale = new Vector3(1, 1, 1);
            exitArrow.SetActive(false);
        }
        else if(EventSystem.current.currentSelectedGameObject == exit)
        {
            exit.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            exitArrow.SetActive(true);
            play.transform.localScale = new Vector3(1, 1, 1);
            playArrow.SetActive(false);
        }
    }

    public void PlayGame()
    {
        canvasAnimation2.SetTrigger("open");

        director.Play();
    }

    public void ExitGame()
    {
        
    }
}
