using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light
{
    public GameObject obj { get; set; }
    public float random { get; set; }

    public Material actualMaterial { get; set; }
    public float timer { get; set; }

    public float timeOff { get; set; }
}
public class LightManager : MonoBehaviour
{
    [Range(0f, 30f)]
    public float RandomMax;
    [Range(2f, 30f)]
    public float RandomTimeOff;
    private List<Light> lights = new List<Light>();
    private GameObject[] lights_in_scene;
    [SerializeField]
    private  Material noWindowMaterial;
    [SerializeField]
    private Material redWindowMaterial;
    public bool isLastBoss = false;

    private float timer = 0;
    void Start()
    {
        lights_in_scene = GameObject.FindGameObjectsWithTag("light");
        foreach (GameObject objl in lights_in_scene)
        {
            lights.Add(new Light() { obj = objl,
                random = Random.Range(1, RandomMax),
                actualMaterial = objl.GetComponent<MeshRenderer>().material,
            timer = 0,
            timeOff = Random.Range(0,RandomTimeOff)});
        }
    }


    void Update()
    {
        if(isLastBoss)
        {
            foreach (Light light in lights)
            {
                StopAllCoroutines();
                StartCoroutine(RedWindow(light));
            }
        }
        else
        {
            foreach (Light light in lights)
            {
                light.timer += Time.deltaTime;
                if (light.random < light.timer)
                {
                    StartCoroutine(ChangeMaterial(light));
                }
            }
        }
    }

    IEnumerator ChangeMaterial(Light l)
    {
        l.obj.GetComponent<MeshRenderer>().material = noWindowMaterial;
        yield return new WaitForSeconds(l.timeOff);
        l.obj.GetComponent<MeshRenderer>().material = l.actualMaterial;
        l.timer = 0;
        l.random = Random.Range(1, RandomMax);
    }
    IEnumerator RedWindow(Light l)
    {
        l.obj.GetComponent<MeshRenderer>().material = redWindowMaterial;
        yield return 0;

    }
}
