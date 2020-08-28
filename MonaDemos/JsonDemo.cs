using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MonaDemos
{
    public class JsonDemo
    {

        public static void Run()
        {
            using (StreamReader sr = File.OpenText("json1.json"))
            {
                string jsonStr = sr.ReadToEnd();

                var jObject = JObject.Parse(jsonStr);
                

                // deserialize object step
                string targetStr = JsonConvert.SerializeObject(jObject);
                var updateJObjectDic = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string,string>>>>(targetStr);


                // update dic values

                List<Dictionary<string,string>> listObject = updateJObjectDic["UpdateData"];
                foreach (var itemDic in listObject)
                {
                    List<string> keys = new List<string>(itemDic.Keys);
                    foreach (string key in keys)
                    {
                        itemDic[key] = "123";
                    }
                }

                // serialize dic to JObject
                targetStr = JsonConvert.SerializeObject(updateJObjectDic);
                var res = JObject.Parse(targetStr);


                //other operation
                Console.ReadKey();







                Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>();

                keyValuePairs.Add("sleeve strategy code", true);
                keyValuePairs.Add("sleeve strategy name", true);



                








                Console.ReadKey();






                
            }
        }

        public static void JTokenDemo()
        {

        }
    }
}
