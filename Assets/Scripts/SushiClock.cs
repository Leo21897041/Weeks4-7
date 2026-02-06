using UnityEngine;
using UnityEngine.UI;
public class SushiClock : MonoBehaviour
{
    public Slider sushiSlider;

    public float clockDuration;
    public float timeWaiting = 0f;

    public GameObject warperObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sushiSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime * 1;
        sushiSlider.value = timeWaiting;

        if (timeWaiting > clockDuration)
        {
            timeWaiting = 0f;
            Debug.Log("Time is Up!");

            //WHEN TIMER IS UP:
            //EITHER -->
            //TURN WARPER OBJECT OFF WHEN IT IS ON
            //TURN WARPER OBJECT ON WHEN IT IS OFF

            bool shouldTurnOn = !warperObject.activeInHierarchy;
            bool shouldTurnOff = warperObject.activeInHierarchy;

            if (shouldTurnOn == true)
            {
                warperObject.SetActive(true);
            }
            if (shouldTurnOff)
            {
                warperObject.SetActive(false);
            }
        }
    }
}
