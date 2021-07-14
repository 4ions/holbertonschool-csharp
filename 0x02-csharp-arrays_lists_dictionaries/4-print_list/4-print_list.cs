﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size){
        if (size < 0){
            Console.WriteLine("size cannot be negative");
            return null;
        }
        List<int> list = new List<int>();

        for (int i = 0; i < size; i++){
            list.Add(i);
        }
        Console.WriteLine(string.Join(" ", list));
        return list;
    }
}