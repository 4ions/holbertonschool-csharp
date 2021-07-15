using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n){
        if (myLList.Count <= 0 || n > myLList.Count){
            return 0;
        }else{
        int counter = 0;
        int value = 0;
        foreach(int i in myLList){
            if (counter == n){
                value = i;
            }
            counter++;
        }
        return value;
        }
    }
}
