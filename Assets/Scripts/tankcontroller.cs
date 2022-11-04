using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tankcontroller : MonoBehaviour
{
    public Animator movement;
    public Text Shootingpower;
    public int PlayerNumber;
    public float moveSpeed;
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;
    bool isAanDeBeurt = false;
    

    
    public int rotateSpeed;
    public int shootingForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAanDeBeurt == true)
        {
     
            
            
            if (PlayerNumber == 1)
            {
                barrelRotator.RotateAround(Vector3.forward, Input.GetAxisRaw("Vertical") * rotateSpeed * Time.deltaTime);
            }
            if (PlayerNumber == 2)
            {
                barrelRotator.RotateAround(Vector3.forward, Input.GetAxisRaw("Vertical") * -rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * shootingForce, ForceMode2D.Impulse);

                if (PlayerNumber == 1)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * 10 * rotateSpeed);
                }
                if (PlayerNumber == 2)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * 10 * -rotateSpeed);
                }


            }
            if (PlayerNumber == 1) { }

            if(Input.GetKeyDown(KeyCode.O))
            {
                IncreasePower();

            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                DecreasePower();

            }

            transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                movement.SetBool("WalkBool", true);
            }
            else
            {
                movement.SetBool("WalkBool", false);
            }

            Shootingpower.text = shootingForce.ToString();

        }

    }

    void WisselBeurt()
    {
        GameObject.Find("TurnManager").GetComponent<TurnManager>().WisselBeurt();
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

    public void IncreasePower()
    {
        shootingForce++;
    }

    public void DecreasePower()
    {
        shootingForce--;
    }
}