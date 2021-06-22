using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsManager : MonoBehaviour
{
    public float points;
    public TextMeshProUGUI text;
    void Update()
    {
        text.text = "p1 score: \n " + points;
    }
}
