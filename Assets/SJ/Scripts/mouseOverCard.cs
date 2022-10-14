using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverCard : MonoBehaviour
{
    [SerializeField] GameObject card;
    void OnMouseOver()
    {
        card.GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        card.GetComponent<Renderer>().material.color = Color.white;
    }
}