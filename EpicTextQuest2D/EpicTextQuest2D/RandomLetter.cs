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
//это понадобится потом, не забудь поменять переменные
//Task.Run(

//    async () => {

//        // while our task is not cancelled
//        while (!cancellationToken.IsCancellationRequested)
//        {
//            // perform our code
//            g.RandomString(6, ref ge);
//            Console.WriteLine($"rusto is a {ge}");
//            await Task.Delay(100);
//            Console.Clear();
//        }
//    }, cancellationToken);

//// while we havent requested a cancellation we loop
//while (!cancellationToken.IsCancellationRequested)
//{
//    // wait on reading a line
//    var escape = Console.ReadLine();

//    // if that line is quit we cancel the token
//    if (escape != null)
//        cancellationTokenSource.Cancel();
//}
