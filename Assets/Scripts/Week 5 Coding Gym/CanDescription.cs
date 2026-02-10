using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Unity.Collections.LowLevel.Unsafe;
using JetBrains.Annotations;

public class CanDescription : MonoBehaviour
{
    public bool isOn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, currentMousePosition);

        if (distance < 1)
        {
            isOn = true;
        }
        else 
        {
            isOn = false;
        }
    }
}
