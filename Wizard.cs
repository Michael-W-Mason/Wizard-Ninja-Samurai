public class Wizard : Human
{
    public Wizard(string name) : base(name)
    {
        Intelligence = 25;
        health = 50;
    }

    public override int Attack(Human target){
        target.health -= 5 * Intelligence;
        health += 5 * Intelligence;
        return target.health;
    }

    public int Heal(Human target){
        target.health += 10 * Intelligence;
        return target.health;
    }
}