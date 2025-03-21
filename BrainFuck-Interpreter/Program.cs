using System;
using System.Collections.Generic;

namespace Program
{
    public class Program
    {
        byte[] memory = new byte[30000];
        int pointer = 0;
        Stack<int> loopStack = new Stack<int>();
        Dictionary<int, int> loopMap = new Dictionary<int, int>();
    }
}