using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCard : MonoBehaviour
{
    Vector3 mousePos;
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Debug.Log(mousePos);
    }
}
