using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailFollow : MonoBehaviour
{
    public Vector2 player;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player, speed * Time.deltaTime);
    }
}
