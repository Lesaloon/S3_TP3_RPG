namespace TP3_RPG.Interface; 

public interface ICharacter {
	
	// States
	
	// a character has a name
	public string Name { get; }
	// a character has a level
	public int Level { get; set; }
	// a character has experiance
	public int Xp { get; set;  }
	// a character has a health
	public double Health { get; set; }
	// a character has a strength
	public double Strength { get; set; }
	// a character has a defense
	public int Defense { get; set; }
	// a character has a speed
	public int Speed { get; set; }
	
	// Methods
	// a character can attack
	// this method will calculate the damage and call t
	// he BeAttacked function on the target
	public void Attack(ICharacter target);
	// a character can be attacked
	// this method will calculate the damage and apply it to the health
	public void BeAttacked(double damage, ICharacter attacker);
	
	
}