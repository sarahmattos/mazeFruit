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
            if (frutas == 3)
            {
                Interface.instance.HudON("Você Venceu");
            }
            else
            {
                Interface.instance.HudON("Você não coletou as 3 frutas!");
            }
            
        }
        if (other.gameObject.tag == "inicial")
        {
            timer.instance.tempoTotal =90f;
            timer.instance.inicio = true;
            Destroy(other.gameObject);
        }
    }
        
}
