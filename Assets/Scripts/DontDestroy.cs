using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public int bankNumber;
    public Vector3 playerPosition;
    public Vector3 cameraPosition;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        playerPosition = Vector3.zero ;
        cameraPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
