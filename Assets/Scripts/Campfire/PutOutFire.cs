using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PutOutFire : MonoBehaviour
{
    public GameObject lightOff;


    void Update()
    {
        StartCoroutine(LightOff());
        //Invoke("LightOff", 10);
       
    }



    private IEnumerator LightOff()
    {
       // if (lightOff.SetActive(true){
            yield return new WaitForSecondsRealtime(10);
            lightOff.SetActive(false);
 
    }
    /*
    void LightOff()
    {

        lightOff.SetActive(false);
    }*/

    
}
