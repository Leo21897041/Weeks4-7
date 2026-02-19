using UnityEngine;

public class PowerSlider : MonoBehaviour
{
    //Create a variable to store the value of the slider
    public float currentSliderValue;

    //Created a Vector2 variable to store the position value of the crosshair
    Vector2 crosshairPosition;

    void Start()
    {
        
    }

    void Update()
    {

    }

    //Run this method when the value of the slider changes
    public void PowerSliderChangeValueRightCannon(float value)
    {
        //Saves the sliders vaue
        currentSliderValue = value;

        //Gets the current position of the crosshair
        crosshairPosition = transform.localPosition;

        //Changes the x value of the Vector2 using the slider
        crosshairPosition.x = currentSliderValue;

        //Set the new position to the position of the crosshair
        transform.localPosition = crosshairPosition;
    }

    public void PowerSliderChangeValueLeftCannon(float value)
    {
        //Saves the sliders vaue
        currentSliderValue = value;

        //Gets the current position of the crosshair
        crosshairPosition = transform.localPosition;

        //Changes the x value of the Vector2 using the slider
        crosshairPosition.x = -currentSliderValue;

        //Set the new position to the position of the crosshair
        transform.localPosition = crosshairPosition;
    }
}
