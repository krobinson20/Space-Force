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
        ship = GetComponent<Ship>();
        fueltext = GameObject.Find("Ship").GetComponent<Fueltext>();
    }

    public void SetText(float sliderval)
    {
        fueltext.CurrentFuel = Mathf.Round(sliderval * 100) ;
        fueltext.SetFuel(fueltext.CurrentFuel);
    }
}
