using UnityEngine;

public class MovementCannonball : MonoBehaviour
{
    public float cannonballSpeed;

    Vector2 cannonballPosition;

    public Transform crosshairLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootCannonball()
    {
        transform.position += cannonballSpeed * Time.deltaTime * transform.right;

        float distance = Vector2.Distance(transform.position, crosshairLocation.position);

        if (distance < 1)
        {
            Destroy(gameObject);
            Debug.Log("Hit the crosshair");
        }
    }
}
