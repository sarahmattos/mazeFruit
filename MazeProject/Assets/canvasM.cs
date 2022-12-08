using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasM : MonoBehaviour
{
    public static canvasM instance;
    public GameObject btn;
    public GameObject btn2;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jogar()
    {
        GameObject.Find("teste").GetComponent<btnContinuarManager>().aparecerCtz();
    }
    public void sair()
    {
        Application.Quit();
    }

}
