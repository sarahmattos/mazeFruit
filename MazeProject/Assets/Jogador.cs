using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Timer { get; set; }
    public int Inicio { get; set; }
    public int Melacia { get; set; }
    public int Abacaxi { get; set; }
    public int Laranja { get; set; }

    public int nFruta;

   
    public float xS, yS, tS;

    Jogador p;
    public Jogador p2;
    string caminho;
    fabrivaJson fj;
    void Start()
    {
        p = new Jogador();
        fj = new fabrivaJson();
    }
    public void enviarJson()
    {
       // p.X = p2.xS;
          p2.X = 2;
          p2.Y = 5;
          p2.Timer = 50;
        //p.Y = p2.yS;
        //p.Timer = p2.tS;
        caminho = @"C:\Users\sarah\OneDrive\Documentos\GitHub\MazeProject\Assets\dados.json";
        
        fj.escreverJson(p2, caminho);
    }
    public void recuperarJson()
    {
        Jogador pessoaJson = fj.lerJson(caminho);
        string dados = "Dados de Pessoa - Leitura de Arquivo JSON\n\n";
        // p2.X = pessoaJson.X;
        //p2.Y = pessoaJson.Y;
        // p2.Timer = pessoaJson.Timer;
        dados = "dados: "+pessoaJson.X + pessoaJson.Y + pessoaJson.Timer;
        //p2.carregaInfo();
        Debug.Log(dados);
    }

    void Update()
    {
        /*
        Vector3 pos;
        pos = transform.position;
        xS = Mathf.Round(pos.x);
        yS = Mathf.Round(pos.y);
        tS = Mathf.Round(timer.instance.tempoTotal);

        */
    }
    public void carregaInfo()
    {
        Vector3 novaPosicao = transform.position;
        novaPosicao.x = X;
        novaPosicao.y = Y;
        transform.position = novaPosicao;
        timer.instance.tempoTotal = Timer;
    }
}
