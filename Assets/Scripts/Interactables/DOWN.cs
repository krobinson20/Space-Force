using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DOWN : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
   
    private Powertext powertext;

    void Awake()
    {
        ship = GetComponent<Ship>();
        powertext = GameObject.Find("Ship").GetComponent<Powertext>();
    }

    public void SetText()
    {
        powertext.CurrentPower -= 1;
        powertext.SetPower(powertext.CurrentPower);
        ship.ShipStats.Power = powertext.CurrentPower;
    }

}
