using TP3_RPG.Abstract;

namespace TP3_RPG; 

public class Enemy : Character {
	public Enemy(string name) : base(name) {
		this.Health = 30;
		this.Strength = 5;
		this.Defense = 3;
		this.Speed = 3;
	}
}