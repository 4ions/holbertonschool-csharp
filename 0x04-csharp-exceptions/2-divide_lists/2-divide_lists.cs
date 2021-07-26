using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength){
        List<int> result = new List<int>();
        int i = 0;
        for (; i < list2.Count; i++){
            try{
                result.Add(list1[i] / list2[i]);
            } catch {
                if (list2[i] == 0){

                    System.Console.WriteLine("Cannot divide by zero");
                }
                if (list1.Count != list2.Count){
                    System.Console.WriteLine("Out of range");
                }
                
                result.Add(0);
            }
        }

        return result;

    }
}
