using System;
using System.Collections.Generic;
class List
{
    public static int Sum(List<int> myList){
        HashSet<int> myHashSet = new HashSet<int>();
        foreach(int i in myList){
            myHashSet.Add(i);
        }
        int sum = 0;
        foreach(int i in myHashSet){
            sum += i;
        }
        return sum;
    }
}