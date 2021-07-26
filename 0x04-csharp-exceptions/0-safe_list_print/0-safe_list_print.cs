using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n){
        int count = 0;
        try {
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(myList[i]);
                count++;

            }
        }
        catch {
            return count;
        }

        return count;
    }
}
