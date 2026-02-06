using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class BroccoliHover : MonoBehaviour
{
    public GameObject broccoliObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        bool isHoveringBroccoli = EventSystem.current.IsPointerOverGameObject();

        if ()
    }
}
