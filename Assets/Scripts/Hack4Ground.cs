using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack4Ground : MonoBehaviour
{
    private GameObject poop;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == this.gameObject)
                {
                    poop = transform.parent.GetChild(i + 1).gameObject;
                    poop.GetComponent<Animator>().SetTrigger("open");
                    break;
                }
            }
        }
        
    }
}
