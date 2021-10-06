using System;
using System.Collections.Generic;
using System.Text;

namespace hometask7
{
    static class Task7
    {
        public static bool CsContain(this string word, string phrase)
        {
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = 0; i < word.Length - phrase.Length; i++)
            {
                for (int j = i; j < phrase.Length + i; j++)
                {
                    stringbuilder.Append(word[j]);
                }

                if (stringbuilder.ToString().ToLower() == phrase.ToLower())
                {
                    return true;
                }
                stringbuilder.Clear();
            }

            return false;
        }

    }


}