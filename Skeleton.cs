using System;

public class Skeleton : Enemy
{
    private const int skeletonHealth = 25;
    private const int skeletonMinDamage = 4;
    private const int skeletonMaxDamage = 12;

    public Skeleton()
    {
        Health = skeletonHealth;
        Damage = skeletonMaxDamage;
    }
}