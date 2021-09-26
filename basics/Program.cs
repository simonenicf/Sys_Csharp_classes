using System;

namespace basics
{
    class Program
    {
        static void Main()
        {
            // create my enemy's and towers
            Goblin hobgoblin = new Goblin(20);
            BaseTower newTower = new BaseTower();
            
            // set varibale's value for future use
            int health = hobgoblin.GetHealth();
            int damage = newTower.damage;

            // writes out the damage the hobgoblin takes and current health to console
            Console.WriteLine("Tower sees hobgoblin and does " + damage + " damage");
            health = hobgoblin.getDamage(health, damage);
            Console.WriteLine("hobgoblins health is " + health);
            Console.WriteLine("Tower sees hobgoblin and does " + damage + " damage");
            health = hobgoblin.getDamage(health, damage);
            Console.WriteLine("hobgoblins health is " + health);
        }
    }
}

// for future move these classes to own script
class Enemy
{
    // base class for all future enemy variants
    protected int health = 1;
    protected int attack = 1;
    protected int experience = 1;

    // callculate the health lost and returns the current health
    public int getDamage(int health, int damage)
    {
        int currentHealth = health -= damage;
        return currentHealth;
    }
}

class Goblin : Enemy
{
    // gets variables and functions from Enemy
    // sets its own vallue to the variables
    private new int health = 20;
    public new int attack = 5;
    public new int experience = 1;
    
    // sets the vallue of health
    public Goblin(int health)
    {
        this.health = health;
    }

    // retrieve the vallue of health
    public int GetHealth()
    {
        return health;
    }
}

class Tower
{
    // base class for all future tower variants
    protected int damage = 1;
    protected float raduis = 10;
}

class BaseTower : Tower
{
    // gets variables from tower
    // sets its own vallue to the variables
    public new int damage = 5;
    public new float raduis = 30;
}