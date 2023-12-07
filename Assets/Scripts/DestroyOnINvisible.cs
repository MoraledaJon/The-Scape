using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnINvisible : MonoBehaviour
{
    void OnBecameInvisible() {
         Destroy(gameObject);
     }
}
