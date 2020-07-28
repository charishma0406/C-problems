using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.StringLeetCodeProblems
{
    public class Replace
    {
        public string Replc(string address)
        {
            string modified = address.Replace("1.1.1.1", "1[.]1[.]1[.]1");
            return modified;
        }
        
    }
}
