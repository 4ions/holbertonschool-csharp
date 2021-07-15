using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList){
        
        List<bool> boolList = new List<bool>();
        foreach (int item in myList){
            if (item % 2 == 0){
                boolList.Add(true);
            }
            else {
                boolList.Add(false);
            }
        }

        return boolList;
    }
}
