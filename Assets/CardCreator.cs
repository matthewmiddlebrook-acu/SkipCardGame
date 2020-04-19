using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    public GameObject cardPrefab;

    public GameObject CreateCard(int number, CardType cardType, Vector3 position, Quaternion rotation) {
        GameObject newCardObject = Instantiate(cardPrefab, position, rotation);

        Card newCard = newCardObject.GetComponent<Card>();
        newCard.SetCard(number, cardType);

        return newCardObject;
    }
}
