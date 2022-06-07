class Samurai : Human
{

    public Samurai(string name) : base(name)
    {
        Init();
    }

    public void Init(){
        health = 200;
    }

    public override int Attack(Human target)
    {
        base.Attack(target);
        if(target.health <= 50){
            target.health = 0;
        }
        return target.health;
    }

    public int Meditate(){
        Init();
        return health;
    }
}