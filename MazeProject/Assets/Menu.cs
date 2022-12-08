using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static Menu instance;
    //public int btnContinuar;
    public bool continuar = false;
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    public void continuarTrue()
    {
        continuar = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
