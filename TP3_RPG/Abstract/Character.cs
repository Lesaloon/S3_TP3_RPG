using TP3_RPG.Interface;

namespace TP3_RPG.Abstract; 

public abstract class Character : ICharacter {
	public string Name { get; }
	public int Level { get; set; }
	public int Xp { get; set;  }
	public double Health { get; set; }
	public double Strength { get; set; }
	public int Defense { get; set; }
	public int Speed { get; set; }

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