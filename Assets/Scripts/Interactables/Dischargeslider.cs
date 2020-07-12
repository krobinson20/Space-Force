using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dischargeslider : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
    private Powertext powertext;
    private float holdon;
    void Start()
    {
        ship = GetComponent<Ship>();
        powertext = GameObject.Find("Ship").GetComponent<Powertext>();
    }

    public void SetText(float sliderval)
    {
        holdon = sliderval;
    }

    private void FixedUpdate()
    {
        float temp = holdon * 100;
        powertext.CurrentPower -= (temp / 100) * Time.deltaTime;
        powertext.SetPower(powertext.CurrentPower);
        ship.ShipStats.Power = powertext.CurrentPower;
    }
}