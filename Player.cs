using System;
using System.Collections.Generic;

public class Player
{
    private const int playerMaxHealth = 100;
    private const int playerDefaultMinDamage = 8; // Increased damage range
    private const int playerDefaultMaxDamage = 17;

    public string Name { get; private set; }
    public int Health { get; private set; }
    public Inventory Inventory { get; private set; }
    public Equipment EquippedItems { get; private set; } // New property for equipped items

    public Player(string name, List<Item> inventoryItems)
    {
        Name = name;
        Health = playerMaxHealth;
        Inventory = new Inventory();
        EquippedItems = new Equipment(); // Initialize equipped items

        // Add starting inventory items
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            Inventory.AddItem(inventoryItems[i]);
        }

        // Equip a sword and plate armor
        EquipSword();
        EquipPlateArmor();
    }

    public void TakeItem(Item item)
    {
        Inventory.AddItem(item);
    }

    public void DropItem(Item item)
    {
        // This will be implemented in the future!
    }

    public void CheckInventory()
    {
        Console.WriteLine($"Player {Name}'s Inventory:");

        // Display equipped items
        Console.WriteLine("Equipped Items:");
        EquippedItems.DisplayEquipment();

        // Display other inventory items
        Console.WriteLine("Other Inventory Items:");
        for (int i = 0; i < Inventory.Items.Count; i++)
        {
            Console.WriteLine($"- {Inventory.Items[i]}");
        }
    }

    public int Damage()
    {
        Random damageRandom = new Random();
        int damage = damageRandom.Next(playerDefaultMinDamage, playerDefaultMaxDamage + 1);

        // Adjust damage based on equipped sword
        if (EquippedItems.Sword != null)
        {
            damage += EquippedItems.Sword.DamageBonus;
        }

        return damage;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;

        Console.WriteLine($"You take {amount} damage. You have {Health} health left");

        if (Health <= 0)
        {
            Console.WriteLine("YOU DIED");
        }
    }

    // Equip a sword to the player
    private void EquipSword()
    {
        Sword sword = new Sword("Iron Sword", 5); // You can adjust the sword stats
        EquippedItems.EquipSword(sword);
        Console.WriteLine($"Equipped {sword.Name}");
    }

    // Equip plate armor to the player
    private void EquipPlateArmor()
    {
        PlateArmor plateArmor = new PlateArmor("Steel Plate Armor", 5); // You can adjust the armor stats
        EquippedItems.EquipPlateArmor(plateArmor);
        Console.WriteLine($"Equipped {plateArmor.Name}");
    }
}
