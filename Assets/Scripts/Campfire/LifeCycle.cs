using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LifeCycle : MonoBehaviour
{
    [SerializeField] private Light2D lightPoint;
    [SerializeField] private CycleOn [] cyclesOn;
    [SerializeField] private float timePerCycle;

    private float timeCurrentCycle = 0;
    private float percentageCycle;
    private int cycleCurrent = 0;
    private int NextCycle = 1;

    // Start is called before the first frame update
    void Start()
    {
        lightPoint.color = cyclesOn[0].colorCycle;
    }

    // Update is called once per frame
    void Update()
    {
        timeCurrentCycle += Time.deltaTime;
        percentageCycle = timeCurrentCycle/ timePerCycle;

        if (timeCurrentCycle >= timePerCycle) 
        {
            timeCurrentCycle = 0;
            cycleCurrent = NextCycle;

            if (NextCycle + 1 > cyclesOn.Length - 1) 
            {
                NextCycle = 1;
            }
            else
            {
                NextCycle += 1;
            }
        }
        ChangeColor(cyclesOn[cycleCurrent].colorCycle, cyclesOn[NextCycle].colorCycle);
    }

    private void ChangeColor(Color colorCurrent, Color nextColor)
    {
        lightPoint.color = Color.Lerp(colorCurrent, nextColor, percentageCycle);
    }
}
