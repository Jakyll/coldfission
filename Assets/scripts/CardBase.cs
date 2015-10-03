using System.Collections;

public class CardBase {

	private int id;
	private string name;
	private string description;
	private int cost;
	private string[] subtype;

	public void setId(int id) {
		this.id = id;
	}

	public int getId() {
		return this.id;
	}

	public void setName(string name) {
		this.name = name;
	}
	
	public string getName() {
		return this.name;
	}

	public void setDescription(string description) {
		this.description = description;
	}
	
	public string getDescription() {
		return this.description;
	}

	public void setCost(int cost) {
		this.cost = cost;
	}
	
	public int getCost() {
		return this.cost;
	}
}
