using TP3_RPG.Interface;

namespace TP3_RPG.Abstract; 

public abstract class Character : ICharacter {
	public string Name { get; }
	public int Level { get; set; } = 1;
	public int Xp { get; set; } = 0;
	public double Health { get; set; } = 100;
	public double Strength { get; set; } = 10;
	public int Defense { get; set; } = 5;
	public int Speed { get; set; } = 5;

	public Character(string name)
	{
		this.Name = name;
	}
	public void Attack(ICharacter target)
	{
		Random rnd = new Random();
		double damage = Strength * (rnd.NextDouble() * Strength * 0.1);
		target.BeAttacked(damage, this);
	}

	public void BeAttacked(double damage, ICharacter attacker)
	{
		double dmg = (damage - Defense);
		if (dmg < 0)
		{
			dmg = 0;
		}
		Health = Health - dmg;
	}
}