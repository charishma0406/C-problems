using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProject.StringLeetCodeProblems
{
    public class Paranthesis
    {
        public bool Paren(string s)
        {
            //create a stack
            Stack<char> st = new Stack<char>();

            //iterating each and every element in the stack
            for(int i=0;i<s.Length;i++)
            {
                //if the element in the string is open paranthesis 
                if (s[i] == '('|| s[i] == '{'|| s[i] == '[' )
                {
                    //pushing the open paranthesis to stack
                    st.Push(s[i]);
                }
                //else if element in the string contains closed parenthesis and string is not empty and top element in the stack is open parenthesis of the same brackets
                else if(s[i]==')' && st.Count! ==0 && st.Peek()=='(')
                {
                    //remove the frst element
                    st.Pop();
                }
                //else if element in the string contains closed parenthesis and string is not empty and top element in the stack is open parenthesis of the same brackets
                else if (s[i]=='}'&& st.Count! ==0 &&st.Peek()=='{')
                {

                    //remove the frst element
                    st.Pop();
                }
                //else if element in the string contains closed parenthesis and string is not empty and top element in the stack is open parenthesis of the same brackets
                else if (s[i] == ']' && st.Count! == 0 && st.Peek() == '[')
                {

                    //remove the frst element
                    st.Pop();
                }
                //else return false
                else
                {
                    return false;
             
                }
                
            }
            //return the stack is equal to 0
            return st.Count==0;
            
        }
    }
}
