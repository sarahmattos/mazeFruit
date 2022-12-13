using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public GameObject melanciaGO;
    public GameObject laranjaGO;
    public GameObject abacaxiGO;

    public static Personagem instance;
    public float X { get; set; }
    public float Y { get; set; }
    public float X2 { get; set; }
    public float Y2 { get; set; }
    public float Timer { get; set; }
    public int Inicio { get; set; }
    public int Melacia { get; set; }
    public int Abacaxi { get; set; }
    public int Laranja { get; set; }

    public int nFruta;

    public Vector3 novaPosicao2;
    public string xS, yS, tS;
    public float xx, yy, tt;
    public TMP_Text tFruta;
    public bool entra = true;
    public float temp = 1f;
    public Player pa;

    void start()
    {
        instance = this;
       
    }
    public void recuperarInfo()
    {
        Vector3 novaPosicao = transform.position;
        novaPosicao.x = fabricaXml.instance.p.X;
        novaPosicao.y = fabricaXml.instance.p.Y;
        transform.position = novaPosicao;
        timer.instance.tempoTotal = fabricaXml.instance.p.Timer;
        if (fabricaXml.instance.p.Inicio == 1)
        {
            timer.instance.inicio = true;
        }
        nFruta= fabricaXml.instance.p.nFruta;
        if (fabricaXml.instance.p.Melacia == 1) Destroy(melanciaGO);
        if (fabricaXml.instance.p.Abacaxi == 1) Destroy(abacaxiGO);
        if (fabricaXml.instance.p.Laranja == 1) Destroy(laranjaGO);
        Melacia = fabricaXml.instance.p.Melacia;
        Laranja = fabricaXml.instance.p.Laranja;
        Abacaxi = fabricaXml.instance.p.Abacaxi;
        pa.recuperaP2();
    }
    private void Update()
    {
        
        tFruta.SetText(nFruta.ToString());
        areas.instance.frutas = nFruta;
        novaPosicao2 = transform.position;
        xS = Mathf.Round(novaPosicao2.x).ToString();
        yS = Mathf.Round(novaPosicao2.y).ToString();
        xx = Mathf.Round(novaPosicao2.x);
        yy = Mathf.Round(novaPosicao2.y);
        tt = timer.instance.tempoTotal;
        tS = Mathf.Round(timer.instance.tempoTotal).ToString();
        if (timer.instance.inicio == true)
        {
            Inicio = 1;
        }
        else
        {
            Inicio = 0;
        }
        if (entra == false)
        {
            temp -= Time.deltaTime;
        }
        if (temp<=0){
            entra = true;
            temp = 1f;
        }
        
    }
    public void atualizarJson(float x , float y, float t, int i, int n, int m, int l , int a){
        Vector3 novaPosicao3 = transform.position;
        novaPosicao3.x = x;
        novaPosicao3.y = y;
        transform.position = novaPosicao3;
        timer.instance.tempoTotal =t;
        if(i==1){
            timer.instance.inicio = true;
        }
        nFruta = n;
        Melacia =m;
        Laranja = l;
        Abacaxi = a;
        if (Melacia == 1) Destroy(melanciaGO);
        if (Abacaxi == 1) Destroy(abacaxiGO);
        if (Laranja == 1) Destroy(laranjaGO);
    }
    void OnTriggerEnter2D(Collider2D other) //Make sure to put this out of Voids
    {
       
        if (other.gameObject.tag == "Fruta"&& entra==true)
        {
            Destroy(other.gameObject);
            nFruta++;
            entra = false;
            if (other.gameObject.layer==6) Melacia = 1;
            if (other.gameObject.layer == 7) Laranja = 1;
            if (other.gameObject.layer == 8) Abacaxi = 1;
        }

    }
}
