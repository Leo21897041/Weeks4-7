using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class CookieDescription : MonoBehaviour
{
    public GameObject cookie;

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
            cookie.SetActive(true);
        }
        else
        {
            cookie.SetActive(false);
        }
    }
}
