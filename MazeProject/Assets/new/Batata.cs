using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class Batata 

{
   private string path = @"C:\Users\sarah\OneDrive\Documentos\GitHub\mazeFruit\MazeProject\Assets\Batata.json";
   public float x1, x2, y1, y2, timer;
   public int inicio, frutas, melancia, laranja, abacaxi; 


    public void Save(){
        var content = JsonUtility.ToJson(this,true);
        File.WriteAllText(path,content);
    }
    public void Load(){
        var content = File.ReadAllText(path);
        var p = JsonUtility.FromJson<Batata>(content);
        y1= p.y1;
        y2= p.y2;
        timer= p.timer;
        inicio= p.inicio;
        frutas= p.frutas;
        melancia= p.melancia;
        laranja= p.laranja;
        abacaxi= p.abacaxi;
        x1 = p.x1;
        x2= p.x2;
    }

}
