using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using EasyButtons;

public class Flippable : MonoBehaviour
{
    private bool flipped = true;

    [Button]
    public void FlipCard() {
        if (!Application.isPlaying) {
            InstantFlip();
        } else {
            if (flipped) {
                transform.DORotate(new Vector3(0,180,0), 0.5f);
            } else {
                transform.DORotate(new Vector3(0,0,0), 0.5f);
            }
        }
        flipped = !flipped;
    }

    private void InstantFlip() {
        if (flipped) {
            transform.localEulerAngles = new Vector3(0,180,0);
        } else {
            transform.localEulerAngles = new Vector3(0,0,0);
        }
    }
}
