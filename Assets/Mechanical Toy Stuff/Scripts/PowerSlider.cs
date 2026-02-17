using UnityEngine;

public class PowerSlider : MonoBehaviour
{
    public float currentSliderValue;

    Vector3 crosshairPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PowerSliderChangeValue(float value)
    {
        currentSliderValue = value;

        crosshairPosition = transform.position;

        crosshairPosition.x = currentSliderValue;

        transform.position = crosshairPosition;
    }
}
