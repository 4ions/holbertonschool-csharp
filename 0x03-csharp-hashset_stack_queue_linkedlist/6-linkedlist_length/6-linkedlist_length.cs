using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList){
        int sum = 0;
        foreach (int i in myLList){
            sum += 1;
        }
        return sum;
    }
}