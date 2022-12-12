using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatataController : MonoBehaviour
{
    public Batata batata;
    void Start()
    {
        batata = new Batata();
        //batata.Name= "Sarah";
        //batata.PowerUp(2);
        //batata.Save();
        batata.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
