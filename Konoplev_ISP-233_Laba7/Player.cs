class Player
{
    private int health = 100;
    public void Damage(int damage)
    {
        if (damage > 0)
        {
            health -= damage;
            Console.WriteLine($"Персонаж получил {damage} урона. Осталось {health} здоровья");
        }
    }
    public int GetHealth()
    {
        return health;
    }
}

