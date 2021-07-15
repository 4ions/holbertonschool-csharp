using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList){
        
        int Sum = 0;

        foreach(int item in myLList){
            Sum = Sum + item;
        }

        return Sum;
    }
}
