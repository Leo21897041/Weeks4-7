using UnityEngine;

public class MovementCannonball : MonoBehaviour
{
    public float cannonballSpeed;

    public bool isShot;

    public Transform crosshairLocation;

    void Start()
    {

    }

    void Update()
    {
        if (isShot == true)
        { 
            transform.position += cannonballSpeed * Time.deltaTime * transform.right;

            float distance = Vector2.Distance(transform.position, crosshairLocation.position);

            if (distance < 0.1)
            {
                Destroy(gameObject);
                Debug.Log("Hit the crosshair");
            }  
        }
    }

    public void ShootCannonball()
    {
        isShot = true;
    }
}
