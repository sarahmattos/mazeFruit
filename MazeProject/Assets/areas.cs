using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areas : MonoBehaviour
{
    public static areas instance;
    public int frutas;
    private void Start()
    {
        
        instance = this;
    }
    void OnTriggerEnter2D(Collider2D other) //Make sure to put this out of Voids
    {
        if (other.gameObject.tag == "final")
        {
            GameObject.Find("teste").GetComponent<btnContinuarManager>().btnContinuar = 1;
            if (frutas == 3)
            {
                Interface.instance.HudON("O bem venceu");
            }
            else
            {
                Interface.instance.HudON("O mal venceu, frutas não coletadas!");
            }
            
        }
        if (other.gameObject.tag == "inicial")
        {
            timer.instance.tempoTotal =60f;
            timer.instance.inicio = true;
            Destroy(other.gameObject);
        }
    }
        
}
