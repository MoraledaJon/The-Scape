using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBuilding : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "building")
        {
            Destroy(other.gameObject);
        }
    }
}
