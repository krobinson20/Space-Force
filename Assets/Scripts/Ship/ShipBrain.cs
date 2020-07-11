﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShipBrain : MonoBehaviour
{
    [Header("Ship HUD")]
    [SerializeField]
    private FuelBar fuelBar;
    public FuelBar FuelBar
    {
        get { return fuelBar; }
    }

    [SerializeField]
    private FuelBar powerBar;
    public FuelBar PowerBar
    {
        get { return powerBar; }
    }

    [SerializeField]
    private FuelBar integrityBar;
    public FuelBar IntegrityBar
    {
        get { return integrityBar; }
    }

    [SerializeField]
    private ShipStats shipStats;
    public ShipStats ShipStats
    {
        get { return shipStats; }
    }

    [SerializeField]
    private BarMath barMath;
    public BarMath BarMath
    {
        get { return barMath; }
    }
    /*[Header("Ship Components")]
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    public SpriteRenderer SpriteRenderer
    {
        get; protected set;
    }*/
}