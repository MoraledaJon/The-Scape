using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    { 
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
    }

}
