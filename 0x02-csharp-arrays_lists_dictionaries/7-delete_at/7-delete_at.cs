using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index){

        if (index > myList.Count || index < 0)
        {
            System.Console.WriteLine("Index is out of range");
            return myList;
        }
        for(int i = index; i < myList.Count; i++){
            if (index == i)
                myList.Remove(myList[i]);
        }

        return myList;
    }
}
