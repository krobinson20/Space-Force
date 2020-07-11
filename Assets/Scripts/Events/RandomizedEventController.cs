using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizedEventController : MonoBehaviour
{
    private RandomizedEvent randomizedEvent;
    public RandomizedEvent RandomizedEvent
    {
        get { return randomizedEvent; }
    }

    private GravityWell gWell;

    private IonStorm iStorm;

    private AtmosphericDensity aDensity;

    private List<RandomizedEvent> randomEvents = new List<RandomizedEvent>();
    // Start is called before the first frame update
    void Start()
    {
        randomizedEvent = GetComponent<RandomizedEvent>();
        randomEvents.Add(gWell);
        randomEvents.Add(iStorm);
        randomEvents.Add(aDensity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RandomizedEventState(RandomizedEvent rEvent)
    {

    }
}
