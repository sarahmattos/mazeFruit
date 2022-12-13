using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatataController : MonoBehaviour
{
    public Batata batata;
    public Personagem p2;
    public Player pa;
    void Start()
    {
        batata = new Batata();
        //Carregar();
    }
    
     public void Carregar()
    {
        batata.Load();
        p2.atualizarJson(batata.x1, batata.y1, batata.timer, batata.inicio, batata.frutas, batata.melancia, batata.laranja, batata.abacaxi);
        pa.atualizarJson(batata.x2,batata.y2);
    }
    public void Salvar()
    {   
         batata.x1 = p2.xx;
         batata.y1 = p2.yy;
         batata.timer = p2.tt;
         batata.inicio = p2.Inicio;
         batata.frutas = p2.nFruta;
         batata.melancia= p2.Melacia;
         batata.laranja= p2.Laranja;
         batata.abacaxi= p2.Abacaxi;
         batata.x2 =pa.xx;
         batata.y2 =pa.yy;
         batata.Save();
    }
    
    void OnApplicationQuit()
    {
        Salvar();
    }
}
