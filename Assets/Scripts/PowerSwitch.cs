using UnityEngine;

public class PowerSwitch : MonoBehaviour
{
    public GameObject objectToTurnOn;

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
            objectToTurnOn.SetActive(true);
        }

        if (isOn == false)
        {
            objectToTurnOn.SetActive(false);
        }
    }
    public void OnClickTurnOn()
    {
        isOn = true;
    }
    public void OnClickTurnOff()
    { 
        isOn = false;
    }
}
