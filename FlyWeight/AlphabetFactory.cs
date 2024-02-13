using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{

    public static class AlphabetFactory
    {
        static Dictionary<string, Alphabet> dictionary;
        static AlphabetFactory()
        {
            dictionary = new Dictionary<string, Alphabet>();
        }
        public static  Alphabet GetAlpha(string key)
        {
            if (!dictionary.ContainsKey(key))
            {
                Alphabet alphabet = null;

                    switch (key)
                    {
                        case "A":
                            alphabet = new AAlphabet();
                            break;
                        case "B":
                            alphabet = new BAlphabet();
                            break;
                    }

                dictionary[key] = alphabet;
            }
            return dictionary[key];
        }
    }
}

