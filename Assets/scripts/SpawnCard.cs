using UnityEngine;
using System.Collections.Generic;

public class SpawnCard : MonoBehaviour {


	public CardUnit card = new CardUnit();

	public Dictionary<string, Transform> cardDetails = new Dictionary<string, Transform>();

	// Use this for initialization
	void Start () {

		card.setId (1);
		card.setName ("Orc Underdog");
		card.setAttack (12);

		transform.Find ("card_attack").gameObject.GetComponent<TextMesh>().text = card.getAttack().ToString();
		transform.Find ("card_name").gameObject.GetComponent<TextMesh>().text = card.getName().ToString();
		 

		foreach(Transform t in transform)
		{
			cardDetails.Add(t.name, t);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
