using UnityEngine;

public class MovementSmallShip : MonoBehaviour
{
    public float smallShipMoveSpeed;
    public float offScreen = 30f;
    public float collisionDetectionDistance = 1f;

    private Vector3 smallShipPosition;

    public Transform mainShip;
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

        if (screenPosition.y > Screen.height + offScreen || screenPosition.y < 0 - offScreen)
        {
            Destroy(gameObject);
        }

        float distanceToMainShip = Vector2.Distance(transform.position, mainShip.position);

        if (distanceToMainShip < collisionDetectionDistance)
        {
            Destroy(mainShip.gameObject);
        }
    }
}
