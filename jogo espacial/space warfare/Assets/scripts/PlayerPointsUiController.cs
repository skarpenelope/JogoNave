using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPointsUiController : MonoBehaviour
{
    private TMP_Text pointstext;
    private void OnEnable()
    {
        Observer.OnPointsChanged += UpdatePoints;
    }

    private void OnDisable()
    {
        Observer.OnPointsChanged -= UpdatePoints;
    }

    private void Awake()
    {
        pointstext = GetComponent<TMP_Text>();
    }

    private void UpdatePoints(int value)
    {
        pointstext.text = value.ToString();
    }
}
