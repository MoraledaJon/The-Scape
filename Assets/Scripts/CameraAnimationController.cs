using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CameraAnimationController : MonoBehaviour
{
    private PlayableDirector director;

    private void Start()
    {
        director = GetComponent<PlayableDirector>();
    }
    public void StopAnimation()
    {
        director.Pause();
    }
    public void PlayAnimation()
    {
        director.Play();
    }
}
