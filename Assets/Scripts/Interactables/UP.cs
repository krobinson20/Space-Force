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
        integritytext = GetComponent<Integritytext>();
    }

    public void SetText()
    {
        
      float temp =  integritytext.currentintegrity--;

      integritytext.SetIntegrity(temp);

       
        
    }


}
