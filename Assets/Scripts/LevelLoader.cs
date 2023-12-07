using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.InputSystem;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    [SerializeField]
    private PlayableDirector director;

    public void LoadBankInside()
    {
        StartCoroutine(LoadBankLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreRaceGame()
    {
        StartCoroutine(PreRace());
    }

    IEnumerator PreRace()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);

    }

    public void ToMainGame()
    {
        StartCoroutine(MainGameCoroutine());
    }

    IEnumerator MainGameCoroutine()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("MainGame");
    }

    public void ReloadGame()
    {
        StartCoroutine(ReloadGameCor());
    }

    IEnumerator ReloadGameCor()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void RestartRace()
    {
        StartCoroutine(StartRaceCoroutine());
    }

    IEnumerator StartRaceCoroutine()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator LoadBankLevel(int levelIndex)
    {
        director.Play();

        yield return new WaitForSeconds(7f);

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);

    }

    public void EndGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));

    }

    public void ToHackGame(int hackNumber)
    {
        switch (hackNumber)
        {
            case 1:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber));
                break;
            case 2:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber + 1));
                break;
            case 3:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber + 1));
                break;
            case 4:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber + 1));
                break;
            case 5:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber + 1));
                break;
            case 6:
                StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + hackNumber + 1));
                break;
        }
    }

    public void HackGameOver()
    {
        StartCoroutine(LoadBank()); 
    }

    public void HackClear()
    {
        StartCoroutine(LoadBank());
    }
   
    IEnumerator LoadBank()
    {
        yield return new WaitForSeconds(1f);

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Bank");

    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);

    }

    public void Restart(InputAction.CallbackContext context)
    {
        ReloadGame();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NextGame()
    {
        LoadNextLevel();
    }
}
