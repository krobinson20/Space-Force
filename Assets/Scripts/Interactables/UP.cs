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
    void Awake()
    {
        ship = GetComponent<Ship>();
        integritytext = GameObject.Find("Ship").GetComponent<Integritytext>();
    }

    public void SetText()
    {
        integritytext.CurrentIntegrity -= 1;
        integritytext.SetIntegrity(integritytext.CurrentIntegrity);        
    }


}
