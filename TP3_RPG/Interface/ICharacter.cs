namespace TP3_RPG.Interface; 

public interface ICharacter {
	
	// States
	
	// a character has a name
	public string name { get; }
	// a character has a level
	public int level { get; set; }
	// a character has experiance
	public int xp { get; set;  }
	// a character has a health
	public double health { get; set; }
	// a character has a strength
	public double strength { get; set; }
	// a character has a defense
	public int defense { get; set; }
	// a character has a speed
	public int speed { get; set; }
	
	// Methods
	// a character can attack
	// this method will calculate the damage and call t
	// he BeAttacked function on the target
	public void Attack(ICharacter target);
	// a character can be attacked
	// this method will calculate the damage and apply it to the health
	public void BeAttacked(double damage, ICharacter attacker);
	
	
}