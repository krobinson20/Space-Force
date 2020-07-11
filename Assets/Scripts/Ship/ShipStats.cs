using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats
{
    [SerializeField]
    private float initialDescentSpeed;
    public float InitialDescentSpeed
    {
        get { return initialDescentSpeed; }
    }

    [SerializeField]
    private float initialFuel;
    public float InitialFuel
    {
        get { return initialFuel; }
    }

    [SerializeField]
    private float initialPower;
    public float InitialPower
    {
        get { return initialPower; }
    }

    [SerializeField]
    private float initialIntegrity;
    public float InitialIntegrity
    {
        get { return initialIntegrity; }
    }
}
