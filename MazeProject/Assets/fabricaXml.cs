using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;

public class fabricaXml : MonoBehaviour
{
    public static fabricaXml instance;
    public Personagem p, p2;
    public void Start()
    {
        instance = this;
        //escreverXML();
        p = new Personagem();
    }
    private void Update()
    {
        if (Menu.instance.continuar == true)
        {
            mostrarInfo();
        }
    }
    public void escreverXML()
    {
        Debug.Log("escreveu dados: " + p2.X + " " + p2.Y);
        XmlTextWriter writer = new XmlTextWriter(@"C:\Users\sarah\OneDrive\Documentos\GitHub\mazeFruit\MazeProject\Assets\dadosXml.xml", null);
        writer.WriteStartDocument();
        writer.Formatting = Formatting.Indented;
        writer.WriteStartElement("Dados");
        writer.WriteStartElement("PERSONAGEM");
        writer.WriteElementString("X", p2.xS);
        writer.WriteElementString("Y", p2.yS);
        //writer.WriteElementString("X", "0");
        //writer.WriteElementString("Y", "0");
        writer.WriteElementString("Timer", p2.tS);
        writer.WriteElementString("Inicio", p2.Inicio.ToString());
        writer.WriteElementString("Frutas", p2.nFruta.ToString());
        writer.WriteElementString("Melancia", p2.Melacia.ToString());
        writer.WriteElementString("Laranja", p2.Laranja.ToString());
        writer.WriteElementString("Abacaxi", p2.Abacaxi.ToString());
        writer.WriteEndElement();
        writer.WriteFullEndElement();
        writer.Close();
    }
    public string lerXMLDeArquivo()
    {
        return System.IO.File.ReadAllText(@"C:\Users\sarah\OneDrive\Documentos\GitHub\mazeFruit\MazeProject\Assets\dadosXml.xml");
    }
    public string lerXMLDeArquivo(string caminho)
    {
        return System.IO.File.ReadAllText("@" + caminho);
    }
    public void mostrarInfo()
    {
        string info = lerXMLDeArquivo();
        converterXMLParaObjeto(info);
        Debug.Log(p.X);
        Debug.Log(p.Y);
        Debug.Log(p.Timer);
        p2.recuperarInfo();
        Menu.instance.continuar = false;
    }
    public void converterXMLParaObjeto(string xml)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(xml);
        MemoryStream stream = new MemoryStream(byteArray);
        XmlTextReader xtr = new XmlTextReader(stream);

        while (xtr.Read())
        {
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "X")
            {
                p.X = xtr.ReadElementContentAsFloat();
                
            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Y")
            {
                p.Y = xtr.ReadElementContentAsFloat();
            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Timer")
            {
                p.Timer = xtr.ReadElementContentAsFloat();

            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Inicio")
            {
                p.Inicio = xtr.ReadElementContentAsInt();

            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Frutas")
            {
                p.nFruta = xtr.ReadElementContentAsInt();

            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Melancia")
            {
                p.Melacia = xtr.ReadElementContentAsInt();

            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Laranja")
            {
                p.Laranja = xtr.ReadElementContentAsInt();

            }
            if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Abacaxi")
            {
                p.Abacaxi = xtr.ReadElementContentAsInt();

            }
        }
    }
}
