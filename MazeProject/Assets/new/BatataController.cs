using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatataController : MonoBehaviour
{
    public Batata batata;
    void Start()
    {
        batata = new Batata();
        /*batata.y1= 6f;
        batata.y2= 8f;
        batata.timer= 50f;
        batata.inicio= 1;
        batata.frutas= 2;
        batata.melancia= 1;
        batata.laranja= 1;
        batata.abacaxi= 0;
        batata.x1 = 10f;
        batata.x2= 2f;
       */
        //batata.Load();
    }
    public void Update(){

    }
    // Update is called once per frame
     public void Carregar()
    {
        batata.Load();
    }
    public void Salvar()
    {   
         batata.x1 = batata.p2.xx;
         batata.y1 = batata.p2.yy;
         batata.timer = batata.p2.tt;
         batata.inicio = batata.p2.Inicio;
         batata.frutas = batata.p2.nFruta;
         batata.melancia= batata.p2.Melacia;
         batata.laranja= batata.p2.Laranja;
         batata.abacaxi= batata.p2.Abacaxi;
         batata.x2 =batata.pa.xx;
         batata.y2 =batata.pa.yy;
         batata.Save();
    }
    public void Atualizar()
    {
        
    }
}
