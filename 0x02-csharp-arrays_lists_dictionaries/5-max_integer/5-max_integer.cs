﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList){
        if (myList == null){
            return -1;
        }
        int max = 0;
        for (int i = 0; i < myList.Count; i++){
            if (max < myList[i]){
                max = myList[i];

            }
        }
        return max;
    }
}