using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToLevel6Skip : MonoBehaviour
{
    public LevelLoader levelloader;

    public void PressSkipButton()
    {
        levelloader.LoadNextLevel();
    }
}
