using System;

namespace _7_islower
{
    class Character
    {
        public static bool IsLower(char c){
            string upper = "aabcdefghijklmnopqrstuvwxyz";
            if (upper.Contains(c)){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
