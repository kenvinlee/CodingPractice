using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class StringAlgs
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        char[] sCharArray;

        public StringAlgs()
        {

        }

        public Dictionary<char, int> hashString(String s)
        {
            // clear the dictionary - you want a new charCount for every string
            charCount = new Dictionary<char, int>();
            sCharArray = s.ToCharArray();

            // store values in a dictionary to keep track of occurrences
            // you can use a 2 row array to do this too, but it's doesn't actually have a runtime benefit
            // since it requires you to count the unique characters first
            for (int i = 0; i < sCharArray.Length; i++)
            {
                if (charCount.ContainsKey(sCharArray[i]))
                    charCount[sCharArray[i]]++;
                else
                    charCount.Add(sCharArray[i], 1);
            }

            return charCount;
        }

        public Boolean isUniqueChars(String s)
        {
            sCharArray = s.ToCharArray();

            charCount = hashString(s);

            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                if (kvp.Value > 1)
                    return false;
            }

            return true;
        }

        public String reverseString(String s)
        {
            sCharArray = s.ToCharArray();
            char temp;

            if (s.Length < 2)
                return s;

            for (int i = 0, count = sCharArray.Length - 1; i < count; i++, count--)
            {
                temp = sCharArray[i];
                sCharArray[i] = sCharArray[count];
                sCharArray[count] = temp;
            }

            s = new String(sCharArray);
            return s;
        }

        public String removeDupes(String s)
        {
            char temp;

            if (s.Length < 2)
            {
                return s;
            }

            for (int i = 0; i < s.Length; i++)
            {
                temp = s.ElementAt(i);

                for (int j = i+1; j < s.Length; j++)
                { 
                    if (temp == s.ElementAt(j))
                    {
                        s = s.Remove(j, 1);
                        j--;
                    }
                }
            }

            return s;
        }

        public String memeify(String s)
        {
            String meme = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    meme = meme + s.Substring(i, 1).ToLower();
                else
                    meme = meme + s.Substring(i, 1).ToUpper();
            }

            return meme;
        }

        public Boolean isAnagram(String s1, String s2)
        {
            bool isAnagram = true;

            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> dic1 = hashString(s1);
            Dictionary<char, int> dic2 = hashString(s2);

            foreach (KeyValuePair<char, int> kvp in dic1)
            {
                if (dic2.ContainsKey(kvp.Key))
                {
                    if (dic2[kvp.Key] == kvp.Value)
                    {
                        isAnagram = false;
                    }
                }
                else
                {
                    isAnagram = false;
                }
            }
            
            return isAnagram;
        }
    }
}
