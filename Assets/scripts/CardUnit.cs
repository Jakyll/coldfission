using System.Collections;

public class CardUnit : CardBase {
	private int attack;
	private int defence;
	private int move;

	public void setAttack(int attack) {
		this.attack = attack;
	}

	public int getAttack() {
		return this.attack;
	}

	public void setDefence(int defence) {
		this.defence = defence;
	}
	
	public int getDefence() {
		return this.defence;
	}

	public void setMove(int move) {
		this.move = move;
	}
	
	public int getMove() {
		return this.move;
	}
}
