using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack6AnimationEnd : MonoBehaviour
{
    private Animator anim;
    private Hack6AnimationEnd script;
    public bool animFinsh;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        script = GetComponent<Hack6AnimationEnd>();

    }

    // Update is called once per frame
    void Update()
    {
        if (animFinsh)
        {
            Destroy(anim);
            Destroy(script);
        }
            

    }
}
