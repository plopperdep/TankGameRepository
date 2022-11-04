using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnim : MonoBehaviour
{
    private Animator movement;

    void Start()
    {
        movement = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movement.SetBool("WalkBool", true);
        }
        else
        {
            movement.SetBool("WalkBool", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.SetBool("WalkBool", true);
        }
        else
        {
            movement.SetBool("WalkBool", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.SetBool("WalkBool", true);
        }
        else
        {
            movement.SetBool("WalkBool", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.SetBool("WalkBool", true);
        }
        else
        {
            movement.SetBool("WalkBool", false);
        }
    }
}