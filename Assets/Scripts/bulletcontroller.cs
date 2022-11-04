using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bulletcontroller : MonoBehaviour
{
    float bulletTtl = 10;

    private bool canParticle;

    void Update()
    {
        bulletTtl -= Time.deltaTime;
        if (bulletTtl <= 0)
        {
            Invoke("FAck", 1f);
        }

        if (GetComponent<ParticleSystem>().isPlaying == false && canParticle)
        {
            Destroy(gameObject);
            canParticle = false;
            GameObject.Find("TurnManager").GetComponent<TurnManager>().WisselBeurt();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<ParticleSystem>().Play();
        canParticle = true;

        if (collision.transform.CompareTag("Tank1"))
        {
            GameObject.Find("Canvas").GetComponent<Score>().AddP2Score();
        }
        GetComponent<SpriteRenderer>().enabled = false;
        if (collision.transform.CompareTag("Tank2"))
        {
            GameObject.Find("Canvas").GetComponent<Score>().AddP1Score();
        }
        GetComponent<SpriteRenderer>().enabled = false;
    }
    void FAck()
    {
        Destroy(gameObject);
    }
}
