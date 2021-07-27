using System;

namespace Enemies{
    ///<summary> public class zombie</summary>

    public class Zombie {

        ///<summary> public variable health </summary>
        public int health;

        ///<summary> public constructor: public Zombie() Initializes in 0 </summary>
        public Zombie(){
            health = 0;
        }     

        ///<summary> public constructor: public Zombie that recives value to set in health</summary>
        public Zombie(int value){

            if (value >= 0){
                health = value;
            }
            else{
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}