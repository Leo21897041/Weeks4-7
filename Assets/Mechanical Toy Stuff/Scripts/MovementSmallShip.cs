using UnityEngine;

public class MovementSmallShip : MonoBehaviour
{
    public float smallShipMoveSpeed;

    private Vector3 smallShipPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        smallShipPosition = transform.position;

        smallShipPosition += Time.deltaTime * smallShipMoveSpeed * transform.up;

        transform.position = smallShipPosition;

        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPosition.y > Screen.height + 30)
        {
            Destroy(gameObject);
        }
    }
}
