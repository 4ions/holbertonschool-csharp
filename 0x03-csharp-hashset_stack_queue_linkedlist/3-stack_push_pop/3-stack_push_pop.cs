using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search){

        System.Console.WriteLine($"Number of items: {aStack.Count}");

        
        if (aStack.Count <= 0){
            System.Console.WriteLine("Stack is empty");
        }else {
            System.Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        
        System.Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        if (aStack.Contains(search)){
            while (aStack.Contains(search))
                aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}