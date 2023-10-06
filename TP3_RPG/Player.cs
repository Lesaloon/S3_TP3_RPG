using TP3_RPG.Abstract;

namespace TP3_RPG; 

public class Player : Character {
	public Player(string name) : base(name) {
		this.Health = 100;
	}
}