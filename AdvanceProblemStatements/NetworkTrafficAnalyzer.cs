using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceProblemStatements
{
    public class NetworkTrafficAnalyzer
    {
       
        public void Analyze()
        {

            string filepath = @"C:\Users\Ramisettylokesh\OneDrive\Desktop\IPAddress.txt";

            if (File.Exists(filepath))
            {
                try
                {
                    List<string> l = new List<string>();

                    using (StreamReader sr = new StreamReader(filepath))
                    {


                        while (!sr.EndOfStream)
                        {
                            string content = sr.ReadLine();
                            l.Add(content);
                        }
                    }
                    Dictionary<string, int> d = new Dictionary<string, int>();
                    foreach (string i in l)
                    {
                        if (d.ContainsKey(i))
                        {
                            d[i]++;
                        }
                        else
                        {
                            d[i] = 1;
                        }
                    }

                    foreach (var k in d)
                    {
                        Console.WriteLine(k.Key + ": " + k.Value);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("file not exsist");
        }

    }
}
