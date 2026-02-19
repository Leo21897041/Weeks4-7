using UnityEngine;
using UnityEngine.InputSystem;

public class MovementMainShip : MonoBehaviour
{
    //Variables to control the movement speed and rotate speed
    public float moveSpeed;
    public float rotateSpeed;

    //Vector3 variables to store the position and rotation
    public Vector3 mainShipPosition;
    public Vector3 mainShipRotation;

    //Bools just to see if things are working
    public bool isMovingForward;
    public bool isRotatingRight;
    public bool isRotatingLeft;

    //Reference to the players ship
    public Transform mainShip;

    void Start()
    {
        
    }

    void Update()
    {
        //Sets position and rotation variable to the current position and rotation
        mainShipPosition = transform.position;
        mainShipRotation = transform.eulerAngles;

        //MOVING FORWARDS
        //Run this code if the up arrow key is pressed
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            //Move the ship up
            mainShipPosition += transform.up * moveSpeed * Time.deltaTime;
            isMovingForward = true;
        }
        else 
        {
            isMovingForward = false;
        }

        //TURNING RIGHT
        //Run this code if the right arrow key is pressed
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            //Rotate the ship clockwise
            mainShipRotation.z -= rotateSpeed * Time.deltaTime;
            isRotatingRight = true;
        }
        else
        {
            isRotatingRight = false;
        }

        //TURNING LEFT
        //Run this code if the left arrow key is pressed
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            //Rotate the ship counter-clockwise
            mainShipRotation.z += rotateSpeed * Time.deltaTime;
            isRotatingLeft = true;
        }
        else
        {
            isRotatingLeft = false;
        }

        //Set the new position and rotation to the ship
        transform.position = mainShipPosition;
        transform.eulerAngles = mainShipRotation;
    }
}
