using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public static int PinScore;
    public Text CountText;
    void Start()
    {
        PinScore = 0;
    }


    public void Update()
    {
        CountText.text = PinScore.ToString();
    }
}

