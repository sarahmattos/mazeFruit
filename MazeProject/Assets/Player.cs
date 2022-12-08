using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    float velocidade = 0.06f;

    void Start()
    {
        anim = GetComponent< Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - velocidade, transform.position.y);
            anim.SetBool("e", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("e", false);
        }

         if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + velocidade, transform.position.y);
            anim.SetBool("d", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("d", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + velocidade);
            anim.SetBool("b", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("b", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - velocidade);
            anim.SetBool("c", true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("c", false);
        }

    }
   
}
