using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileInteraction : MonoBehaviour
{
    [SerializeField]
    private bool isEnemy;
    [SerializeField]
    public float timeToDissapear;
    private float timer = 0;
    private void OnTriggerEnter(Collider col)
    {
        if(isEnemy)
        {
            switch (col.gameObject.tag)
            {
                case "wall":
                    Destroy(transform.gameObject);
                    break;
            }
        }
        else
        {
            switch (col.gameObject.tag)
            {
                case "wall":
                    Destroy(transform.gameObject);
                    break;
                case "proyectileHitable":
                    Destroy(col.gameObject);
                    Destroy(transform.gameObject);
                    break;
                case "shield":
                    Destroy(transform.gameObject);
                    break;
            }
        }
            
    }

    private void Update()
    {
        timeToDissapear -= Time.deltaTime;
        if(!isEnemy && timeToDissapear <= 0)
        {
            Destroy(transform.gameObject);  
        }
    }
}
