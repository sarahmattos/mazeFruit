using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonAtiv : MonoBehaviour
{
     public jsonDados p;
     public jsonManager fj;
    // Start is called before the first frame update
    void Start()
    {
            //p = new jsonDados();
            
            p.id = 1;
            p.nome = "Sarah";
            p.idade = 21;
            p.cidade = "Morro Azul";
            string caminho = @"C:\Users\sarah\OneDrive\Documentos\GitHub\mazeFruit\MazeProject\Assets\teste1.json";
            
            fj.escreverJson(p, caminho);

            jsonDados pessoaJson = fj.lerJson(caminho);
            string dados = "Dados de Pessoa - Leitura de Arquivo JSON\n\n";
            dados += "ID: " + pessoaJson.id + "\n";
            dados += "NOME: " + pessoaJson.nome + "\n";
            dados += "IDADE: " + pessoaJson.idade + "\n";
            dados += "CIDADE: " + pessoaJson.cidade ;
            Debug.Log(dados);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
