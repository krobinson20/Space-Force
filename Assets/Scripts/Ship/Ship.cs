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
    private Fueltext fuelText;
    public Fueltext FuelText
    {
        get { return fuelText; }
    }

    [SerializeField]
    private Powertext powerText;
    public Powertext PowerText
    {
        get { return powerText; }
    }

    [SerializeField]
    private Integritytext integrityText;
    public Integritytext IntegrityText
    {
        get { return integrityText; }
    }

    [SerializeField]
    private ShipStats shipStats;
    public ShipStats ShipStats
    {
        get { return shipStats; }
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
        // FuelBar.SetMaxFuel(ShipStats.InitialFuel);
        // PowerBank.SetMaxPower(ShipStats.InitialPower);
        //IntegrityBar.SetMaxIntegrity(ShipStats.InitialIntegrity);
        //FuelBar.SetFuel(ShipStats.InitialFuel);
        //DescentSpeedDisplay.SetInitialDescentSpeed(ShipStats.InitialDescentSpeed)
        IntegrityText.SetMaxIntegrity(ShipStats.InitialIntegrity);
        PowerText.SetMaxPower(ShipStats.InitialPower);
        FuelText.SetMaxFuel(ShipStats.InitialFuel);

    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
