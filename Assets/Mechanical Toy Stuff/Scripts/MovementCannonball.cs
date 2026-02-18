using UnityEngine;

public class MovementCannonball : MonoBehaviour
{
    public float cannonballSpeed;
    public float hitbox = 1f;

    public bool isShot;

    public Transform crosshairLocation;
    public Transform smallShip;

    void Start()
    {

    }

    void Update()
    {
        if (isShot == true)
        { 
            transform.position += cannonballSpeed * Time.deltaTime * transform.right;

            float distance = Vector2.Distance(transform.position, crosshairLocation.position);
            float distanceToSmallShip = Vector2.Distance(transform.position, smallShip.position);

            if (distance < 0.1)
            {
                if (distanceToSmallShip < hitbox)
                { 
                    Destroy(smallShip.gameObject);
                    Debug.Log("Hit the small ship");
                }

                Debug.Log("Hit the crosshair");
                Destroy(gameObject);
            }
        }
    }

    public void ShootCannonball()
    {
        isShot = true;
    }
}
