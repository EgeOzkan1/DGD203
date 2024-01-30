public class Sword
{
    public string Name { get; private set; }
    public int DamageBonus { get; private set; }

    public Sword(string name, int damageBonus)
    {
        Name = name;
        DamageBonus = damageBonus;
    }
}

public class PlateArmor
{
    public string Name { get; private set; }
    public int DefenseBonus { get; private set; }

    public PlateArmor(string name, int defenseBonus)
    {
        Name = name;
        DefenseBonus = defenseBonus;
    }
}
