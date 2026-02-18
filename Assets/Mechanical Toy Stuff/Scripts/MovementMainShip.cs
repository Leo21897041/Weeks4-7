using UnityEngine;
using UnityEngine.InputSystem;

public class MovementMainShip : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public Vector3 mainShipPosition;
    public Vector3 mainShipRotation;

    public bool isMovingForward;
    public bool isRotatingRight;
    public bool isRotatingLeft;

    public Transform mainShip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainShipPosition = transform.position;
        mainShipRotation = transform.eulerAngles;

        //MOVING FORWARDS
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            mainShipPosition += transform.up * moveSpeed * Time.deltaTime;
            isMovingForward = true;
        }
        else 
        {
            isMovingForward = false;
        }

        //TURNING RIGHT
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            mainShipRotation.z -= rotateSpeed * Time.deltaTime;
            isRotatingRight = true;
        }
        else
        {
            isRotatingRight = false;
        }

        //TURNING LEFT
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            mainShipRotation.z += rotateSpeed * Time.deltaTime;
            isRotatingLeft = true;
        }
        else
        {
            isRotatingLeft = false;
        }

        transform.position = mainShipPosition;
        transform.eulerAngles = mainShipRotation;
    }
}
