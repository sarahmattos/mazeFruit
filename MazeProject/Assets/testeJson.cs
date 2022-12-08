using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class testeJson : MonoBehaviour
{
    public Jogador p;
    string caminho;
    public fabrivaJson fj;
    void Start()
    {
        //p = new Jogador();
        caminho = @"C:\Users\sarah\OneDrive\Documentos\GitHub\MazeProject\Assets\dados.json";
    }

    // Update is called once per frame
    public void enviarJson()
    {
        p.X = 2;
        p.Y = 5;
        p.Timer = 50;
        Debug.Log(caminho);
        Debug.Log(p.Y);
        fj.escreverJson(p, caminho);
    }
    public void recuperarJson()
    {
        Jogador pessoaJson = fabrivaJson.instance.lerJson(caminho);
        string dados = "Dados de Pessoa - Leitura de Arquivo JSON\n\n";
        dados = "dados: " + pessoaJson.X + pessoaJson.Y + pessoaJson.Timer;
        Debug.Log(dados);
    }
}
