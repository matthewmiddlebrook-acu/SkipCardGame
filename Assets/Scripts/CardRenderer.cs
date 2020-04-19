using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardRenderer : MonoBehaviour {
    public Card card;
    public GameObject frontFace;

    void Reset() {
        card = GetComponent<Card>();

        frontFace = card.front.transform.Find("FrontFace").gameObject;
    }

    public void UpdateCard() {
        frontFace.GetComponent<SpriteRenderer>().sprite = card.cardManager.getCardFront(card.number);
        TextMeshPro tmp = card.front.transform.Find("FrontFaceSkipNums").GetComponent<TextMeshPro>();
        if (card.number < 0) {
            tmp.enabled = true;
            tmp.text = -card.number + "\n" + -card.number;
        } else {
            tmp.enabled = false;
        }
    }
}
