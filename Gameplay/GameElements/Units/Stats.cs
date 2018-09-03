namespace Gameplay.GameElements.Units
{
    public class Stats
    {
        public int Level { get; set; }

        // Main stats
        public int Strength { get; set; } // Increase : physical damages, health
        public int Intelligence { get; set; } // Increase : magical damages, magical defense - Decrease : magical status effect*
        public int Constitution { get; set; } // Increase : health, physical defense - Decrease : negative status changes, knockback
        public int Agility { get; set; } // Increase : evasion, ASPD, movement speed - Decrease : cast
        public int Accuracy { get; set; } // Increase : hit chances, ranged damages
        public int Luck { get; set; } // Increase : critical strike, evasion, loot chance

        // Secondary stats
        public int Health => 100 + Constitution * 5 + Strength * 2;
        public int Evasion => 0;
        public int Hit => 0;
        public int CriticalChance => 0;
        public int CriticalModifier => 0;
        public int Cast => 0;
        public int AttackSpeed => 0;
        public int MovementSpeed => 0;
        public int PhysicalDefense => 0;
        public int MagicalDefense => 0;
        public int LootChance => 0; // Maybe add upgrade item rarity on loot
    }
}