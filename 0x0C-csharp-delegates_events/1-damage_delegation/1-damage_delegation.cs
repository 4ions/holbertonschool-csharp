using System;
///<summary>
///Player's CalculateHealth Delegate
///</summary>
delegate void CalculateHealth(float health);

///<summary>Player class</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Constructor for Player class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        
        this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary>Prints Player health.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>Calculates Player damage.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    ///<summary>Calculates Player healing.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0f;
            return;
        }
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }
}
