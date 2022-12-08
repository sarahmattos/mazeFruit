using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Interface : MonoBehaviour
{
    public static Interface instance;
    public GameObject pauseUi;
    public TMP_Text textHud;
    public GameObject bnt;
    public GameObject bnt2;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R)) Retry();

        



    }
    public void Pause()
    {
        Time.timeScale = 0;
        HudON("Pausado");
        bnt.SetActive(true);
    }
    public void UnPause()
    {
        Time.timeScale = 1;
        pauseUi.SetActive(false);
        bnt.SetActive(false);
        bnt2.SetActive(true);
    }
    public void Retry()
    {
        SceneManager.LoadScene(1);
        pauseUi.SetActive(false);
    }
    public void HudON(string texto)
    {
        pauseUi.SetActive(true);
        textHud.SetText(texto);
        Time.timeScale = 0f;
        bnt2.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        //fabricaXml.instance.escreverXML();
    }

}
