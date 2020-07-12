using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedslider : MonoBehaviour
{
    [SerializeField]
    public Text TextField;

    private Ship ship;
    private Fueltext fueltext;

    void Start()
    {
        ship = GameObject.Find("Ship").GetComponent<Ship>();
        fueltext = GameObject.Find("Ship").GetComponent<Fueltext>();
    }

    private float holdon = .5f;

    public void SetText(float sliderval)
    {
        holdon = sliderval;      
    }

    private void FixedUpdate()
    {
        if (holdon > .5)
        {
            float temp = holdon;
            float percent = holdon ;
            fueltext.CurrentFuel -= percent * Time.deltaTime;
            fueltext.SetFuel(fueltext.CurrentFuel);
        }
        else if (holdon < .5)
        {
            float temp = (holdon - .5f)* -2;
            float percent = holdon;
            fueltext.CurrentFuel -= percent * Time.deltaTime;
            fueltext.SetFuel(fueltext.CurrentFuel);
            

        }
        //ship.ShipStats.Fuel = fueltext.CurrentFuel;
        
    }
}
