using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public static timer instance;
    public float tempoTotal;
    public TMP_Text tempo;
    public bool inicio=false;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(inicio == true)
        {
            tempoTotal -= Time.deltaTime;
        }
        
        
        tempo.SetText(FormatarTempo((int)tempoTotal));
        if (tempoTotal <= 0 && inicio==true)
        {
            GameObject.Find("teste").GetComponent<btnContinuarManager>().btnContinuar = 1;
            Interface.instance.HudON("Você Perdeu");
        }
    }
    public string FormatarTempo(int val)
    {
        int Seg = val % 60;
        val /= 60;
        int Min = val % 60;
        val /= 60;
        int Hour = val % 24;
        return strzero(Hour) + ":" + strzero(Min) + ":" + strzero(Seg);
    }
    private string strzero(int val)
    {
        return (val < 10) ? "0" + val.ToString() : val.ToString(); ;
    }
}
