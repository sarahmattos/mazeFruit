using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatataController : MonoBehaviour
{
    public Batata batata;
    void Start()
    {
        batata = new Batata();
        batata.y1= 6f;
        batata.y2= 8f;
        batata.timer= 50f;
        batata.inicio= 1;
        batata.frutas= 2;
        batata.melancia= 1;
        batata.laranja= 1;
        batata.abacaxi= 0;
        batata.x1 = 10f;
        batata.x2= 2f;
        batata.Save();
        //batata.Load();
    }

    // Update is called once per frame
     public void Carregar()
    {
        batata.Load();
    }
}
