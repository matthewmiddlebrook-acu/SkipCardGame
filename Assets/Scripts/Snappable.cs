using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Snappable : MonoBehaviour {
    private Vector3 initialPoint;

    void Start() {
        initialPoint = gameObject.transform.position;
    }

    void OnMouseUp() {
        if (!DOTween.IsTweening(transform) && enabled) {
            transform.DOMove(initialPoint, 0.25f);
        }
    }
}
