using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HolyPlugy
{
    public class SetConstants
    {
		private List<String> setItems;
        private static SetConstants instance = new SetConstants();

        private SetConstants()
        {
            init();
        }

        private void init()
        {
            

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("HolyGrailSets.txt"));

            using (StreamReader inputStream = new StreamReader(assembly.GetManifestResourceStream(resourceName)))
            {
                try
                {
                    setItems = new List<String>();
                    while (inputStream.Peek() >= 0)
                    {
                        String line = inputStream.ReadLine();

                        if (!string.IsNullOrEmpty(line))
                        {
                            setItems.Add(line);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static SetConstants getInstance()
        {
            return instance;
        }

        public List<String> getSetConstants()
        {
            return setItems;
        }
    }
}
