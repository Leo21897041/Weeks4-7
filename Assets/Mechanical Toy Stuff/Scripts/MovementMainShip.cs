using UnityEngine;
using UnityEngine.InputSystem;

public class MovementMainShip : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public Vector3 position;
    public Vector3 rotation;

    public bool isMovingForward;
    public bool isRotatingRight;
    public bool isRotatingLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        rotation = transform.eulerAngles;

        //MOVING FORWARDS
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            position += transform.up * moveSpeed * Time.deltaTime;
            isMovingForward = true;
        }
        else 
        {
            isMovingForward = false;
        }

        //TURNING RIGHT
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            rotation.z -= rotateSpeed * Time.deltaTime;
            isRotatingRight = true;
        }
        else
        {
            isRotatingRight = false;
        }

        //TURNING LEFT
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            rotation.z += rotateSpeed * Time.deltaTime;
            isRotatingLeft = true;
        }
        else
        {
            isRotatingLeft = false;
        }

        transform.position = position;
        transform.eulerAngles = rotation;
    }
}
