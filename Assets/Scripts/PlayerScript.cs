using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int spelerNummer;
    
    bool isAanDeBeurt = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAanDeBeurt == true)
        {
            Invoke("WisselBeurt", 0.1f);
        }
    }
    void WisselBeurt()
    {
        GameObject.Find("GameManager").GetComponent<TurnManager>().WisselBeurt();
    }

    public void ZetActief(bool b)
    {
        if (b == true)
        {
            isAanDeBeurt = true;

            
        }
        else
        {
            isAanDeBeurt = false;
           
        }
    }
}
