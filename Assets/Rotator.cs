﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedOfRotator = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speedOfRotator);
    }
}
