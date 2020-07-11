﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{
    [SerializeField]
    private float initialDescentSpeed = 100;
    public float InitialDescentSpeed
    {
        get { return initialDescentSpeed; }
    }

    [SerializeField]
    private float initialFuel =100f;
    public float InitialFuel
    {
        get { return initialFuel; }
    }

    [SerializeField]
    private float initialPower = 100f;
    public float InitialPower
    {
        get { return initialPower; }
    }

    [SerializeField]
    private float initialIntegrity = 100f;
    public float InitialIntegrity
    {
        get { return initialIntegrity; }
    }
}
