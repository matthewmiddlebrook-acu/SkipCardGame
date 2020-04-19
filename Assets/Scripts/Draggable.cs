using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Draggable : MonoBehaviour {
    private Vector3 initialPoint;
    private Vector3 screenPoint;
    private Vector3 offset;

    void Start() {}

    void OnMouseDown() {
        if (!DOTween.IsTweening(transform) && enabled) {
            initialPoint = gameObject.transform.position;
            screenPoint = Camera.main.WorldToScreenPoint(initialPoint);
            offset = initialPoint - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            
            transform.DOMove(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z - 2)) + offset, 0.25f);
        }
    }

    void OnMouseDrag() {
        if (!DOTween.IsTweening(transform) && enabled) {
            Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z - 2);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
            transform.position = cursorPosition;
        }
    }
}
