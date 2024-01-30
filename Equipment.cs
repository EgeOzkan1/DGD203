public class Equipment
{
    public Sword Sword { get; private set; }
    public PlateArmor PlateArmor { get; private set; }

    public void EquipSword(Sword sword)
    {
        Sword = sword;
    }

    public void EquipPlateArmor(PlateArmor plateArmor)
    {
        PlateArmor = plateArmor;
    }

    public void DisplayEquipment()
    {
        if (Sword != null)
        {
            Console.WriteLine($"- Sword: {Sword.Name} (Damage Bonus: {Sword.DamageBonus})");
        }

        if (PlateArmor != null)
        {
            Console.WriteLine($"- Plate Armor: {PlateArmor.Name} (Defense Bonus: {PlateArmor.DefenseBonus})");
        }
    }
}
