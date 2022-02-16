using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public class People
    {

        string name;
        int[] accountHistory;

        public People(string person)
        {
            string[] tmp = person.Split(',');
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == 0)
                {
                    name = tmp[i];
                }
                else
                    Int32.TryParse(Regex.Replace(tmp[i], "[^0-9/.]+", ""), out accountHistory[i - 1]);

            }


        }





    }
}
