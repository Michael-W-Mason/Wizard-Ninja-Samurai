class Ninja : Human
{
    public Ninja(string name) : base(name)
    {
        Dexterity = 175;
    }

    public override int Attack(Human target)
    {
        Random rand = new Random();
        int crit = rand.Next(0, 100);
        target.health -= 5 * Dexterity - (crit > 20 ? 10 : 0);
        return target.health;
    }

    public int Steal(Human target)
    {
        target.health -= 5;
        health += 5;
        return target.health;
    }
}