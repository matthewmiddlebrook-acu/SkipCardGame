using UnityEngine;

[CreateAssetMenu(fileName = "CardManager", menuName = "ScriptableObjects/CardManagerScriptableObject", order = 1)]
public class CardManagerScriptableObject : ScriptableObject {
    public Sprite[] cardFrontSprites;

    public Sprite getCardFront(int cardNumber) => cardNumber > 0 ? cardFrontSprites[cardNumber] : cardFrontSprites[0];
}