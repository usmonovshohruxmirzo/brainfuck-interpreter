using System;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        public void Execute(string code)
        {
            byte[] memory = new byte[30_000];
            int pointer = 0;
            Stack<int> loopStack = new Stack<int>();
            Dictionary<int, int> loopMap = new Dictionary<int, int>();

            Stack<int> loopStartStack = new Stack<int>();
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '[') loopStartStack.Push(i);
                else if (code[i] == ']')
                {
                    if (loopStartStack.Count == 0) throw new Exception("Unmatched ] found.");
                    int start = loopStartStack.Pop();
                    loopMap[start] = i;
                    loopMap[i] = start;
                }
            }

            if (loopStartStack.Count == 0) throw new Exception("Unmatched ] found.");


        }
    }
}