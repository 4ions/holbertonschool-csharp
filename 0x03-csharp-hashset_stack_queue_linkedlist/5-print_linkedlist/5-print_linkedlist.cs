using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size){
        LinkedList<int> list = new LinkedList<int>();

        if (size < 0){
            return new LinkedList<int>();
        }

        for (int i = 0; i < size; i++){
            list.AddLast(i);
        }
        foreach(int i in list){
            System.Console.WriteLine(i);
        }

        return list;
    }
}