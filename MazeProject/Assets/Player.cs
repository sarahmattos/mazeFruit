using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int id;
    private Animator anim;

    float velocidade;

    void Start()
    {
        anim = GetComponent< Animator>();
        if(id == 1)
        {
             velocidade = 0.06f;
        }
        if (id == 0)
        {
            velocidade = 0.03f;
        }
    }
    void Update()
    {
        if (id == 0)
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
        if (id == 1)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector2(transform.position.x - velocidade, transform.position.y);
                anim.SetBool("e", true);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("e", false);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector2(transform.position.x + velocidade, transform.position.y);
                anim.SetBool("d", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("d", false);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + velocidade);
                anim.SetBool("b", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("b", false);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - velocidade);
                anim.SetBool("c", true);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                anim.SetBool("c", false);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other) //Make sure to put this out of Voids
    {
        if (other.gameObject.tag == "Player" && id == 0)
        {
            GameObject.Find("teste").GetComponent<btnContinuarManager>().btnContinuar = 1;
            Interface.instance.HudON("O mal venceu");
            Destroy(other.gameObject);

        }

    }
}
