using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HolyPlugy
{
    public class UniqueConstants
    {
        private List<String> uniqueItems;
        private static UniqueConstants instance = new UniqueConstants();

        private UniqueConstants()
        {
            init();
        }

        private void init()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("HolyGrailUniques.txt"));

            using (StreamReader inputStream = new StreamReader(assembly.GetManifestResourceStream(resourceName)))
            {

                try
                {
                    uniqueItems = new List<String>();
                    while (inputStream.Peek() >= 0)
                    {
                        String line = inputStream.ReadLine();

                        if(!string.IsNullOrEmpty(line))
                        {
                            uniqueItems.Add(line);
                        }
                    }
                }
                catch
                {

                }
            }
        }


        public static UniqueConstants getInstance()
        {
            return instance;
        }

        public List<String> getUniqueConstants()
        {
            return uniqueItems;
        }
		}
}
