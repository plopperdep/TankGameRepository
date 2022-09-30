using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroller : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;

    public int movementSpeed;
    public int rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * movementSpeed * Time.deltaTime);


        barrelRotator.RotateAround(Vector3.forward, Input.GetAxisRaw("Vertical") * rotateSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
            b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * 10, ForceMode2D.Impulse);

        }
        
    }
}
