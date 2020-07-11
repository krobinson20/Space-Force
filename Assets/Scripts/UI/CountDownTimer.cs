using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private float integrity = 100;


    private float timeLeft = 30f;
    public Text text;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = (timeLeft).ToString("0");
        Debug.Log(timeLeft);
        if(timeLeft < 0 && integrity < 40)
        {
            //Enter the state 
        }
    }
}
