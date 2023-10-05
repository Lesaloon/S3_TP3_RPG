using TP3_RPG.Interface;

namespace TP3_RPG.Abstract; 

public abstract class Character : ICharacter {
	public string name { get; }
	public int level { get; set; }
	public int xp { get; set;  }
	public double health { get; set; }
	public double strength { get; set; }
	public int defense { get; set; }
	public int speed { get; set; }

	public void Attack(ICharacter target)
	{
		Random rnd = new Random();
		double damage = strength * (rnd.NextDouble() * strength * 0.1);
		target.BeAttacked(damage, this);
	}

	public void BeAttacked(double damage, ICharacter attacker)
	{
		double dmg = (damage - defense);
		if (dmg < 0)
		{
			dmg = 0;
		}
		health = health - dmg;
	}
}