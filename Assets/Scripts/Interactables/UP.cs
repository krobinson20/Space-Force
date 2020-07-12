using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UP : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
    private Integritytext integritytext;
    private Powertext powertext;

    void Awake()
    {
        ship = GetComponent<Ship>();
        integritytext = GameObject.Find("Ship").GetComponent<Integritytext>();
        powertext = GameObject.Find("Ship").GetComponent<Powertext>();
    }

    public void SetText()
    {
        //call the funciton that will handle the math and pass it back to here
        //that will edit the value for the numbers to change
        integritytext.CurrentIntegrity -= 1;
        powertext.CurrentPower -= 1;
        integritytext.SetIntegrity(integritytext.CurrentIntegrity);
        powertext.SetPower(powertext.CurrentPower);
        ship.ShipStats.Power = powertext.CurrentPower;
        ship.ShipStats.Integrity = integritytext.CurrentIntegrity;
    }

}
