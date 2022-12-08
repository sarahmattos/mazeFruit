using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

public class fabrivaJson : MonoBehaviour
{
    public static fabrivaJson instance;
    public Jogador p2;
    String caminho;
    Jogador p;
    void Start()
    {
        p = new Jogador();

      
    }
    public void enviarJson()
    {
        p.X = p2.xS;
        p.Y = p2.yS;
        p.Timer = p2.tS;
        caminho = @"C:\Users\sarah\OneDrive\Documentos\GitHub\MazeProject\Assets\dados.json";
       escreverJson(p, caminho);
    }
    public void recuperarJson(){
        Jogador pessoaJson = lerJson(caminho);
        p2.X = pessoaJson.X;
        p2.Y = pessoaJson.Y;
        p2.Timer = pessoaJson.Timer;
        p2.carregaInfo();
    }
    void start()
    {
        instance = this;
    }
public void escreverJson(Jogador pessoa, String caminho)
{
    JsonSerializer js = new JsonSerializer();
    if (File.Exists(caminho)) File.Delete(caminho);
    StreamWriter sw = new StreamWriter(caminho);
    JsonWriter jw = new JsonTextWriter(sw);
    js.Serialize(jw, pessoa);
    jw.Close();
    sw.Close();
}
    public Jogador lerJson(String caminho)
    {
        JObject obj = null;
        JsonSerializer js = new JsonSerializer();
        if (File.Exists(caminho))
        {
            StreamReader reader = new StreamReader(caminho);
            JsonReader jr = new JsonTextReader(reader);
            obj = js.Deserialize(jr) as JObject;
            jr.Close();
            reader.Close();

        }
        String p = obj.ToString();
        return JsonConvert.DeserializeObject<Jogador>(p);
    }
}
