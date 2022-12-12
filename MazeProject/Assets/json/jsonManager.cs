using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

public class jsonManager : MonoBehaviour
{
     JsonSerializer js;
    // Start is called before the first frame update
     public void escreverJson(jsonDados jD, String caminho)
        {
            js = new JsonSerializer();
            if (File.Exists(caminho)) File.Delete(caminho);
            StreamWriter sw = new StreamWriter(caminho);
            JsonWriter jw = new JsonTextWriter(sw);
            js.Serialize(jw, jD);
            jw.Close();
            sw.Close();
        }
         public jsonDados lerJson(String caminho)
        {
            JObject obj = null;
            JsonSerializer js = new JsonSerializer();
            if (File.Exists(caminho))
            {
                StreamReader reader = new StreamReader(caminho);
                JsonReader jr = new JsonTextReader(reader);
                obj = js.Deserialize(jr)as JObject;
                jr.Close();
                reader.Close();

            }
            String p = obj.ToString();
            return JsonConvert.DeserializeObject<jsonDados>(p);
        }
}
