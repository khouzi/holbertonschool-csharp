using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int len = 0;
        foreach( var element in myList){
            len++;
        }
        return len;
    }
}