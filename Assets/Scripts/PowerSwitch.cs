using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PowerSwitch : MonoBehaviour
{
    public bool isOn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
        gameObject.SetActive(true);
        }
        if (isOn == false)
        {
        gameObject.SetActive(false);
        }
    }
    public void TurnedOn()
    {
        isOn = true;
    }
    public void TurnedOff()
    { 
        isOn = false;
    }
}
