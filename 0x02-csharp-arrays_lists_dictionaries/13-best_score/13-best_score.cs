using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList){

        int maxScore = 0;
        string key = "";

        if (myList.Count == 0){
            return "None";
        }
        
        foreach (KeyValuePair<string, int> entry in myList){
            if (maxScore <= entry.Value){
                maxScore = entry.Value;
                key = entry.Key;
            }
        }
        return key;
    }
}