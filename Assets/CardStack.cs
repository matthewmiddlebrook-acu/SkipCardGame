using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
	public List<GameObject> cards;
	public GameObject gameManager;
	public float stackOffset = 0.05f;

	[Header("Rules")]
	public bool sequential;
	public bool stackable;

	// Start is called before the first frame update
	void Start()
	{
		int cardNum = 0;
		CardCreator cc = gameManager.GetComponent<CardCreator>();
		for (int i = 1; i <= 12; i++) {
			GameObject newCard = cc.CreateCard(i, CardType.Default, new Vector3(transform.position.x, transform.position.y, transform.position.z - cardNum * stackOffset), transform.rotation);
			newCard.transform.parent = gameObject.transform;
			cards.Add(newCard);
			cardNum++;
		}
		for (int i = 0; i < 18; i++) {
			GameObject newCard = cc.CreateCard(0, CardType.Default, new Vector3(transform.position.x, transform.position.y, transform.position.z - cardNum * stackOffset), transform.rotation);
			newCard.transform.parent = gameObject.transform;
			cards.Add(newCard);
			cardNum++;
		}
	}

	void Shuffle() {
		for (int i = 0; i < cards.Count; i++) {
			GameObject temp = cards[i];
			int randomIndex = Random.Range(i, cards.Count);
			cards[i] = cards[randomIndex];
			cards[randomIndex] = temp;
		}
	}
}
