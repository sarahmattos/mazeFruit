using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class Batata 

{
   private string path = @"C:\Users\sarah\OneDrive\Documentos\GitHub\mazeFruit\MazeProject\Assets\Batata.json";
   public string Name;
   public int x1;
   public int x2;

    public void PowerUp(int bonus){
        x1+=bonus;
    }

    public void Save(){
        var content = JsonUtility.ToJson(this,true);
        File.WriteAllText(path,content);
    }
    public void Load(){
        var content = File.ReadAllText(path);
        var p = JsonUtility.FromJson<Batata>(content);
        Name= p.Name;
        x1 = p.x1;
        x2= p.x2;
    }

}
