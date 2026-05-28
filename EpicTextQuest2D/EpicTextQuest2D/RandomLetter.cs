using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EpicTextQuest2D
{
    public class RandomLetter
    {
        public void RandomString(int num, ref string ret)
        {
            var chars = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю!@#!@#!@#!@#!@#!@#!@#!@#$&?*$&?*$&?*$&?*$&?*$&?*$&?*$&?*";
            var stringChars = new char[num];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            ret = Convert.ToString(finalString);
            
        }
    }
}
