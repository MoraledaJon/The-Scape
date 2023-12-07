using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShield : MonoBehaviour
{

    public List<GameObject> bots;
    bool isBotAlive;
    public ParticleSystem deadEffect;

    void Update()
    {
        isBotAlive = false;
        foreach(GameObject bot in bots)
        {
            if(bot.active == true)
            {
                isBotAlive = true;
                break;
            }
        }
        if(!isBotAlive)
        {
            StartCoroutine(ShieldBroken());
        }
    }

    IEnumerator ShieldBroken()
    {

        deadEffect.Play();
        transform.gameObject.GetComponent<Renderer>().enabled = false;

        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }
}
