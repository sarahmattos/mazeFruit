using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnContinuarManager : MonoBehaviour
{
    
    public int btnContinuar;
    bool aux = true;
    void Start()
    {
        int numMenu = FindObjectsOfType<btnContinuarManager>().Length;
        if (numMenu != 1)
        {
            Destroy(this.gameObject);
        }
        // if more then one music player is in the scene
        //destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        /*
        int y = SceneManager.GetActiveScene().buildIndex;
        
        if (y == 0 && aux == true)
        {
            btn = GameObject.FindWithTag("btn");
            if (btnContinuar == 1)
            {
                btn.SetActive(false);
                aux = false;
            }
            else
            {
                btn.SetActive(true);
            }
        }
        if (y == 1)
        {
            aux = true;
        }
        */
        
    }
    public void aparecerCtz()
    {
            if (btnContinuar == 1)
            {
            Menu.instance.MainMenu();
            }
            else
            {
            canvasM.instance.btn.SetActive(true);
            canvasM.instance.btn2.SetActive(false);
            }
        
    }
}
