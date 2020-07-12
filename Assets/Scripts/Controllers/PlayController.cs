using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] private bool integrityThresholdFlag;
    [SerializeField] private float integrityThreshold = 40.0f;
    [SerializeField] private bool zeroIntegrity;
    [SerializeField] private bool zeroFuel;
    [SerializeField] private bool zeroPower;
    [SerializeField] private bool RandEventTimeThreshold;
    [SerializeField] private bool countDownTimerFlag;

    [SerializeField] private GameOverController gameOverCont;
    [SerializeField] private GameController gameCont;
    [SerializeField] private RandEventController randEventCont;
    
    public void SetIntegrityFlag(float integVal)
    {
        if(integVal <= 0)
        {
            zeroIntegrity = true;
            Exit();
        }
        else if (integVal < integrityThreshold)
        {
            integrityThresholdFlag = true;
        }
        else
        {
            integrityThresholdFlag = false;
            zeroIntegrity = false;
        }
    }

    public void SetFuelFlag(float fuelVal)
    {
        if (fuelVal <= 0)
        {
            zeroFuel = true;
        }
        else
        {
            zeroFuel = false;
        }
    }

    public void SetPowerFlag(float powerVal)
    {
        if(powerVal <= 0)
        {
            zeroPower = true;
        }
        else
        {
            zeroPower = false;
        }
    }

    public void SetTimeThreshold(float time)
    {
        if (time > 10f)
        {
            RandEventTimeThreshold = true;
        }
        else
        {
            RandEventTimeThreshold = false;
        }
    }

    private void Update()
    {
        if (Time.deltaTime < 10f)
        {
            SetTimeThreshold(Time.deltaTime);
        }
    }
    public void Awaken()
    {
        integrityThresholdFlag = false;
        zeroIntegrity = false;
        zeroFuel = false;
        zeroPower = false;
        RandEventTimeThreshold = false;
        gameCont = GetComponent<GameController>();
        gameOverCont = GetComponent<GameOverController>();
        randEventCont = GetComponent<RandEventController>();
    }

    public void Exit()
    {
        if (zeroIntegrity)
        {
            
        }
            
    }
}
