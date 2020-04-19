using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public GameObject selector;

    void Reset() {
        selector = transform.Find("Selection").gameObject;
    }

    void OnMouseOver()
    {
        selector.SetActive(true);
    }

    void OnMouseExit()
    {
        selector.SetActive(false);
    }
}
