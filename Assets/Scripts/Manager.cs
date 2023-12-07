using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]    
    private List<GameObject> sign;


    void Update()
    {
        foreach (GameObject obj in sign)
        {
            obj.transform.Rotate(0f, 90f * Time.deltaTime, 0f);
        }   
    }
}
