using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    private Proyectile proyectile1;
    private Proyectile proyectile2;
    private Proyectile proyectile3;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;


    private void Start()
    {
        proyectile1 = player1.GetComponent<Proyectile>();
        proyectile2 = player2.GetComponent<Proyectile>();
        proyectile3 = player3.GetComponent<Proyectile>();
    }

    private void Update()
    {
        if(proyectile1.isAutoMode)
        {
            proyectile2.isAutoMode = true;
            proyectile3.isAutoMode = true;
        }
        else
        {
            proyectile2.isAutoMode = false;
            proyectile3.isAutoMode = false;
        }

        if(proyectile2.isAutoMode && player1 == null)
        {
            proyectile3.isAutoMode = true;
        }
        else if ( !proyectile2.isAutoMode && player2 == null)
        {
            proyectile3.isAutoMode = false;
        }




    }
}
