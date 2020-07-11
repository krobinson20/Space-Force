using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBrain : MonoBehaviour
{
    [Header("Ship HUD")]
    [SerializeField]
    private FuelBar fuelBar;
    public FuelBar FuelBar
    {
        get; protected set;
    }
    [SerializeField]
    private FuelBar powerBar;
    public FuelBar PowerBar
    {
        get; protected set;
    }
    [SerializeField]
    private FuelBar integrityBar;
    public FuelBar IntegrityBar
    {
        get; protected set;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
