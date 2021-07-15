using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index){

        int counter = 0;
        LinkedListNode<int> current = myLList.First;

        while(current != null){
            if (counter == index){
                myLList.Remove(current);
            }
            counter++;
            current = current.Next;
        }
    }
}
