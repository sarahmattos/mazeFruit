using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonDados : MonoBehaviour
{
    public static jsonDados instance;
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cidade { get; set; }

    void start(){
        instance = this;
    }
}
