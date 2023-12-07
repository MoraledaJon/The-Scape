using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack5WindowAnimation : MonoBehaviour
{
    public Material noWindowMaterial;
    private float timer = 0;
    public float randomMax;
    private Material actualMaterial;
    private float random;

    private void Start()
    {
        actualMaterial = GetComponent<MeshRenderer>().material;
        random = Random.Range(1, randomMax);
        StartCoroutine(ChangeMaterial());
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
    }
    IEnumerator ChangeMaterial()
    {
        while (true)
        {
            while (timer < random)
            {
                yield return 0;
            }
            transform.GetComponent<MeshRenderer>().material = noWindowMaterial;

            yield return new WaitForSeconds(4f);

            transform.GetComponent<MeshRenderer>().material = actualMaterial;

            timer = 0;
            random = Random.Range(1, randomMax);
        }

    }
}
