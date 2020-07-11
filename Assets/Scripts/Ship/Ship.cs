using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [Header("Ship HUD")]
    [SerializeField]
    private ShipBrain shipBrain;
    public ShipBrain ShipBrain
    {
        get { return shipBrain; }
    }
    
    [SerializeField]
    private FuelBar fuelBar;
    public FuelBar FuelBar
    {
        get { return fuelBar; }
    }

    [SerializeField]
    private PowerBank powerBank;
    public PowerBank PowerBank
    {
        get { return powerBank; }
    }

    [SerializeField]
    private IntegrityBar integrityBar;
    public IntegrityBar IntegrityBar
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



       
    // Start is called before the first frame update
    void Start()
    {
        FuelBar.SetMaxFuel(ShipStats.InitialFuel);
        PowerBank.SetMaxPower(ShipStats.InitialPower);
        IntegrityBar.SetMaxIntegrity(ShipStats.InitialIntegrity);

        FuelBar.SetFuel(ShipStats.InitialFuel);
        //DescentSpeedDisplay.SetInitialDescentSpeed(ShipStats.InitialDescentSpeed)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
