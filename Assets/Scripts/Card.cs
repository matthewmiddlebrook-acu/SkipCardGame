using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[RequireComponent(typeof(CardRenderer))]
public class Card : MonoBehaviour {
    [Range(-12, 12)]
    public int number = 1;
    public CardType cardType = CardType.Default;

    public CardManagerScriptableObject cardManager;

    public CardRenderer cardRenderer;

    public GameObject front;
    public GameObject back;

    public void SetCard(int number, CardType cardType) {
        this.number = number;
        this.cardType = cardType;

        cardRenderer.UpdateCard();
    }

    void Reset() {
        cardRenderer = GetComponent<CardRenderer>();
        front = transform.Find("Front").gameObject;
        back = transform.Find("Back").gameObject;
    }

    void OnValidate() {
        cardRenderer.UpdateCard();
    }
}
