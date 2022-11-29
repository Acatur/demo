using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastInventoryClick : MonoBehaviour
{
    
    void Start()
    {
        
    }


    bool instGreen = false;
    public void OnClickInstrumentGreen()
    {
        Random.isCoursor = "greenPoint";
    }

    bool instYellow = false;
    public void OnClickInstrumentYellow()
    {
        Random.isCoursor = "yellowPoint";
        Debug.Log(Random.isCoursor);

    }

    bool instRed = false;
    public void OnClickInstrumentRed()
    {
        Random.isCoursor = "redPoint";
    }

    bool instBlue = false;

    public void OnClickInstrumentBlue()
    {
        Random.isCoursor = "bluePoint";
    }
}


